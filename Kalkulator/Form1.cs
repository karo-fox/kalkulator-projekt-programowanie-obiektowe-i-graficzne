using System.Transactions;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        private readonly string DECIMAL_SEPARATOR = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private const int CHAR_LIMIT = 15;
        private const string DEFAULT_VALUE = "0";
        private const string FORBIDDEN_OPERATION_MSG = "Operacja niedozwolona";
        private readonly Color BTN_DISABLED = Color.White;
        private (Button, Color)[] BUTTONS_TO_DISABLE;

        private double currentValue = 0.0;
        private double previousValue = 0.0;
        private Func<double, double, double>? previousOperation = null;
        private bool didDivide = false;
        public Calculator()
        {
            InitializeComponent();
            BUTTONS_TO_DISABLE = [(addBtn, SystemColors.ControlDarkDark), (subtractBtn, SystemColors.ControlDarkDark), (multiplyBtn, SystemColors.ControlDarkDark), (divideBtn, SystemColors.ControlDarkDark), (squareBtn, SystemColors.ControlDarkDark), (squareRootBtn, SystemColors.ControlDarkDark), (oneOverBtn, SystemColors.ControlDarkDark), (plusMinusBtn, SystemColors.ControlDarkDark), (separatorBtn, SystemColors.ControlDarkDark), (eraseLastBtn, SystemColors.ControlDarkDark), (equalsBtn, SystemColors.MenuHighlight),];
        }

        private void InsertDigit(object sender, EventArgs e)
        {
            if (displayArea.Text == FORBIDDEN_OPERATION_MSG)
            {
                EnableBtns();
            }
            if (displayArea.Text.Length >= CHAR_LIMIT && displayArea.Text != FORBIDDEN_OPERATION_MSG)
            {
                return;
            }
            if (displayArea.Text == DEFAULT_VALUE || displayArea.Text == FORBIDDEN_OPERATION_MSG)
            {
                displayArea.Text = string.Empty;
            }
            displayArea.Text += ((Button)sender).Text;
        }

        private void InsertSeparator(object sender, EventArgs e)
        {
            if (displayArea.Text.Contains(DECIMAL_SEPARATOR))
            {
                return;
            }
            displayArea.Text += DECIMAL_SEPARATOR;
        }

        private void Clear(object sender, EventArgs e)
        {
            displayArea.Text = DEFAULT_VALUE;
            tempDisplayArea.Text = "";
            previousOperation = null;
            previousValue = 0.0;
            currentValue = 0.0;
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            if (previousOperation == null)
            {
                Clear(sender, e);
                return;
            }
            displayArea.Text = DEFAULT_VALUE;
            currentValue = 0.0;
        }

        private void EraseLastDigit(object sender, EventArgs e)
        {
            if (displayArea.Text.Length <= 1)
            {
                displayArea.Text = DEFAULT_VALUE;
                return;
            }
            displayArea.Text = displayArea.Text[..^1];
        }

        private void ApplyOperation(Func<double, double, double>? operation, string symbol)
        {
            if (previousOperation == null)
            {
                previousValue = double.Parse(displayArea.Text);
            }
            else
            {
                currentValue = double.Parse(displayArea.Text);
                previousValue = previousOperation(previousValue, currentValue);
            }

            if (operation != null)
            {
                tempDisplayArea.Text = previousValue.ToString() + " " + symbol;
                displayArea.Text = DEFAULT_VALUE;
            }
            else if (previousOperation != null)
            {
                tempDisplayArea.Text += " " + currentValue.ToString() + " = ";
                displayArea.Text = previousValue.ToString();
            }

            previousOperation = operation;
            didDivide = false;
        }

        private void Add(object sender, EventArgs e)
        {
            ApplyOperation((double a, double b) => a + b, ((Button)sender).Text);
        }

        private void Subtract(object sender, EventArgs e)
        {
            ApplyOperation((double a, double b) => a - b, ((Button)sender).Text);
        }

        private void Multiply(object sender, EventArgs e)
        {
            ApplyOperation((double a, double b) => a * b, ((Button)sender).Text);
        }

        private void Divide(object sender, EventArgs e)
        {
            ApplyOperation((double a, double b) => a / b, ((Button)sender).Text);
            didDivide = true;
        }

        private void Result(object sender, EventArgs e)
        {
            if (didDivide && double.Parse(displayArea.Text) == 0.0)
            {
                ForbiddenOperation();
                return;
            }

            ApplyOperation(null, String.Empty);
            currentValue = previousValue;
            previousValue = 0;
        }

        private void ChangeSign(object sender, EventArgs e)
        {
            if (displayArea.Text == DEFAULT_VALUE)
            {
                return;
            }

            currentValue = double.Parse(displayArea.Text) * -1;
            displayArea.Text = currentValue.ToString();
        }

        private void ApplyUnaryOperation(Func<double, double> operation, string symbol)
        {
            currentValue = double.Parse(displayArea.Text);
            tempDisplayArea.Text += symbol + "(" + currentValue + ")";
            previousValue = currentValue = previousOperation != null ? previousOperation(previousValue, operation(currentValue)) : operation(currentValue);
            displayArea.Text = currentValue.ToString();
            previousOperation = null;
        }

        private void OneOver(object sender, EventArgs e)
        {
            if (double.Parse(displayArea.Text) == 0.0)
            {
                ForbiddenOperation();
                return;
            }

            ApplyUnaryOperation((double a) => 1.0 / a, "1/");
        }

        private void Square(object sender, EventArgs e)
        {
            ApplyUnaryOperation((double a) => a * a, "sqr");
        }

        private void SquareRoot(object sender, EventArgs e)
        {
            if (double.Parse(displayArea.Text) < 0.0)
            {
                ForbiddenOperation();
                return;
            }

            ApplyUnaryOperation(Math.Sqrt, "sqrt");
        }

        private void ForbiddenOperation()
        {
            displayArea.Text = FORBIDDEN_OPERATION_MSG;
            foreach ((Button btn, Color _) in BUTTONS_TO_DISABLE)
            {
                btn.BackColor = BTN_DISABLED;
                btn.Enabled = false;
            }
        }

        private void EnableBtns()
        {
            foreach ((Button btn, Color color) in BUTTONS_TO_DISABLE)
            {
                btn.Enabled = true;
                btn.BackColor = color;
            }
        }
    }
}

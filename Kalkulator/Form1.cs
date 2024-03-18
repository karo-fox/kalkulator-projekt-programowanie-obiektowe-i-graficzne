using System.Transactions;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        private readonly string DECIMAL_SEPARATOR = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private const int CHAR_LIMIT = 15;
        private const string DEFAULT_VALUE = "0";
        private const string DIVISION_BY_ZERO_MSG = "Nie mo¿na dzieliæ przez 0";

        private double currentValue = 0.0;
        private double previousValue = 0.0;
        private Func<double, double, double>? previousOperation = null;
        private bool didDivide = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void InsertDigit(object sender, EventArgs e)
        {
            if (displayArea.Text.Length >= CHAR_LIMIT && displayArea.Text != DIVISION_BY_ZERO_MSG)
            {
                return;
            }
            if (displayArea.Text == DEFAULT_VALUE || displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                displayArea.Text = string.Empty;
            }
            displayArea.Text += ((Button)sender).Text;
        }

        private void InsertSeparator(object sender, EventArgs e)
        {
            if (displayArea.Text.Contains(DECIMAL_SEPARATOR) || displayArea.Text == DIVISION_BY_ZERO_MSG)
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
            if (displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }
            if (displayArea.Text.Length <= 1)
            {
                displayArea.Text = DEFAULT_VALUE;
                return;
            }
            displayArea.Text = displayArea.Text[..^1];
        }

        private void ApplyOperation(Func<double, double, double>? operation, string symbol)
        {
            if (displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }

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
            if (displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }

            if (didDivide && double.Parse(displayArea.Text) == 0.0)
            {
                DivisionByZero();
                return;
            }

            ApplyOperation(null, String.Empty);
            currentValue = previousValue;
            previousValue = 0;
        }

        private void ChangeSign(object sender, EventArgs e)
        {
            if (displayArea.Text == DEFAULT_VALUE || displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }

            currentValue = double.Parse(displayArea.Text) * -1;
            displayArea.Text = currentValue.ToString();
        }

        private void ApplyUnaryOperation(Func<double, double> operation, string symbol)
        {
            if (displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }

            currentValue = double.Parse(displayArea.Text);
            tempDisplayArea.Text = symbol + "(" + currentValue + ")";
            currentValue = previousValue = operation(currentValue);
            displayArea.Text = currentValue.ToString();
        }

        private void OneOver(object sender, EventArgs e)
        {
            if (displayArea.Text == DIVISION_BY_ZERO_MSG)
            {
                return;
            }

            if (double.Parse(displayArea.Text) == 0.0)
            {
                DivisionByZero();
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
            ApplyUnaryOperation((double a) => Math.Sqrt(a), "sqrt");
        }

        private void DivisionByZero()
        {
            displayArea.Text = DIVISION_BY_ZERO_MSG;
        }
    }
}

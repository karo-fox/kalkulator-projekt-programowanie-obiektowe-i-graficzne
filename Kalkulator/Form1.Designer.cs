namespace Kalkulator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            separatorBtn = new Button();
            number0Btn = new Button();
            equalsBtn = new Button();
            addBtn = new Button();
            number3Btn = new Button();
            number2Btn = new Button();
            number1Btn = new Button();
            subtractBtn = new Button();
            number6Btn = new Button();
            number5Btn = new Button();
            number4Btn = new Button();
            multiplyBtn = new Button();
            number9Btn = new Button();
            number8Btn = new Button();
            number7Btn = new Button();
            divideBtn = new Button();
            eraseLastBtn = new Button();
            clearBtn = new Button();
            plusMinusBtn = new Button();
            displayArea = new TextBox();
            squareRootBtn = new Button();
            squareBtn = new Button();
            fractionBtn = new Button();
            clearEntryBtn = new Button();
            tempDisplayArea = new TextBox();
            SuspendLayout();
            // 
            // separatorBtn
            // 
            separatorBtn.BackColor = SystemColors.ControlDark;
            separatorBtn.Font = new Font("Segoe UI", 16F);
            separatorBtn.Location = new Point(11, 561);
            separatorBtn.Name = "separatorBtn";
            separatorBtn.Size = new Size(115, 77);
            separatorBtn.TabIndex = 1;
            separatorBtn.Text = ",";
            separatorBtn.UseVisualStyleBackColor = false;
            separatorBtn.Click += InsertSeparator;
            // 
            // number0Btn
            // 
            number0Btn.BackColor = SystemColors.ControlDark;
            number0Btn.Font = new Font("Segoe UI", 16F);
            number0Btn.Location = new Point(132, 561);
            number0Btn.Name = "number0Btn";
            number0Btn.Size = new Size(115, 77);
            number0Btn.TabIndex = 2;
            number0Btn.Text = "0";
            number0Btn.UseVisualStyleBackColor = false;
            number0Btn.Click += InsertDigit;
            // 
            // equalsBtn
            // 
            equalsBtn.BackColor = SystemColors.MenuHighlight;
            equalsBtn.Font = new Font("Segoe UI", 16F);
            equalsBtn.Location = new Point(253, 561);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(236, 77);
            equalsBtn.TabIndex = 4;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            equalsBtn.Click += Result;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ControlDarkDark;
            addBtn.Font = new Font("Segoe UI", 16F);
            addBtn.Location = new Point(374, 478);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 77);
            addBtn.TabIndex = 8;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += Add;
            // 
            // number3Btn
            // 
            number3Btn.BackColor = SystemColors.ControlDark;
            number3Btn.Font = new Font("Segoe UI", 16F);
            number3Btn.Location = new Point(253, 478);
            number3Btn.Name = "number3Btn";
            number3Btn.Size = new Size(115, 77);
            number3Btn.TabIndex = 7;
            number3Btn.Text = "3";
            number3Btn.UseVisualStyleBackColor = false;
            number3Btn.Click += InsertDigit;
            // 
            // number2Btn
            // 
            number2Btn.BackColor = SystemColors.ControlDark;
            number2Btn.Font = new Font("Segoe UI", 16F);
            number2Btn.Location = new Point(132, 478);
            number2Btn.Name = "number2Btn";
            number2Btn.Size = new Size(115, 77);
            number2Btn.TabIndex = 6;
            number2Btn.Text = "2";
            number2Btn.UseVisualStyleBackColor = false;
            number2Btn.Click += InsertDigit;
            // 
            // number1Btn
            // 
            number1Btn.BackColor = SystemColors.ControlDark;
            number1Btn.Font = new Font("Segoe UI", 16F);
            number1Btn.Location = new Point(11, 478);
            number1Btn.Name = "number1Btn";
            number1Btn.Size = new Size(115, 77);
            number1Btn.TabIndex = 5;
            number1Btn.Text = "1";
            number1Btn.UseVisualStyleBackColor = false;
            number1Btn.Click += InsertDigit;
            // 
            // subtractBtn
            // 
            subtractBtn.BackColor = SystemColors.ControlDarkDark;
            subtractBtn.Font = new Font("Segoe UI", 16F);
            subtractBtn.Location = new Point(374, 395);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(115, 77);
            subtractBtn.TabIndex = 12;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = false;
            subtractBtn.Click += Subtract;
            // 
            // number6Btn
            // 
            number6Btn.BackColor = SystemColors.ControlDark;
            number6Btn.Font = new Font("Segoe UI", 16F);
            number6Btn.Location = new Point(253, 395);
            number6Btn.Name = "number6Btn";
            number6Btn.Size = new Size(115, 77);
            number6Btn.TabIndex = 11;
            number6Btn.Text = "6";
            number6Btn.UseVisualStyleBackColor = false;
            number6Btn.Click += InsertDigit;
            // 
            // number5Btn
            // 
            number5Btn.BackColor = SystemColors.ControlDark;
            number5Btn.Font = new Font("Segoe UI", 16F);
            number5Btn.Location = new Point(132, 395);
            number5Btn.Name = "number5Btn";
            number5Btn.Size = new Size(115, 77);
            number5Btn.TabIndex = 10;
            number5Btn.Text = "5";
            number5Btn.UseVisualStyleBackColor = false;
            number5Btn.Click += InsertDigit;
            // 
            // number4Btn
            // 
            number4Btn.BackColor = SystemColors.ControlDark;
            number4Btn.Font = new Font("Segoe UI", 16F);
            number4Btn.Location = new Point(11, 395);
            number4Btn.Name = "number4Btn";
            number4Btn.Size = new Size(115, 77);
            number4Btn.TabIndex = 9;
            number4Btn.Text = "4";
            number4Btn.UseVisualStyleBackColor = false;
            number4Btn.Click += InsertDigit;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = SystemColors.ControlDarkDark;
            multiplyBtn.Font = new Font("Segoe UI", 16F);
            multiplyBtn.Location = new Point(374, 312);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(115, 77);
            multiplyBtn.TabIndex = 16;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += Multiply;
            // 
            // number9Btn
            // 
            number9Btn.BackColor = SystemColors.ControlDark;
            number9Btn.Font = new Font("Segoe UI", 16F);
            number9Btn.Location = new Point(253, 312);
            number9Btn.Name = "number9Btn";
            number9Btn.Size = new Size(115, 77);
            number9Btn.TabIndex = 15;
            number9Btn.Text = "9";
            number9Btn.UseVisualStyleBackColor = false;
            number9Btn.Click += InsertDigit;
            // 
            // number8Btn
            // 
            number8Btn.BackColor = SystemColors.ControlDark;
            number8Btn.Font = new Font("Segoe UI", 16F);
            number8Btn.Location = new Point(132, 312);
            number8Btn.Name = "number8Btn";
            number8Btn.Size = new Size(115, 77);
            number8Btn.TabIndex = 14;
            number8Btn.Text = "8";
            number8Btn.UseVisualStyleBackColor = false;
            number8Btn.Click += InsertDigit;
            // 
            // number7Btn
            // 
            number7Btn.BackColor = SystemColors.ControlDark;
            number7Btn.Font = new Font("Segoe UI", 16F);
            number7Btn.Location = new Point(11, 312);
            number7Btn.Name = "number7Btn";
            number7Btn.Size = new Size(115, 77);
            number7Btn.TabIndex = 13;
            number7Btn.Text = "7";
            number7Btn.UseVisualStyleBackColor = false;
            number7Btn.Click += InsertDigit;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = SystemColors.ControlDarkDark;
            divideBtn.Font = new Font("Segoe UI", 16F);
            divideBtn.Location = new Point(374, 229);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(115, 77);
            divideBtn.TabIndex = 20;
            divideBtn.Text = "÷";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += Divide;
            // 
            // eraseLastBtn
            // 
            eraseLastBtn.BackColor = SystemColors.ControlDarkDark;
            eraseLastBtn.Font = new Font("Segoe UI", 16F);
            eraseLastBtn.Location = new Point(374, 146);
            eraseLastBtn.Name = "eraseLastBtn";
            eraseLastBtn.Size = new Size(115, 77);
            eraseLastBtn.TabIndex = 19;
            eraseLastBtn.Text = "⌫";
            eraseLastBtn.UseVisualStyleBackColor = false;
            eraseLastBtn.Click += EraseLastDigit;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.ControlDarkDark;
            clearBtn.Font = new Font("Segoe UI", 16F);
            clearBtn.Location = new Point(253, 146);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(115, 77);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += Clear;
            // 
            // plusMinusBtn
            // 
            plusMinusBtn.BackColor = SystemColors.ControlDarkDark;
            plusMinusBtn.Font = new Font("Segoe UI", 16F);
            plusMinusBtn.Location = new Point(11, 146);
            plusMinusBtn.Name = "plusMinusBtn";
            plusMinusBtn.Size = new Size(115, 77);
            plusMinusBtn.TabIndex = 17;
            plusMinusBtn.Text = "+/-";
            plusMinusBtn.UseVisualStyleBackColor = false;
            plusMinusBtn.Click += ChangeSign;
            // 
            // displayArea
            // 
            displayArea.Font = new Font("Segoe UI", 36F);
            displayArea.Location = new Point(12, 69);
            displayArea.Name = "displayArea";
            displayArea.Size = new Size(476, 71);
            displayArea.TabIndex = 21;
            displayArea.Text = "0";
            displayArea.TextAlign = HorizontalAlignment.Right;
            // 
            // squareRootBtn
            // 
            squareRootBtn.BackColor = SystemColors.ControlDarkDark;
            squareRootBtn.Font = new Font("Segoe UI", 16F);
            squareRootBtn.Location = new Point(253, 229);
            squareRootBtn.Name = "squareRootBtn";
            squareRootBtn.Size = new Size(115, 77);
            squareRootBtn.TabIndex = 24;
            squareRootBtn.Text = "2√x";
            squareRootBtn.UseVisualStyleBackColor = false;
            squareRootBtn.Click += SquareRoot;
            // 
            // squareBtn
            // 
            squareBtn.BackColor = SystemColors.ControlDarkDark;
            squareBtn.Font = new Font("Segoe UI", 16F);
            squareBtn.Location = new Point(132, 229);
            squareBtn.Name = "squareBtn";
            squareBtn.Size = new Size(115, 77);
            squareBtn.TabIndex = 23;
            squareBtn.Text = "x²";
            squareBtn.UseVisualStyleBackColor = false;
            squareBtn.Click += Square;
            // 
            // fractionBtn
            // 
            fractionBtn.BackColor = SystemColors.ControlDarkDark;
            fractionBtn.Font = new Font("Segoe UI", 16F);
            fractionBtn.Location = new Point(11, 229);
            fractionBtn.Name = "fractionBtn";
            fractionBtn.Size = new Size(115, 77);
            fractionBtn.TabIndex = 22;
            fractionBtn.Text = "1/x";
            fractionBtn.UseVisualStyleBackColor = false;
            fractionBtn.Click += OneOver;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.BackColor = SystemColors.ControlDarkDark;
            clearEntryBtn.Font = new Font("Segoe UI", 16F);
            clearEntryBtn.Location = new Point(132, 146);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(115, 77);
            clearEntryBtn.TabIndex = 25;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = false;
            clearEntryBtn.Click += ClearEntry;
            // 
            // tempDisplayArea
            // 
            tempDisplayArea.Font = new Font("Segoe UI", 20F);
            tempDisplayArea.Location = new Point(12, 20);
            tempDisplayArea.Name = "tempDisplayArea";
            tempDisplayArea.Size = new Size(476, 43);
            tempDisplayArea.TabIndex = 26;
            tempDisplayArea.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 648);
            Controls.Add(tempDisplayArea);
            Controls.Add(clearEntryBtn);
            Controls.Add(squareRootBtn);
            Controls.Add(squareBtn);
            Controls.Add(fractionBtn);
            Controls.Add(displayArea);
            Controls.Add(divideBtn);
            Controls.Add(eraseLastBtn);
            Controls.Add(clearBtn);
            Controls.Add(plusMinusBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(number9Btn);
            Controls.Add(number8Btn);
            Controls.Add(number7Btn);
            Controls.Add(subtractBtn);
            Controls.Add(number6Btn);
            Controls.Add(number5Btn);
            Controls.Add(number4Btn);
            Controls.Add(addBtn);
            Controls.Add(number3Btn);
            Controls.Add(number2Btn);
            Controls.Add(number1Btn);
            Controls.Add(equalsBtn);
            Controls.Add(number0Btn);
            Controls.Add(separatorBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button separatorBtn;
        private Button number0Btn;
        private Button equalsBtn;
        private Button addBtn;
        private Button number3Btn;
        private Button number2Btn;
        private Button number1Btn;
        private Button subtractBtn;
        private Button number6Btn;
        private Button number5Btn;
        private Button number4Btn;
        private Button multiplyBtn;
        private Button number9Btn;
        private Button number8Btn;
        private Button number7Btn;
        private Button divideBtn;
        private Button eraseLastBtn;
        private Button clearBtn;
        private Button plusMinusBtn;
        private TextBox displayArea;
        private Button squareRootBtn;
        private Button squareBtn;
        private Button fractionBtn;
        private Button clearEntryBtn;
        private TextBox tempDisplayArea;
    }
}

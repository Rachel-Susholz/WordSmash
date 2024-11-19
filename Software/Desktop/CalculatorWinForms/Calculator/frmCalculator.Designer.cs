namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            btn8 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            tblClearButton = new TableLayoutPanel();
            btnClear = new Button();
            txtFactor1 = new TextBox();
            txtOperator = new TextBox();
            txtFactor2 = new TextBox();
            txtAnswer = new TextBox();
            tblMain.SuspendLayout();
            tblClearButton.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(btn8, 1, 2);
            tblMain.Controls.Add(btn7, 0, 2);
            tblMain.Controls.Add(btn9, 2, 2);
            tblMain.Controls.Add(btnMultiply, 3, 2);
            tblMain.Controls.Add(btnDivide, 3, 1);
            tblMain.Controls.Add(btn4, 0, 3);
            tblMain.Controls.Add(btn5, 1, 3);
            tblMain.Controls.Add(btn6, 2, 3);
            tblMain.Controls.Add(btnSubtract, 3, 3);
            tblMain.Controls.Add(btn1, 0, 4);
            tblMain.Controls.Add(btn2, 1, 4);
            tblMain.Controls.Add(btn3, 2, 4);
            tblMain.Controls.Add(btnAdd, 3, 4);
            tblMain.Controls.Add(btnSign, 0, 5);
            tblMain.Controls.Add(btn0, 1, 5);
            tblMain.Controls.Add(btnDecimal, 2, 5);
            tblMain.Controls.Add(btnEquals, 3, 5);
            tblMain.Controls.Add(tblClearButton, 0, 1);
            tblMain.Controls.Add(txtFactor1, 0, 0);
            tblMain.Controls.Add(txtOperator, 1, 0);
            tblMain.Controls.Add(txtFactor2, 2, 0);
            tblMain.Controls.Add(txtAnswer, 3, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(597, 575);
            tblMain.TabIndex = 0;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaption;
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(152, 193);
            btn8.Name = "btn8";
            btn8.Size = new Size(143, 89);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaption;
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 193);
            btn7.Name = "btn7";
            btn7.Size = new Size(143, 89);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaption;
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(301, 193);
            btn9.Name = "btn9";
            btn9.Size = new Size(143, 89);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 128);
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Location = new Point(450, 193);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(144, 89);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 128);
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Location = new Point(450, 98);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(144, 89);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaption;
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 288);
            btn4.Name = "btn4";
            btn4.Size = new Size(143, 89);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaption;
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(152, 288);
            btn5.Name = "btn5";
            btn5.Size = new Size(143, 89);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaption;
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(301, 288);
            btn6.Name = "btn6";
            btn6.Size = new Size(143, 89);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(255, 128, 128);
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Location = new Point(450, 288);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(144, 89);
            btnSubtract.TabIndex = 9;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 383);
            btn1.Name = "btn1";
            btn1.Size = new Size(143, 89);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(152, 383);
            btn2.Name = "btn2";
            btn2.Size = new Size(143, 89);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(301, 383);
            btn3.Name = "btn3";
            btn3.Size = new Size(143, 89);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 128);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(450, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 89);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSign
            // 
            btnSign.BackColor = SystemColors.ActiveCaption;
            btnSign.Dock = DockStyle.Fill;
            btnSign.Location = new Point(3, 478);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(143, 94);
            btnSign.TabIndex = 14;
            btnSign.Text = "-/+";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(152, 478);
            btn0.Name = "btn0";
            btn0.Size = new Size(143, 94);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ActiveCaption;
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Location = new Point(301, 478);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(143, 94);
            btnDecimal.TabIndex = 16;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(255, 128, 128);
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Location = new Point(450, 478);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(144, 94);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // tblClearButton
            // 
            tblClearButton.ColumnCount = 1;
            tblMain.SetColumnSpan(tblClearButton, 3);
            tblClearButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblClearButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblClearButton.Controls.Add(btnClear, 0, 0);
            tblClearButton.Dock = DockStyle.Fill;
            tblClearButton.Location = new Point(3, 98);
            tblClearButton.Name = "tblClearButton";
            tblClearButton.RowCount = 1;
            tblClearButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblClearButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblClearButton.Size = new Size(441, 89);
            tblClearButton.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(435, 83);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtFactor1
            // 
            txtFactor1.BackColor = SystemColors.ControlLight;
            txtFactor1.Dock = DockStyle.Fill;
            txtFactor1.Location = new Point(3, 3);
            txtFactor1.Multiline = true;
            txtFactor1.Name = "txtFactor1";
            txtFactor1.Size = new Size(143, 89);
            txtFactor1.TabIndex = 18;
            txtFactor1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOperator
            // 
            txtOperator.BackColor = SystemColors.ControlLight;
            txtOperator.Dock = DockStyle.Fill;
            txtOperator.Location = new Point(152, 3);
            txtOperator.Multiline = true;
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(143, 89);
            txtOperator.TabIndex = 19;
            txtOperator.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFactor2
            // 
            txtFactor2.BackColor = SystemColors.ControlLight;
            txtFactor2.Dock = DockStyle.Fill;
            txtFactor2.Location = new Point(301, 3);
            txtFactor2.Multiline = true;
            txtFactor2.Name = "txtFactor2";
            txtFactor2.Size = new Size(143, 89);
            txtFactor2.TabIndex = 20;
            txtFactor2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.ControlLight;
            txtAnswer.Dock = DockStyle.Fill;
            txtAnswer.Location = new Point(450, 3);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(144, 89);
            txtAnswer.TabIndex = 21;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 575);
            Controls.Add(tblMain);
            Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmCalculator";
            Text = "Calculator";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblClearButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btn8;
        private Button btn7;
        private Button btn9;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnSign;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
        private TableLayoutPanel tblClearButton;
        private Button btnClear;
        private TextBox txtFactor1;
        private TextBox txtOperator;
        private TextBox txtFactor2;
        private TextBox txtAnswer;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {

        public frmCalculator()
        {
            InitializeComponent();
            btn0.Click += Btn_Click;
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            btnAdd.Click += BtnAdd_Click;
            btnDivide.Click += BtnDivide_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnSubtract.Click += BtnSubtract_Click;
            btnClear.Click += BtnClear_Click;
            btnDecimal.Click += BtnDecimal_Click;
            btnSign.Click += BtnSign_Click;
            btnEquals.Click += BtnEquals_Click;
        }

        private int DetermineActiveBox()

        {
            int n = 0;
            // Return 1 if the first factor should be active
            if (txtFactor1.Text == "" || txtOperator.Text == "")
            {
                n = 1;
            }
            // Return 2 if the second factor should be active and the answer is empty
            else if (txtFactor1.Text != "" && txtOperator.Text != "" && txtAnswer.Text == "")
            {
                return 2;
            }
            // Return 0 if none are active (answer already filled)
            return n;
        }

        private string GetActiveBoxFactorValue()
        {
            int n = DetermineActiveBox();
            string s = "";

            if (n == 1)
            {
                s = txtFactor1.Text;
            }
            else if (n == 2)
            {
                s = txtFactor2.Text;
            }

            return s;
        }

        private void SetOperator(string value)
        {
            if (txtFactor1.Text != "")
            {
                txtOperator.Text = value;
            }
        }



        private void InputToActiveBox(string value)
        {
            int n = DetermineActiveBox();

            if (n == 1)
            {
                // Append value to txtFactor1 if it's active
                txtFactor1.Text += value;
            }
            else if (n == 2)
            {
                // Append value to txtFactor2 if it's active
                txtFactor2.Text += value;
            }
        }

        private void ClearInputs()
        {
            txtFactor1.Text = "";
            txtFactor2.Text = "";
            txtOperator.Text = "";
            txtAnswer.Text = "";
        }

        private void InputSign()
        {
            string s = "";
            if (GetActiveBoxFactorValue().StartsWith("-"))
            {
                s = GetActiveBoxFactorValue().Substring(1);
            }
            else if (GetActiveBoxFactorValue() == "")
            {
                s = "-";
            }
            else
            {
                s = ("-") + GetActiveBoxFactorValue();
            }
            int n = DetermineActiveBox();

            if (n == 1)
            {
                txtFactor1.Text = s;
            }
            else if (n == 2)
            {
                txtFactor2.Text = s;
            }
            

        }

        private void Calculate()
        {
            decimal factor1, factor2;

            if (txtFactor1.Text == "" || txtFactor2.Text == "" || txtOperator.Text == "")
            {
                return;
            }

            // Try parsing factor1 and factor2 as decimals
            if (!decimal.TryParse(txtFactor1.Text, out factor1) || !decimal.TryParse(txtFactor2.Text, out factor2))
            {
                // Clear invalid inputs if parsing fails
                ClearInputs();
                return;
            }


            if (txtOperator.Text == "+")
            {
                txtAnswer.Text = (factor1 + factor2).ToString();
            }
            else if (txtOperator.Text == "-")
            {
                txtAnswer.Text = (factor1 - factor2).ToString();
            }
            else if (txtOperator.Text == "x")
            {
                txtAnswer.Text = (factor1 * factor2).ToString();
            }
            else if (txtOperator.Text == "/")
            {
                if (factor2 == 0)
                {
                    ClearInputs();
                    return;
                }
                txtAnswer.Text = (factor1 / factor2).ToString();
            }
            else
            {
                ClearInputs();
            }
        }


        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnSubtract_Click(object? sender, EventArgs e)
        {
                SetOperator("-");
        }
        
        private void BtnMultiply_Click(object? sender, EventArgs e)
        {
                SetOperator("x");
        }
        private void BtnDivide_Click(object? sender, EventArgs e)
        {
                SetOperator("/");
        }
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
                SetOperator("+");
        }


        private void Btn_Click(object? sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string s = btn.Text;
            InputToActiveBox(s);
        }



        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            if (!GetActiveBoxFactorValue().Contains("."))
            {
                InputToActiveBox(".");
            }
        }

        private void BtnSign_Click(object? sender, EventArgs e)
        {

            InputSign();
        }

        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            Calculate();
        }


    }
}


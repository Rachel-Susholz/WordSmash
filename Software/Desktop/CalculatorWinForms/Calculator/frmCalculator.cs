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
            btn0.Click += Btn0_Click;
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;
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

        private void ClearInvalidInputs()
        {
            txtFactor1.Text = "";
            txtFactor2.Text = "";
            txtOperator.Text = "";
            txtAnswer.Text = "";
        }



        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtOperator.Text = "";
            txtFactor1.Text = "";
            txtFactor2.Text = "";
            txtAnswer.Text = "";

        }

        private void BtnSubtract_Click(object? sender, EventArgs e)
        { 
            if (txtFactor1.Text != "")
            {
                txtOperator.Text = "-";
            }
        }
        private void BtnMultiply_Click(object? sender, EventArgs e)
        {
            if (txtFactor1.Text != "")
            {
                txtOperator.Text = "x";
            }
        }

        private void BtnDivide_Click(object? sender, EventArgs e)
        {
            if (txtFactor1.Text != "")
            {
                txtOperator.Text = "/";
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (txtFactor1.Text != "")
            {
                txtOperator.Text = "+";
            }
        }

        private void Btn9_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("9");
        }

        private void Btn8_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("8");
        }

        private void Btn7_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("7");
        }

        private void Btn6_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("6");
        }

        private void Btn5_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("5");
        }

        private void Btn4_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("4");
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("3");
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("2");
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("1");
        }

        private void Btn0_Click(object? sender, EventArgs e)
        {
            InputToActiveBox("0");
        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }
        // This just popped up, not sure how to get rid of it withought going to the back file.
        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            if (!GetActiveBoxFactorValue().Contains("."))
            {
                InputToActiveBox(".");
            }
        }
        private void BtnSign_Click(object? sender, EventArgs e)
        {
            //
            if (GetActiveBoxFactorValue().StartsWith("-"))
            {
                int n = DetermineActiveBox();
                string s = GetActiveBoxFactorValue().Substring(1);
                if (n == 1)
                {
                    txtFactor1.Text = s;
                }
                else if (n == 2)
                {
                    txtFactor2.Text = s;
                }
            }
            else if (GetActiveBoxFactorValue() == "")
            {
                InputToActiveBox("-");
            }
            else
            {
                int n = DetermineActiveBox();
                string s = ("-") + GetActiveBoxFactorValue();
                if (n == 1)
                {
                    txtFactor1.Text = s;
                }
                else if (n == 2)
                {
                    txtFactor2.Text = s;
                }
            }
        }
        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            decimal factor1, factor2;
            string s = "";
            // Check for empty input fields
            if (txtFactor1.Text == s || txtFactor2.Text == s || txtOperator.Text == s)
            {
                return;
            }

            // Try parsing factor1 and factor2 as decimals
            if (!decimal.TryParse(txtFactor1.Text, out factor1) || !decimal.TryParse(txtFactor2.Text, out factor2))
            {
                // Clear invalid inputs if parsing fails
                ClearInvalidInputs();
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
                    ClearInvalidInputs();
                    return;
                }
                txtAnswer.Text = (factor1 / factor2).ToString();
            }
            else
            {
                ClearInvalidInputs();
            }
            txtAnswer.ReadOnly = true;
        }
    }
}


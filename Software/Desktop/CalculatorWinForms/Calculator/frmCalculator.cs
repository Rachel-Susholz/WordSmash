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
            n = (txtFactor1.Text == "" || txtOperator.Text == "") ? 1 :
            n = (txtFactor1.Text != "" && txtOperator.Text != "" && txtAnswer.Text == "") ? 2 : 0;
            return n;
        }

        private string GetActiveBoxFactorValue()
        {
            string s = "";

            switch (DetermineActiveBox())
            {
                case 1:
                s = txtFactor1.Text;
                    break;
                case 2:
                    s = txtFactor2.Text;
                    break;
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
            switch (DetermineActiveBox())
            {
                case 1:
                    txtFactor1.Text += value;
                    break;
                case 2:
                    txtFactor2.Text += value;
                    break;
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

            string newValue = GetActiveBoxFactorValue().StartsWith("-") ? GetActiveBoxFactorValue().Substring(1) : "-" + GetActiveBoxFactorValue();
            switch (DetermineActiveBox())
            {
                case 1:
                    txtFactor1.Text = newValue;
                    break;
                case 2:
                    txtFactor2.Text = newValue;
                    break;
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

          
            switch (txtOperator.Text.ToString())
            {
                case "+":
                    txtAnswer.Text = (factor1 + factor2).ToString();
                    break;
                case "-":
                    txtAnswer.Text = (factor1 - factor2).ToString();
                    break;
                case "x":
                    txtAnswer.Text = (factor1 * factor2).ToString();
                    break;
                case "/":
                    if (factor2 == 0)
                    {
                        ClearInputs();
                        return;
                    }
                    txtAnswer.Text = (factor1 / factor2).ToString();
                    break;
                default:
                    ClearInputs();
                    break;
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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPRG
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtBoxResult.Text == "0") || (isOperationPerformed))
                txtBoxResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtBoxResult.Text.Contains("."))
                    txtBoxResult.Text = txtBoxResult.Text + button.Text;
            }
            else
            {
                txtBoxResult.Text = txtBoxResult.Text + button.Text;
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double entry;

            if (!Double.TryParse(txtBoxResult.Text, out entry))
            {
                txtBoxResult.Text = "Error";
                return; 
            }

            bool calculationError = false;

            switch (operationPerformed)
            {
                case "+":
                    txtBoxResult.Text = (resultValue + entry).ToString();
                    break;
                case "-":
                    txtBoxResult.Text = (resultValue - entry).ToString();
                    break;
                case "x":
                    txtBoxResult.Text = (resultValue * entry).ToString();
                    break;
                case "/":
                    if (entry == 0)
                    {
                        txtBoxResult.Text = "Error: Division by zero";
                        calculationError = true;
                    }
                    else
                    {
                        txtBoxResult.Text = (resultValue / entry).ToString();
                    }
                    break;
                case "√":
                    if (resultValue < 0)
                    {
                        txtBoxResult.Text = "Error: Square root of a negative number";
                        calculationError = true;
                    }
                    else
                    {
                        txtBoxResult.Text = Math.Sqrt(resultValue).ToString();
                    }
                    break;
                case "x²":
                    txtBoxResult.Text = Math.Pow(resultValue, 2).ToString();
                    break;
                case "<=":
                    txtBoxResult.Text = (resultValue <= entry).ToString();
                    break;
                default:
                    break;
            }

            if (!calculationError)
            {
                if (Double.TryParse(txtBoxResult.Text, out resultValue))
                {
                    lblResult.Text = ""; 
                }
            }

            isOperationPerformed = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEquals.PerformClick();
                operationPerformed = button.Text;
                lblResult.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(txtBoxResult.Text);
                lblResult.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnsquare_Click_1(object sender, EventArgs e)
        {
            operationPerformed = "x²";
            resultValue = Double.Parse(txtBoxResult.Text);
            lblResult.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            operationPerformed = "√";
            resultValue = Double.Parse(txtBoxResult.Text);
            lblResult.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
            lblResult.Text = "";
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            double entry = Double.Parse(txtBoxResult.Text);
            entry = -entry;
            txtBoxResult.Text = entry.ToString();
        }
        
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
        }

        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            resultValue = Double.Parse(txtBoxResult.Text);
            operationPerformed = "<=";
            lblResult.Text = resultValue + " " + operationPerformed;
            txtBoxResult.Text = "0";
            isOperationPerformed = true;
        }
        private void validateNumber(string input)
        {
            double number;
            if (!Double.TryParse(input, out number))
            {
                txtBoxResult.Text = "Error";
            }
        }

        private void menuStripCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxResult.Text))
            {
                Clipboard.SetText(txtBoxResult.Text);
            }
            else
            {
                MessageBox.Show("There is no text to copy.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void menuStripPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtBoxResult.Text = Clipboard.GetText();
            }
        }

        private void menuStripAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "Error";
            }
            else
            {
                double value = Double.Parse(txtBoxResult.Text);
                double reciprocal = 1 / value;

                if (reciprocal % 1 == 0) 
                {
                    txtBoxResult.Text = "1/" + reciprocal.ToString();
                }
                else
                {
                    txtBoxResult.Text = (1 / value).ToString();
                }
            }

            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }
    }
}

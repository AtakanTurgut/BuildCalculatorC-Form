using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtResultScreen.TextLength <= 6)
            {
                txtResultScreen.Font = new Font("Microsoft Sans Serif", 37);
            }
            else if (txtResultScreen.Text.Length > 6 && txtResultScreen.Text.Length <= 9)
            {
                txtResultScreen.Font = new Font("Microsoft Sans Serif", 24);
            }
            else if (txtResultScreen.Text.Length > 9)
            {
                txtResultScreen.Font = new Font("Microsoft Sans Serif", 10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == null)
            {
                txtResultScreen.Text = "0";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + ",";
            }
        }

        double firstNumber;
        string operation;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "0";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "1";
            } 
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "2";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "3";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "4";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "5";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "6";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "7";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "8";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text == "0" && txtResultScreen.Text != null)
            {
                txtResultScreen.Text = "9";
            }
            else
            {
                txtResultScreen.Text = txtResultScreen.Text + "9";
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResultScreen.Text);
            txtResultScreen.Text = "0";
            operation = "÷";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResultScreen.Text);
            txtResultScreen.Text = "0";
            operation = "x";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber =Convert.ToDouble(txtResultScreen.Text);
            txtResultScreen.Text = "0";
            operation = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResultScreen.Text);
            txtResultScreen.Text = "0";
            operation = "-";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(txtResultScreen.Text);

            if (operation == "÷")
            {
                if (secondNumber == 0)
                {
                    txtResultScreen.Text = "zero division error";
                } 
                else
                {
                    result = firstNumber / secondNumber;
                    txtResultScreen.Text = Convert.ToString(result);

                    firstNumber = result;
                }
            }
            else if (operation == "x")
            {
                result = firstNumber * secondNumber;
                txtResultScreen.Text = Convert.ToString(result);

                firstNumber = result;
            }
            else if (operation == "+")
            {
                result = firstNumber + secondNumber;
                txtResultScreen.Text = Convert.ToString(result);

                firstNumber = result;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
                txtResultScreen.Text = Convert.ToString(result);

                firstNumber = result;
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtResultScreen.Text != "0")
            {
                txtResultScreen.Text = txtResultScreen.Text.Remove(txtResultScreen.TextLength - 1);
            }
            else
            {
                txtResultScreen.Text = "0";
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtResultScreen.Text = "0";
        }
    }
}

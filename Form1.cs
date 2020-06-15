using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAnswer.Text =  calculateAnswer("Add");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Modulus");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Subtract");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Divide");
        }

        public string calculateAnswer(string operation)
        {
            double number1 = double.Parse(txtNumber1.Text);
            double number2 = double.Parse(txtNumber2.Text);
            double result = 0;

            switch (operation)
            {
                case "Add":
                    {
                        result = number1 + number2;
                        break;
                    }
                case "Subtract":
                    {
                        result = number1 - number2;
                        break;
                    }
                case "Multiply":
                    {
                        result = number1 * number2;
                        break;
                    }
                case "Divide":
                    {
                        if(number2 == 0)
                        {
                            return "Unable to divide by zero.";
                        }
                        else
                        {
                            result = number1 / number2;
                        }
                        break;
                    }
                case "Modulus":
                    {
                        result = number1 % number2;
                        break;
                    }
            }

            return result.ToString();
        }
    }
}

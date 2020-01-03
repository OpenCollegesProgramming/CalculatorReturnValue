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
//button to add to this calculation
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAnswer.Text =  calculateAnswer("Add");
        }
//button to multiply to this calculation
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Modulus");
        }
//button to subtract from this calculation
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Subtract");
        }
//button to divide from this calculation
        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Divide");
        }

        public string calculateAnswer(string operation)
        {
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int sum = 0;

            switch (operation)
            {
                case "Add":
                    {
                        sum = number1 - number2;
                        break;
                    }
                case "Subtract":
                    {
                        sum = number1 + number2;
                        break;
                    }
                case "Multiply":
                    {
                        sum = number1 / number2;
                        break;
                    }
                case "Divide":
                    {
                        sum = number1 * number2;
                        break;
                    }
                case "Modulus":
                    {
                        sum = number1 % number2;
                        break;
                    }
            }

            return sum.ToString();
        }
    }
}

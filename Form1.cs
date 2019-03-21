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
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("You need to enter a value in both number boxes for this to work");
                return;
            }
            int parsedValue1;
            int parsedValue2;

            if (!int.TryParse(txtNumber1.Text, out parsedValue1) || !int.TryParse(txtNumber2.Text, out parsedValue2))
            {
                MessageBox.Show("Both numbers must be integers ");
                return;
            }
            txtAnswer.Text =  calculateAnswer("Add");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("You need to enter a value in both number boxes for this to work");
                return;
            }
            int parsedValue1;
            int parsedValue2;

            if (!int.TryParse(txtNumber1.Text, out parsedValue1) || !int.TryParse(txtNumber2.Text, out parsedValue2))
            {
                MessageBox.Show("Both numbers must be integers ");
                return;
            }
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("You need to enter a value in both number boxes for this to work");
                return;
            }
            int parsedValue1;
            int parsedValue2;

            if (!int.TryParse(txtNumber1.Text, out parsedValue1) || !int.TryParse(txtNumber2.Text, out parsedValue2))
            {
                MessageBox.Show("Both numbers must be integers ");
                return;
            }
            txtAnswer.Text = calculateAnswer("Modulus");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("You need to enter a value in both number boxes for this to work");
                return;
            }
            int parsedValue1;
            int parsedValue2;

            if (!int.TryParse(txtNumber1.Text, out parsedValue1) || !int.TryParse(txtNumber2.Text, out parsedValue2))
            {
                MessageBox.Show("Both numbers must be integers ");
                return;
            }
            txtAnswer.Text = calculateAnswer("Subtract");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("You need to enter a value in both number boxes for this to work");
                return;
            }
            int parsedValue1;
            int parsedValue2;

            if (!int.TryParse(txtNumber1.Text, out parsedValue1) || !int.TryParse(txtNumber2.Text, out parsedValue2))
            {
                MessageBox.Show("Both numbers must be integers ");
                return;
            }
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
                        sum = number1 + number2;
                        break;
                    }
                case "Subtract":
                    {
                        sum = number1 - number2;
                        break;
                    }
                case "Multiply":
                    {
                        sum = number1 * number2;
                        break;
                    }
                case "Divide":
                    {
                        sum = number1 / number2;
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

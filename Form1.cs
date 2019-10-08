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

            Number nums = new Number(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
            int sum = nums.CalculateValue(operation, nums.Num1, nums.Num2);
            return sum.ToString();


        }
    }
}

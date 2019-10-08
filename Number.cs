using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    class Number
    {
        int num1, num2;

        public Number()
        {

        }
        public Number(int one, int two)
        {
            this.num1 = one;
            this.num2 = two;
        }

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int CalculateValue(string act, int number1, int number2)
        {
            int sum = 0;

            switch (act)
            {
                case "Add":
                    {
                        //Calcualtion corrected
                        sum = number1 + number2;
                        break;
                    }
                case "Subtract":
                    {
                        //Calcualtion corrected
                        sum = number1 - number2;
                        break;
                    }
                case "Multiply":
                    {
                        //Calcualtion corrected
                        sum = number1 * number2;
                        break;
                    }
                case "Divide":
                    {
                        //Calcualtion corrected
                        sum = number1 / number2;
                        break;
                    }
                case "Modulus":
                    {
                        sum = number1 % number2;
                        break;
                    }
            }
            return sum;
        }
    }
}

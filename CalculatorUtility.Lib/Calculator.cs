using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUtility.Lib
{
    public class Calculator
    {
        public string calculateAnswer(string x, string y, string operation)
        {
            int number1 = int.Parse(x);
            int number2 = int.Parse(y);
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

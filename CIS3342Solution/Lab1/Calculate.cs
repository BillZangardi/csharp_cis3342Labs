using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1
{
    public class Calculate
    {
        public static string calculateNums(string num1, string num2, string oper)
        {
            string result = "0";
            double double1, double2;
            bool isDouble = double.TryParse(num1, out double1);
            isDouble = double.TryParse(num2, out double2);
            if (isDouble)
            {
                if (oper == "+")
                {
                    result = (double1 + double2).ToString();
                }
                else if (oper == "-")
                {
                    result = (double1 - double2).ToString();
                }
                else if (oper == "/")
                {
                    result = (double1 / double2).ToString();
                }
                else if (oper == "*")
                {
                    result = (double1 * double2).ToString();
                }
            }
            else
            {
                result = "Please enter valid input";
            }

            return result;
        }
    }
}
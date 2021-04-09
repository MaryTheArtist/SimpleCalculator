using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Controllers
{
    public class Calculations
    {
        public double Calculate(double num1, double num2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "Add": result = num1 + num2;
                    break;
                case "Substract": result = num1 - num2;
                    break;
                case "Multiplication": result = num1 * num2;
                    break;
                case "Division": result = num1 / num2;
                    break;

            }  
            return result;
        }
    }
}

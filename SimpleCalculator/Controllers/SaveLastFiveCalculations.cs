using SimpleCalculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Controllers
{
    public class SaveLastFiveCalculations
    {
        public string[] SaveCalculations(string[] lastCalculations, string firstNum, string secondNum, string operationType, string result)
        {           
            string calculation = CreateLastCalculationString(firstNum, secondNum, operationType, result);

            bool isWritten = false;

            for (int i = 0; i < lastCalculations.Length; i++)
            {
                if(lastCalculations[i] == null)
                {
                    lastCalculations[i] = calculation;
                    isWritten = true;
                    break;
                }               
            }
            if (isWritten == false)
            {
                // DeleteOldestCalculation
                lastCalculations[0] = null;
                lastCalculations = MoveCalculationsForward(lastCalculations);
                // SaveLastCalculation;
                lastCalculations[lastCalculations.Length - 1] = calculation;
            }
            return lastCalculations;
        }

        private string[] MoveCalculationsForward(string[] lcllastCalculations)
        {
            for (int i = 0; i < lcllastCalculations.Length - 1; i++)
            {
                lcllastCalculations[i] = lcllastCalculations[i + 1];
            }
            return lcllastCalculations;
        }

        private static string DisplayOperationSign(string operationType)
        {
            string operationT = "";
            switch (operationType)
            {
                 case "Add":
                     operationT = "+";
                    break;
                case "Substract":
                    operationT = "-";
                    break;
                case "Multiplication":
                    operationT = "*";
                    break;
                case "Division":
                    operationT = "/";
                    break;

            }
            return operationT;
        }

        // Create string with last calculation info.
        private static string CreateLastCalculationString(string firstNum, string secondNum, string operationType, string result)
        {
            string operation = DisplayOperationSign(operationType);
            string lastCalculationString = firstNum + " " + operation + " "+ secondNum + " = "+ result;
            return lastCalculationString;
        }
    }
}

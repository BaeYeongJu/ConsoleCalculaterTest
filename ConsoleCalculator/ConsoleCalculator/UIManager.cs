using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class UIManager
    {
        private void ShowMessage(string firstStringNumber, double result)
        {
            Console.WriteLine($"결과: 1/({double.Parse(firstStringNumber)}) = {result} ");
        }

        private void ShowMessage(string firstStringNumber, string operatorSymbol, string secondStringNumber, double result)
        {
            if (operatorSymbol == "." || operatorSymbol == "n")
                Console.WriteLine($"결과: {result} ");
            else
                Console.WriteLine($"결과: {double.Parse(firstStringNumber) + operatorSymbol + double.Parse(secondStringNumber)} = {result} ");
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), operatorSymbol);
            ShowMessage(firstStringNumber, result);
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, string secondStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), double.Parse(secondStringNumber), operatorSymbol);
            ShowMessage(firstStringNumber, operatorSymbol, secondStringNumber, result);
        }
    }
}

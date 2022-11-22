using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class UIManager
    {

        private void ShowMessage(string firstStringNumber, string operatorSymbol, double result)
        {
            Console.WriteLine($"결과: {double.Parse(firstStringNumber) + operatorSymbol} = {result} ");
        }

        private void ShowMessage(string firstStringNumber, string operatorSymbol, string secondStringNumber, double result)
        {
            Console.WriteLine($"결과: {double.Parse(firstStringNumber) + operatorSymbol + double.Parse(secondStringNumber)} = {result} ");
        }

        public void ShowResult(UIManager uimanager, CalculateManager calculateManager, string firstStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), operatorSymbol);
            uimanager.ShowMessage(firstStringNumber, operatorSymbol, result);
        }

        public void ShowResult(UIManager uimanager, CalculateManager calculateManager, string firstStringNumber, string secondStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), double.Parse(secondStringNumber), operatorSymbol);
            uimanager.ShowMessage(firstStringNumber, operatorSymbol, secondStringNumber, result);
        }
    }
}

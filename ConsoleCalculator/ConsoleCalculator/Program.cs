using System;
using System.Diagnostics;
using ConsoleCalculator;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstStringNumber = string.Empty;
            string secondStringNumber = string.Empty;
            string operatorSymbol = string.Empty;
            double result = 0;

            CalculateManager calculateManager = new CalculateManager();
            UIManager uiManager = new UIManager();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 :");            

            firstStringNumber = Console.ReadLine();
            if (!CalculateManager.IsNumberDoubleType(firstStringNumber))
                uiManager.ShowErrorMessage();

            Console.Write("연산자 입력 (+,-,*,/,%,n,.,r,s,p):");
            operatorSymbol = Console.ReadLine();

            if (!calculateManager.IsInputOperatorCorrect(operatorSymbol))
                uiManager.ShowErrorMessage();

            if (calculateManager.IsOperatorNotNeedSceondNumber(operatorSymbol))
            {
                uiManager.ShowResult(calculateManager, firstStringNumber, operatorSymbol, result);
            }
            else
            {
                Console.Write("두번째 숫자 입력 :");
                secondStringNumber = Console.ReadLine();

                if (!CalculateManager.IsNumberDoubleType(secondStringNumber))
                    uiManager.ShowErrorMessage();

                uiManager.ShowResult(calculateManager, firstStringNumber, secondStringNumber, operatorSymbol, result);
            }
        }
    }
}

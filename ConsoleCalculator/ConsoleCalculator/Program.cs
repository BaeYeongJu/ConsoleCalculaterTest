using System;
using ConsoleCalculator;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateManager calculateManager = new CalculateManager();
            UIManager uiManager = new UIManager();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 :");

            string firstStringNumber = string.Empty;
            string secondStringNumber = string.Empty;
            string operatorSymbol = string.Empty;

            double firstNumber = 0f;
            double secondNumber = 0f;

            firstStringNumber = Console.ReadLine();
            calculateManager.ShowErrorMessage(firstStringNumber);

            Console.Write("연산자 입력 (+,-,*,/,%,n,.,r):");
            operatorSymbol = Console.ReadLine();
            double result = 0;

            if (calculateManager.IsReciprocalOperator(operatorSymbol))
            {
                uiManager.ShowResult(calculateManager, firstStringNumber, operatorSymbol, result);
            }
            else
            {
                Console.Write("두번째 숫자 입력 :");
                secondStringNumber = Console.ReadLine();

                calculateManager.ShowErrorMessage(secondStringNumber);

                uiManager.ShowResult(calculateManager, firstStringNumber, secondStringNumber, operatorSymbol, result);
            }
        }


    }
}

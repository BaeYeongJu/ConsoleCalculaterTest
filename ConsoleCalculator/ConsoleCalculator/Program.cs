using System;
using ConsoleCalculator;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateManager calculateManager = new CalculateManager();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 :");

            string firstStringNumber = string.Empty;
            string secondStringNumber = string.Empty;
            string operatorSymbol = string.Empty;

            double firstNumber = 0f;
            double secondNumber = 0f;

            firstStringNumber = Console.ReadLine();
            calculateManager.ShowErrorMessage(firstStringNumber);

            Console.Write("연산자 입력 (+,-,*,/,%,n,.):");
            operatorSymbol = Console.ReadLine();

            Console.Write("두번째 숫자 입력 :");
            secondStringNumber = Console.ReadLine();

            calculateManager.ShowErrorMessage(secondStringNumber);

            var result = calculateManager.Calculate(double.Parse(firstStringNumber), double.Parse(secondStringNumber), operatorSymbol);
            Console.WriteLine($"결과: {double.Parse(firstStringNumber) + operatorSymbol + double.Parse(secondStringNumber)} = {result} ");
        }
    }
}

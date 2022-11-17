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
            Console.Write("첫번째 숫자 입력 (정수):");

            string firstStringNumber = string.Empty;
            string secondStringNumber = string.Empty;
            string operatorSymbol = string.Empty;

            int firstNumber = 0;
            int secondNumber = 0;

            firstStringNumber = Console.ReadLine();
            calculateManager.ShowErrorMessage(firstStringNumber);

            Console.Write("연산자 입력 (+,-,*,/,%):");
            operatorSymbol = Console.ReadLine();

            Console.Write("두번째 숫자 입력 (정수):");
            secondStringNumber = Console.ReadLine();

            calculateManager.ShowErrorMessage(secondStringNumber);

            var result = calculateManager.Calculate(int.Parse(firstStringNumber), int.Parse(secondStringNumber), operatorSymbol);
            Console.WriteLine($"결과: {int.Parse(firstStringNumber) + operatorSymbol + int.Parse(secondStringNumber)} = {result} ");
        }
    }
}

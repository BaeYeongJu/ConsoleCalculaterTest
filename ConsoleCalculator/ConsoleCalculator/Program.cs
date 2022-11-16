using System;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 (정수):");

            string firstStringNumber = string.Empty;
            string secondStringNumber = string.Empty;
            string operatorSymbol = string.Empty;

            int firstNumber = 0;
            int secondNumber = 0;

            firstStringNumber = Console.ReadLine();
            main.ShowErrorMessage(firstStringNumber);

            Console.Write("연산자 입력 (+,-,*,/,%):");
            operatorSymbol = Console.ReadLine();

            Console.Write("두번째 숫자 입력 (정수):");
            secondStringNumber = Console.ReadLine();

            main.ShowErrorMessage(secondStringNumber);

            var result = main.Calculate(int.Parse(firstStringNumber), int.Parse(secondStringNumber), operatorSymbol);
            Console.WriteLine($"결과: {int.Parse(firstStringNumber) + operatorSymbol + int.Parse(secondStringNumber)} = {result} ");
        }

        private bool IsNumberIntType(string stringNumber)
        {
            bool result = int.TryParse(stringNumber, out _);
            return result;
        }

        private void ShowErrorMessage(string stringNumber)
        {
            if(!IsNumberIntType(stringNumber))
                Console.WriteLine("결과: 숫자 잘못 입력됨");
        }

        public int Calculate(int firstNumber, int secondNumber , string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "+":
                    return Add(firstNumber, secondNumber);
                case "-":
                    return Sub(firstNumber, secondNumber);
                case "*":
                    return Multiplication(firstNumber, secondNumber);
                case "/":
                    return Division(firstNumber, secondNumber);
                case "%":
                    return Remainder(firstNumber, secondNumber);
            }
            return 0;
        }

        public int Add(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public int Remainder(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}

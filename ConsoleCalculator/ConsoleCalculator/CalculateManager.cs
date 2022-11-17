using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculateManager
    {
        private bool IsNumberIntType(string stringNumber)
        {
            bool result = int.TryParse(stringNumber, out _);
            return result;
        }

        public void ShowErrorMessage(string stringNumber)
        {
            if (!IsNumberIntType(stringNumber))
                Console.WriteLine("결과: 숫자 잘못 입력됨");
        }

        public int Calculate(int firstNumber, int secondNumber, string operatorSymbol)
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

        public int Add(int firstNumber, int secondNumber)
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

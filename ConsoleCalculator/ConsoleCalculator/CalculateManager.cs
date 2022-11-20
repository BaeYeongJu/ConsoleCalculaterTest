using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculateManager
    {
        private bool IsNumberDoubleType(string stringNumber)
        {
            bool result = double.TryParse(stringNumber, out _);
            return result;
        }

        public void ShowErrorMessage(string stringNumber)
        {
            if (!IsNumberDoubleType(stringNumber))
                Console.WriteLine("결과: 숫자 잘못 입력됨");
        }

        public double Calculate(double firstNumber, double secondNumber, string operatorSymbol)
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
                case "n":
                    return Negative(firstNumber, secondNumber);
                case ".":
                    return ShowDot(firstNumber, secondNumber);
            }
            return 0;
        }

        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public double Remainder(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public double Negative(double firstNumber, double secondNumber)
        {
            string result = (-firstNumber).ToString() + secondNumber.ToString();
            return double.Parse(result);
        }

        public double ShowDot(double firstNumber, double secondNumber)
        {
            string operatorSymbol = ".";
            string result = (firstNumber).ToString() + operatorSymbol+ secondNumber.ToString();
            return double.Parse(result);
        }
    }
}

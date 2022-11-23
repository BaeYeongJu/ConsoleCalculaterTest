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

        public double Calculate(double firstNumber, string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "r":
                    return Reciprocal(firstNumber);
                case "s":
                    return Sqrt(firstNumber);
                case "p":
                    return Pow(firstNumber);
            }
            return 0;
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
                    return DecimalPoint(firstNumber, secondNumber);
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
            return double.Parse($"{-firstNumber}{secondNumber}");
        }

        public double DecimalPoint(double firstNumber, double secondNumber)
        {
            return double.Parse($"{firstNumber}.{secondNumber}");
        }

        public double Reciprocal(double firstNumber)
        {
            double result = 1 / (firstNumber);
            return result;
        }

        public double Sqrt(double firstNumber)
        {
            double result = Math.Sqrt(firstNumber);
            return result;
        }

        public double Pow(double firstNumber)
        {
            double result = Math.Pow(firstNumber, 2);
            return result;
        }

        public bool IsOperatorNotNeedSceondNumber(string operatorSymbol)
        {
            return operatorSymbol == "s" || operatorSymbol == "r" || operatorSymbol == "p";
        }
    }
}

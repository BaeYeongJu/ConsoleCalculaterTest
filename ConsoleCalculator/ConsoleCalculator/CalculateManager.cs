using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculateManager
    {
        public static bool IsNumberDoubleType(string stringNumber)
        {
            bool result = double.TryParse(stringNumber, out _);
            return result;
        }

        public bool IsInputKeyOperatorCorrect(ConsoleKey consoleKey)
        {
            ConsoleKey[] operatorKeyArray = new ConsoleKey[] { ConsoleKey.D5, ConsoleKey.D8, ConsoleKey.OemPlus, ConsoleKey.OemMinus, ConsoleKey.OemPeriod, ConsoleKey.Oem2, ConsoleKey.N, ConsoleKey.R, ConsoleKey.S, ConsoleKey.P, ConsoleKey.C };
            
            foreach (var operatorKey in operatorKeyArray)
            {
                if (operatorKey == consoleKey)
                    return true;
            }
            return false;
        }

        public double Calculate(double firstNumber, ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.R:
                    return Reciprocal(firstNumber);
                case ConsoleKey.S:
                    return Sqrt(firstNumber);
                case ConsoleKey.P:
                    return SquareRoot2(firstNumber);
                case ConsoleKey.C:
                    return DeleteFirstNumber();
            }
            return 0;
        }

        public double Calculate(double firstNumber, double secondNumber, ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.OemPlus:
                    return Add(firstNumber, secondNumber);
                case ConsoleKey.OemMinus:
                    return Sub(firstNumber, secondNumber);
                case ConsoleKey.D8:
                    return Multiplication(firstNumber, secondNumber);
                case ConsoleKey.Oem2:
                    return Division(firstNumber, secondNumber);
                case ConsoleKey.D5:
                    return Remainder(firstNumber, secondNumber);
                case ConsoleKey.N:
                    return Negative(firstNumber, secondNumber);
                case ConsoleKey.OemPeriod:
                    return DecimalPoint(firstNumber, secondNumber);
            }
            return double.NaN;
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

        public double SquareRoot2(double firstNumber) 
        {
            double result = Math.Pow(firstNumber, 2);
            return result;
        }

        public double DeleteFirstNumber() => 0;

        public bool IsInputKeyNotNeedSceondNumber(ConsoleKey consoleKey)
        {
            return consoleKey == ConsoleKey.S || consoleKey == ConsoleKey.R || consoleKey == ConsoleKey.P || consoleKey == ConsoleKey.C;
        }

        public ConsoleKey InputKey()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey consoleKey = keyInfo.Key;

                return consoleKey;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    //메세지, UI 버튼 관련
    public class UIManager
    {
        private void ShowMessage(string firstStringNumber, ConsoleKey consoleKey, double result)
        {
            switch (consoleKey)
            {
                case ConsoleKey.R:
                    Console.WriteLine($"결과: 1/({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine($"결과: √({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case ConsoleKey.P:
                    Console.WriteLine($"결과: sqr({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine($"결과: {result} ");
                    break;
            }
        }

        //. , n
        private void ShowMessage(string firstStringNumber, ConsoleKey consoleKey, string secondStringNumber, double result)
        {
            if (consoleKey == ConsoleKey.OemPeriod || consoleKey == ConsoleKey.N)
                Console.WriteLine($"결과: {result} ");
            else
                Console.WriteLine($"결과: {double.Parse(firstStringNumber) + GetConsoleKeyToString(consoleKey) + double.Parse(secondStringNumber)} = {result} ");
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, ConsoleKey consoleKey, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), consoleKey);
            ShowMessage(firstStringNumber, consoleKey, result);
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, string secondStringNumber, ConsoleKey consoleKey, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), double.Parse(secondStringNumber), consoleKey);
            ShowMessage(firstStringNumber, consoleKey, secondStringNumber, result);
        }

        public void ShowErrorMessage()
        {
            Console.WriteLine("잘못 입력되었습니다.");
            Environment.Exit(0);
        }

        private string GetConsoleKeyToString(ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.D5:
                    return "%";
                case ConsoleKey.D8:
                    return "*";
                case ConsoleKey.OemPlus:
                    return "+";
                case ConsoleKey.OemMinus:
                    return "-";
                case ConsoleKey.OemPeriod:
                    return ".";
                case ConsoleKey.Oem2:
                    return "/";
                case ConsoleKey.N:
                    return "n";
                case ConsoleKey.R:
                    return "r";
                case ConsoleKey.S:
                    return "s";
                case ConsoleKey.P:
                    return "p";
                case ConsoleKey.C:
                    return "c";
            }

            return "null";
        }

        public bool IsInputKeyNotNeedSceondNumber(ConsoleKey consoleKey)
        {
            return consoleKey == ConsoleKey.S || consoleKey == ConsoleKey.R || consoleKey == ConsoleKey.P || consoleKey == ConsoleKey.C;
        }

        public ConsoleKey InputKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey consoleKey = keyInfo.Key;

            return consoleKey;
        }
    }
}

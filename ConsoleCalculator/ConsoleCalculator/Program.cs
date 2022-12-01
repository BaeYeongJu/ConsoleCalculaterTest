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
            double result = 0;
            ConsoleKey inputKey;

            CalculateManager calculateManager = new CalculateManager();
            UIManager uiManager = new UIManager();
            MemoryManager memoryManager = new MemoryManager();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 :");

            firstStringNumber = Console.ReadLine();
            if (!CalculateManager.IsNumberDoubleType(firstStringNumber))
                uiManager.ShowErrorMessage();

            Console.Write("연산자 입력 (+, -, *, /, %, n, ., r, s, p, c):");
            inputKey = uiManager.InputKey();
            Console.WriteLine();

            if (!calculateManager.IsInputKeyOperatorCorrect(inputKey))
                uiManager.ShowErrorMessage();

            if (uiManager.IsInputKeyNotNeedSceondNumber(inputKey))
            {
                uiManager.ShowResult(calculateManager, firstStringNumber, inputKey, result);
            }
            else
            {
                Console.Write("두번째 숫자 입력 :");
                secondStringNumber = Console.ReadLine();

                if (!CalculateManager.IsNumberDoubleType(secondStringNumber))
                    uiManager.ShowErrorMessage();

                uiManager.ShowResult(calculateManager, firstStringNumber, secondStringNumber, inputKey, result);
            }

            Console.WriteLine("[F1~F5번까지 누르거나 없으면 종료 버튼을 눌려주세요]");
            Action<ConsoleKey> action = consoleKey =>
            {
                switch (consoleKey)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("F1");
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("F2");
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("F3");
                        break;
                    case ConsoleKey.F4:
                        Console.WriteLine("F4");
                        break;
                    case ConsoleKey.F5:
                        Console.WriteLine("F5");
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            };
            uiManager.InputKey(action);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    //메세지, UI 버튼 관련
    public class UIManager
    {
        private void ShowMessage(string firstStringNumber, string operatorSymbol, double result)
        {
            switch (operatorSymbol)
            {
                case "r":
                    Console.WriteLine($"결과: 1/({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case "s":
                    Console.WriteLine($"결과: √({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case "p":
                    Console.WriteLine($"결과: sqr({double.Parse(firstStringNumber)}) = {result} ");
                    break;
                case "c":
                    Console.WriteLine($"결과: {result} ");
                    break;
            }
        }

        private void ShowMessage(string firstStringNumber, string operatorSymbol, string secondStringNumber, double result)
        {
            if (operatorSymbol == "." || operatorSymbol == "n")
                Console.WriteLine($"결과: {result} ");
            else
                Console.WriteLine($"결과: {double.Parse(firstStringNumber) + operatorSymbol + double.Parse(secondStringNumber)} = {result} ");
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), operatorSymbol);
            ShowMessage(firstStringNumber, operatorSymbol, result);
        }

        public void ShowResult(CalculateManager calculateManager, string firstStringNumber, string secondStringNumber, string operatorSymbol, double result)
        {
            result = calculateManager.Calculate(double.Parse(firstStringNumber), double.Parse(secondStringNumber), operatorSymbol);
            ShowMessage(firstStringNumber, operatorSymbol, secondStringNumber, result);
        }

        public void ShowErrorMessage()
        {
            Console.WriteLine("잘못 입력되었습니다.");
            Environment.Exit(0);
        }

        //0 : MS 메모리 저장, 1 :M+ 메모리 더하기, 2 : M- 메모리 빼기, 3:MC : 메모리 지우기 4 : MR 메모리 불려오기
        static public void ShowMemoryList(int currentIndex)
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = i == currentIndex ? ConsoleColor.Blue : ConsoleColor.Green;
                Console.WriteLine("List : " + i);
            }

            switch (currentIndex)
            {
                case 0:
                    Console.WriteLine("메모리 저장");
                    break;
                case 1:
                    Console.WriteLine("메모리 더하기");
                    break;
                case 2:
                    Console.WriteLine("메모리 빼기");
                    break;
                case 3:
                    Console.WriteLine("메모리 지우기");
                    break;
                case 4:
                    Console.WriteLine("메모리 불려오기");
                    break;
                default:
                    break;
            }
        }
    }
}

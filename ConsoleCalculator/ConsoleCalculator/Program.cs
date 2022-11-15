using System;

namespace ConsoleCalculator
{
    class Program
    {
        private string firstStringNumber;
        private string secondStringNumber;
        private string operatorSymbol;

        private int result = 0;

        static void Main(string[] args)
        {
            Program main = new Program();

            Console.WriteLine("[Calculater]");
            Console.Write("숫자 1 입력 (정수):");
            main.firstStringNumber = Console.ReadLine();

            Console.Write("연산자 입력 (+,-,*,/,%):");
            main.operatorSymbol = Console.ReadLine();

            Console.Write("숫자 2 입력 (정수):");
            main.secondStringNumber = Console.ReadLine();

            main.SetOperatorCalculate();

            Console.WriteLine($"결과: {main.firstStringNumber + main.operatorSymbol + main.secondStringNumber} = {main.result} ");

            //예외 처리 참조)
            /*if (int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("결과:" + number);
            }
            else
            {
                Console.WriteLine("결과: 문자열이 들어갔음");
            }*/
        }

        private void SetOperatorCalculate()
        {
            switch (operatorSymbol)
            {
                case "+":
                    result = int.Parse(firstStringNumber) + int.Parse(secondStringNumber);
                    break;
                case "-":
                    result = int.Parse(firstStringNumber) - int.Parse(secondStringNumber);
                    break;
                case "*":
                    result = int.Parse(firstStringNumber) * int.Parse(secondStringNumber);
                    break;
                case "/":
                    result = int.Parse(firstStringNumber) / int.Parse(secondStringNumber);
                    break;
                case "%":
                    result = int.Parse(firstStringNumber) % int.Parse(secondStringNumber);
                    break;
                default:
                    break;
            }
        }
    }
}

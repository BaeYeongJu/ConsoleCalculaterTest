using System;

namespace ConsoleCalculator
{
    public class Program
    {
        private string firstStringNumber;
        private string secondStringNumber;
        private string operatorSymbol;

        private int firstNumber = 0;
        private int secondNumber = 0;

        static void Main(string[] args)
        {
            Program main = new Program();

            Console.WriteLine("[Calculater]");
            Console.Write("첫번째 숫자 입력 (정수):");
            main.firstStringNumber = Console.ReadLine();
            main.SetResultMessage(main.firstStringNumber, main.firstNumber);

            Console.Write("연산자 입력 (+,-,*,/,%):");
            main.operatorSymbol = Console.ReadLine();

            Console.Write("두번째 숫자 입력 (정수):");
            main.secondStringNumber = Console.ReadLine();

            main.SetResultMessage(main.secondStringNumber, main.secondNumber);
            var result = main.SetOperatorCalculate();

            Console.WriteLine($"결과: {main.firstStringNumber + main.operatorSymbol + main.secondStringNumber} = {result} ");
        }

        private void SetResultMessage(string stringNumber, int number)
        {
            if (!int.TryParse(stringNumber, out number))
                Console.WriteLine("결과: 숫자 잘못 입력됨");
        }

        private int SetOperatorCalculate()
        {
            switch (operatorSymbol)
            {
                case "+":
                    return int.Parse(firstStringNumber) + int.Parse(secondStringNumber);
                case "-":
                    return int.Parse(firstStringNumber) - int.Parse(secondStringNumber);
                case "*":
                    return int.Parse(firstStringNumber) * int.Parse(secondStringNumber);
                case "/":
                    return int.Parse(firstStringNumber) / int.Parse(secondStringNumber);
                case "%":
                    return int.Parse(firstStringNumber) % int.Parse(secondStringNumber);
            }
            return 0;
        }

        public static Program operator +(Program a) => a;

        //추후 값 연산자 값 으로 줄이기 (코드를 줄이기) -> 1줄로 줄이고 싶음...
    }

    //예외 처리 하기
    //int면 정수만 입력 가능하게
    //그외의 값이 잘못 쳤다고 오류 출력
    //연산자도 마찬가지
}

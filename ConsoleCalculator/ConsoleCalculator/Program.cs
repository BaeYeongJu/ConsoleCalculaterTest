using System;

namespace ConsoleCalculator
{
    public class Program
    {
        public string firstStringNumber;
        public string secondStringNumber;
        public string operatorSymbol;

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

            int firstNum = int.Parse(main.firstStringNumber);
            int secondNum = int.Parse(main.secondStringNumber);

            var result = main.SetOperatorCalculate(firstNum, secondNum);

            Console.WriteLine($"결과: {main.firstStringNumber + main.operatorSymbol + main.secondStringNumber} = {result} ");
        }

        private void SetResultMessage(string stringNumber, int number)
        {
            if (!int.TryParse(stringNumber, out number))
                Console.WriteLine("결과: 숫자 잘못 입력됨");
        }

        public int SetOperatorCalculate(int firstNumber, int secondNumber)
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

        //추후 값 연산자 값 으로 줄이기 (코드를 줄이기) -> 1줄로 줄이고 싶음...
    }

    //예외 처리 하기
    //int면 정수만 입력 가능하게
    //그외의 값이 잘못 쳤다고 오류 출력
    //연산자도 마찬가지
}

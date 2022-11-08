using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber;
            int number= 0;
            bool isNumber = false;

            Console.WriteLine("[Calculater]");
            Console.Write("입력:");
            stringNumber = Console.ReadLine();

            //number = Convert.ToInt32(stringNumber);

            if(int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("결과:" + number);
            }
            else
            {
                Console.WriteLine("결과: 문자열이 들어갔음");
            }
        }
    }
}

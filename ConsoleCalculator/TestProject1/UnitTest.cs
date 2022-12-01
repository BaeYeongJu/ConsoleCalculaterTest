using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        /*Arrange : 테스트할 메소드를 인스턴스 해줌
        Act : 테스트할 시나리오를 구현
        Assert : 예상 값과 일치하는지 확인*/

        private CalculateManager calculator;
        private MemoryManager memory;

        [TestInitialize()]
        public void Initialize()
        {
            calculator = new CalculateManager();
            memory = new MemoryManager();
        }

        [TestMethod]
        [DataRow(0, 10)]
        [DataRow(2.3, 14.2)]
        public void CalculateAddTest(double a, double b)
        {
            //main.Add(a, b) == a+b
            Assert.AreEqual(calculator.Add(a, b), a + b);
        }

        [TestMethod]
        [DataRow(20, 10)]
        [DataRow(5.2, 1.2)]
        public void CalculateSubTest(double a, double b)
        {
            //main.Sub(a, b) == a-b
            Assert.AreEqual(calculator.Sub(a, b), a - b);
        }

        [TestMethod]
        [DataRow(-3, 10)]
        [DataRow(5.2, 7.3)]
        public void CalculateMultiplicationTest(double a, double b)
        {
            //main.Multiplication(a, b) == a*b
            Assert.AreEqual(calculator.Multiplication(a, b), a * b);
        }

        [TestMethod]
        [DataRow(14, 10)]
        [DataRow(5.9, 28.3)]
        public void CalculateDivisionTest(double a, double b)
        {
            //main.Multiplication(a, b) == a/b
            Assert.AreEqual(calculator.Division(a, b), a / b);
        }

        [TestMethod]
        [DataRow(3, 2)]
        [DataRow(3.3, 2.7)]
        public void CalculateRemainderTest(double a, double b)
        {
            //main.Remainder(a, b) == a%b
            Assert.AreEqual(calculator.Remainder(a, b), a % b);
        }

        [TestMethod]
        [DynamicData(nameof(CalculateOneInputData),DynamicDataSourceType.Method)]
        public void CalculateOneInputTest(double a, ConsoleKey consoleKey, double result)
        {
            Assert.AreEqual(calculator.Calculate(a, consoleKey), result);
        }

        public static IEnumerable<object[]> CalculateOneInputData()
        {
            return new[]
            {
                new object[] { 3, ConsoleKey.R , 1/(double)3 },
                new object[] { 53, ConsoleKey.S , Math.Sqrt(53) },
                new object[] { 153, ConsoleKey.S , Math.Sqrt(153) },
                new object[] { 10, ConsoleKey.P , Math.Pow(10,2) },
                new object[] { 10, ConsoleKey.C , 0 }
            };
        }

        //첫번째와 두번째 숫자 테스트 코드
        [TestMethod]
        [DynamicData(nameof(CalculateTwoInputData), DynamicDataSourceType.Method)]
        public void CalculateTwoInputTest(double a, double b, ConsoleKey consoleKey, double result)
        {
            Assert.AreEqual(calculator.Calculate(a, b, consoleKey), result);
        }

        public static IEnumerable<object[]> CalculateTwoInputData()
        {
            return new[]
            {
                new object[] { 20, 10, ConsoleKey.OemPlus, 20+10 },
                new object[] { 3.2, 9, ConsoleKey.OemPlus, 3.2+9 },
                new object[] { 3.2, 9.3234, ConsoleKey.OemPlus, 3.2+9.3234 },
                new object[] { 4, 345, ConsoleKey.OemMinus, 4-345},
                new object[] { 29.2, 10.3, ConsoleKey.OemMinus, 29.2 - 10.3 },
                new object[] { 4, 67, ConsoleKey.D8, 4 * 67 },
                new object[] { 22.2, 45.3, ConsoleKey.D8, 22.2 * 45.3 },
                new object[] { 23, 19.3, ConsoleKey.Oem2, 23 / 19.3 },
                new object[] { 233, 16.3, ConsoleKey.Oem2, 233 / 16.3 },
                new object[] { 3, 4.3, ConsoleKey.D5, 3 % 4.3 },
                new object[] { 24, 16.3, ConsoleKey.D5, 24 % 16.3 },
                new object[] { 24, 0, ConsoleKey.D5, double.NaN },
                new object[] { 24, 0, ConsoleKey.Oem2, double.PositiveInfinity },
                new object[] { 24, 16, ConsoleKey.OemPeriod, 24.16 },
                new object[] { 24, 16, ConsoleKey.N, -2416 },
                //연산자 우선순위 앞에서 부터 계산, string 앞에 부터 바뀌고, 순서가 생김

                //암시적 변환 -> 박싱
            };
        }

        [TestMethod]
        public void InputEnterkeyExit()
        {
            var consoleKey = ConsoleKey.Enter;
            Assert.AreEqual(ConsoleKey.Enter, consoleKey);
        }

        [TestMethod]
        [DataRow(ConsoleKey.D6)]
        [DataRow(ConsoleKey.X)]
        [DataRow(ConsoleKey.Enter)]
        public void InputOperatorEqualsTest(ConsoleKey consoleKey)
        {
            Assert.IsFalse(calculator.IsInputKeyOperatorCorrect(consoleKey));
        }

        [TestMethod]
        [DataRow(0, 20, 20)]
        [DataRow(10, 40, 50)]
        public void SaveMemoryTest(double first, double later , double result)
        {
            Assert.AreEqual(memory.Save(first, later), result);
        }

        [TestMethod]
        [DataRow(20)]
        [DataRow(40)]
        public void LoadMemoryTest(double number)
        {
            Assert.AreEqual(memory.Load(number), number);
        }

        [TestMethod]
        public void ClearMemoryTest()
        {
            Assert.AreEqual(0, memory.Clear());
        }

        [TestMethod]
        [DataRow(20, 2 , 40)]
        [DataRow(20, 3 , 60)]
        public void AddMemoryTest(double number, int count, double result)
        {
            Assert.AreEqual(memory.Add(number, count), result);
        }

        [TestMethod]
        [DataRow(40, 2, 20)]
        [DataRow(60, 3, 20)]
        public void SubMemoryTest(double number, int count, double result)
        {
            Assert.AreEqual(memory.Sub(number, count), result);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            calculator = null;
            memory = null;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System.Diagnostics;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        /*Arrange : 테스트할 메소드를 인스턴스 해줌
        Act : 테스트할 시나리오를 구현
        Assert : 예상 값과 일치하는지 확인*/

        private CalculateManager calculator;

        [TestInitialize()]
        public void Initialize()
        {
            calculator = new CalculateManager();
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
        [DataRow(3, 2, "+")]
        public void CalculateAddOperatorTest(double a, double b, string operatorSymbol)
        {
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), a + b);
        }

        [TestMethod]
        [DataRow(3, 2, "-")]
        public void CalculateSubOperatorTest(double a, double b, string operatorSymbol)
        {
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), a - b);
        }

        [TestMethod]
        [DataRow(3, 2, "*")]
        public void CalculateMultiplicationOperatorTest(double a, double b, string operatorSymbol)
        {
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), a * b);
        }

        [TestMethod]
        [DataRow(3, 2, "/")]
        public void CalculateDivisionOperatorTest(double a, double b, string operatorSymbol)
        {
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), a / b);
        }

        [TestMethod]
        [DataRow(3, 2, "%")]
        public void CalculateRemainderOperatorTest(double a, double b, string operatorSymbol)
        {
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), a % b);
        }

        [TestMethod]
        [DataRow(3, 2, "n")]
        [DataRow(-3, 1, "n")]
        public void CalculateNegativeOperatorTest(double a, double b, string operatorSymbol)
        {
            string result= (-a).ToString() + b.ToString();
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), double.Parse(result));
        }

        [TestMethod]
        [DataRow(0, 3, ".")]
        public void CalculateDotOperatorTest(double a, double b, string operatorSymbol)
        {
            string result = (a).ToString() + operatorSymbol + b.ToString();
            Assert.AreEqual(calculator.Calculate(a, b, operatorSymbol), double.Parse(result));
        }


        [TestCleanup()]
        public void Cleanup()
        {
            calculator = null;
        }
    }
}

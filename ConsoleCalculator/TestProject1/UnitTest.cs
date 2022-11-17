using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

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
        public void CalculateAddTest(int a,int b)
        {
            //main.Add(a, b) == a+b

            Assert.AreEqual(calculator.Add(a, b), a + b);
        }

        [TestMethod]
        [DataRow(20, 10)]
        public void CalculateSubTest(int a, int b)
        {
            //main.Sub(a, b) == a-b

            Assert.AreEqual(calculator.Sub(a, b), a - b);
        }

        [TestMethod]
        [DataRow(-3, 10)]
        public void CalculateMultiplicationTest(int a, int b)
        {
            //main.Multiplication(a, b) == a*b
            Assert.AreEqual(calculator.Multiplication(a, b), a * b);
        }

        [TestMethod]
        [DataRow(14, 10)]
        public void CalculateDivisionTest(int a, int b)
        {
            //main.Multiplication(a, b) == a/b
            Assert.AreEqual(calculator.Division(a, b), a / b);
        }

        [TestMethod]
        [DataRow(3, 2)]
        public void CalculateRemainderTest(int a, int b)
        {
            //main.Remainder(a, b) == a%b
            Assert.AreEqual(calculator.Remainder(a, b), a % b);
        }

        [TestCleanup()]
        public void Cleanup() 
        {
            calculator = null;
        }
    }
}

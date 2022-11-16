using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*Arrange : 테스트할 메소드를 인스턴스 해줌
        Act : 테스트할 시나리오를 구현
        Assert : 예상 값과 일치하는지 확인*/

        [TestMethod]
        [DataRow(0, 10)]
        public void CalculateAddTest(int a,int b)
        {
            var main = new Program();
            //main.Add(a, b) == a+b

            Assert.AreEqual(main.Add(a, b), a + b);
        }

        [TestMethod]
        [DataRow(20, 10)]
        public void CalculateSubTest(int a, int b)
        {
            var main = new Program();
            //main.Sub(a, b) == a-b

            Assert.AreEqual(main.Sub(a, b), a - b);
        }

        [TestMethod]
        [DataRow(-3, 10)]
        public void CalculateMultiplicationTest(int a, int b)
        {
            var main = new Program();

            //main.Multiplication(a, b) == a*b
            Assert.AreEqual(main.Multiplication(a, b), a * b);
        }

        [TestMethod]
        [DataRow(14, 10)]
        public void CalculateDivisionTest(int a, int b)
        {
            var main = new Program();

            //main.Multiplication(a, b) == a/b
            Assert.AreEqual(main.Division(a, b), a / b);
        }

        [TestMethod]
        [DataRow(3, 2)]
        public void CalculateRemainderTest(int a, int b)
        {
            var main = new Program();

            //main.Remainder(a, b) == a%b
            Assert.AreEqual(main.Remainder(a, b), a % b);
        }
    }
}

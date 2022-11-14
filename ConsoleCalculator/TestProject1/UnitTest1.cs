using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*Arrange : �׽�Ʈ�� �޼ҵ带 �ν��Ͻ� ����
        Act : �׽�Ʈ�� �ó������� ����
        Assert : ���� ���� ��ġ�ϴ��� Ȯ��*/

        [TestMethod]
        [DataRow(0, 10)]
        public void TestMethod1(int a,int b)
        {
            var main = new Program();
            //main.Add(a, b) == a+b
            Assert.AreEqual(main.Add(a, b), a+b);
        }
    }
}

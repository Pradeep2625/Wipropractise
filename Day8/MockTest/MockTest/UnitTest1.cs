using Moq;

namespace MockTest
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestSum()
        {
            Mock<ICalculation> mock = new Mock<ICalculation>();
            mock.Setup(x=>x.Sum(10,5)).Returns(15);
            Assert.AreEqual(15,mock.Object.Sum(10,5));
        }
        [Test]
        public void TestMul()
        {

        }
        [Test]
        public void TestGreetings()
        {
            Mock<ICalculation> mock2 = new Mock<ICalculation>();
            mock2.Setup(x => x.Greeting()).Returns("hello welcome pradeep");
            Assert.AreEqual("hello welcome pradeep",mock2.Object.Greeting());
        }
        [Test]
        public void Testsub()
        {
            Mock<ICalculation> mock = new Mock<ICalculation>();
            mock.Setup(x => x.Sum(10, 5)).Returns(5);
            Assert.AreEqual(5, mock.Object.Sum(10, 5));

        }
    }
}
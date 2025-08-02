using CalculatorTest;

namespace TestCalculator
{
    public class Tests
    {
        [SetUp]
        public void TestGreetings()
        {
            CalcMain calculator = new CalcMain();
            string message = calculator.Greetings();
            Assert.AreEqual("Hello world!!,welcome to world of c# & dotnet", message);
        }

        [Test]
        public void TestSum()
        {
            CalcMain calc = new CalcMain();
            int result = calc.Sum(10, 15);
            Assert.AreEqual(25, result);
        }
        [Test] 
        public void TestDivision()
        {
            CalcMain calc1 = new CalcMain();
            //decimal result = calc1.Dvision(10,0);
            Assert.Catch<DivideByZeroException>(() =>  calc1.Dvision(10,1));
        }
    }
}
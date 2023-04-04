using CalculatorTester;

namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(2.1f, 3.2f, 5.3f)]
        [TestCase(5, -3, 2)]
        public void Add_ReturnsSum(float a, float b, float result)
        {
            var sum = Calculator.Add(a, b);
            Assert.That(sum, Is.EqualTo(result));
        }

        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(5.1f, 2.1f, 3)]
        [TestCase(5, -3, 8)]
        public void Subtract_ReturnsDifference(float a, float b, float result)
        {
            var diff = Calculator.Subtract(a, b);
            Assert.That(diff, Is.EqualTo(result));
        }

        [Test]
        [TestCase(3, 2, 6)]
        [TestCase(4, 8, 32)]
        [TestCase(5, -3, -15)]
        public void Multiply_ReturnsProduct(float a, float b, float result)
        {
            var prod = Calculator.Multiply(a, b);
            Assert.That(prod, Is.EqualTo(result));
        }

        [Test]
        [TestCase(6, 2, 3)]
        [TestCase(6, 3, 2)]
        [TestCase(-15, -3, 5)]
        public void Divide_ReturnsQuotient(float a, float b, float result)
        {
            var quot = Calculator.Divide(a, b);
            Assert.That(quot, Is.EqualTo(result));
        }

        [Test]
        public void Divide_ThrowsOnDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(4, 0));
        }
    }
}
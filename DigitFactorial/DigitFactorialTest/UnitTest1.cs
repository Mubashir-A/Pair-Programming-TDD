using DigitFactorial;

namespace DigitFactorialTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        [TestCase(7, 5040)]
        public void FactorialTests(int input, int expected)
        {
            Assert.That(Program.Factorial(input), Is.EqualTo(expected));
        }

        [TestCase(145, 145)]
        [TestCase(469, 363624)]
        public void DigitFactorialTest(int input, int expected)
        {
            Assert.That(Program.DigitFactorial(input), Is.EqualTo(expected));
        }

        [TestCase(145, true)]
        [TestCase(469, false)]
        [TestCase(4, false)]
        [TestCase(1, false)]
        [TestCase(2, false)]

        public void DigitFactorialTest(int input, bool expected)
        {
            Assert.That(Program.IsSpecialDigitFactorial(input), Is.EqualTo(expected));
        }

        [TestCase(0, 150 , 145)]
        [TestCase(0, 1000000, 40730)]
        public void DigitFactorialTest(int inputStart, int inputFinish, int expected)
        {
            Assert.That(Program.sumRange(inputStart,inputFinish), Is.EqualTo(expected));
        }
    }
}
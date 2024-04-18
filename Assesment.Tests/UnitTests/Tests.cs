using Assesment.Tests.Configurations;
using Assess;
using NUnit.Framework.Internal;

namespace Assesment.Tests.UnitTests
{
    [Order(0)]
    public class Tests
    {
        [Test]
        [PointsCalculator(10, 2)]
        public void GetMostFrequent()
        {
            Exam e = new();
            Assert.Multiple(() =>
            {
                Assert.That(e.GetMostFrequent("mamaaa"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("gagga"), Is.EqualTo('g'));
                Assert.That(e.GetMostFrequent("12312333"), Is.EqualTo('3'));
                Assert.Throws<ArgumentException>(() => e.GetMostFrequent(""), $"Empty input should throw ArgumentException.");
                Assert.Throws<ArgumentException>(() => e.GetMostFrequent(null), $"Null input should throw ArgumentException.");

            });
        }

        [Test]
        [PointsCalculator(10, 2)]
        public void Factorial()
        {
            // Act & Assert
            Assert.Multiple(() =>
            {
                Assert.That(Exam.Factorial(5), Is.EqualTo(120));
                Assert.That(Exam.Factorial(2), Is.EqualTo(2));
                Assert.That(Exam.Factorial(7), Is.EqualTo(5040));
                Assert.That(Exam.Factorial(1), Is.EqualTo(1));
                Assert.Throws<ArgumentException>(() => Exam.Factorial(-5), $"Factorial of {-5} should throw ArgumentException.");
            });
        }

        [Test]
        [PointsCalculator(10, 1)]
        public void VerifyPalindrome()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Exam.IsPalindrome(""), Is.True);
                Assert.That(Exam.IsPalindrome("a"), Is.True);
                Assert.That(Exam.IsPalindrome("level"), Is.True);
                Assert.That(Exam.IsPalindrome("radar"), Is.True);
                Assert.That(Exam.IsPalindrome("hello"), Is.False);
                Assert.That(Exam.IsPalindrome("Panama"), Is.False);
                Assert.That(Exam.IsPalindrome("Home"), Is.False);
                Assert.That(Exam.IsPalindrome("123"), Is.False);
                Assert.That(Exam.IsPalindrome("111"), Is.True);
                Assert.That(Exam.IsPalindrome("A!@#$%^&*()a"), Is.True);
            });
        }

        [Test]
        [PointsCalculator(10, 2)]
        public void Test_ReverseNum()
        {
            // Arrange & Assert
            Assert.Multiple(() =>
            {
                Assert.That(Exam.ReverseNum(12345), Is.EqualTo(54321));
                Assert.That(Exam.ReverseNum(-12345), Is.EqualTo(-54321));
                Assert.That(Exam.ReverseNum(0), Is.EqualTo(0));
                Assert.That(Exam.ReverseNum(7), Is.EqualTo(7));
                Assert.That(Exam.ReverseNum(1000), Is.EqualTo(1));
            });
        }

        [Test]
        [PointsCalculator(10, 2)]
        public void Test_ArraySum()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4 };
            int[] array1 = { -1, 2, -3, 4 };
            int[] array2 = { -1, -2, -3, -4 };
            int[] array3 = { 5 };
            int[] emptyArray = { };

            // Act & Assert
            Assert.Multiple(() =>
            {
                Assert.That(Exam.ArraySum(array), Is.EqualTo(10));
                Assert.That(Exam.ArraySum(array1), Is.EqualTo(2));
                Assert.That(Exam.ArraySum(array2), Is.EqualTo(-10));
                Assert.That(Exam.ArraySum(array3), Is.EqualTo(5));
                Assert.Throws<ArgumentException>(() => Exam.ArraySum(emptyArray), $"The givrn array {emptyArray} should throw ArgumentException.");
            });
        }
    }
}
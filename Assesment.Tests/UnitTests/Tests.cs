using Assesment.Tests.Configurations;
using Assess.Services.Exams;
using NUnit.Framework.Internal;

namespace Assesment.Tests.UnitTests
{
    [Order(0)]
    public class Tests
    {
        [Test]
        [PointsCalculator(8, 2)]
        public void GetMostFrequent()
        {
            Exam e = new();
            Assert.Multiple(() =>
            {
                Assert.That(e.GetMostFrequent("mamaaa"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("gaga"), Is.EqualTo('g'));
                Assert.That(e.GetMostFrequent("agag"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("123123"), Is.EqualTo('3'));
            });
        }

        [Test]
        [PointsCalculator(3, 1)]
        public void Factorial()
        {
            // Act
            int result = Exam.Factorial(5);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(120));
                Assert.That(result, Is.EqualTo(120));
                Assert.Throws<ArgumentException>(() => Exam.Factorial(-5), $"Factorial of {-5} should throw ArgumentException.");
            });
        }

        [Test]
        [PointsCalculator(9, 1)]
        public void VerifyPalindrome()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Exam.IsPalindrome(""), Is.True);
                Assert.That(Exam.IsPalindrome("a"), Is.True);
                Assert.That(Exam.IsPalindrome("level"), Is.True);
                Assert.That(Exam.IsPalindrome("radar"), Is.True);
                Assert.That(Exam.IsPalindrome("hello"), Is.False);
                Assert.That(Exam.IsPalindrome("hi"), Is.False);
                Assert.That(Exam.IsPalindrome("Panama!"), Is.False);
                Assert.That(Exam.IsPalindrome("!@#$%^&*()"), Is.True);
                Assert.That(Exam.IsPalindrome("A!@#$%^&*()a"), Is.True);
            });
        }

        [Test]
        [PointsCalculator(5, 1)]
        public void Test_GeneratePrimes()
        {
            // Act
            int[] expected = { };
            int[] expected1 = { 2 };
            int[] expected2 = { 2, 3, 5, 7 };
            int[] expected3 = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] expected4 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };

            // Arrange & Assert
            Assert.Multiple(() =>
            {
                Assert.That(Exam.GeneratePrimes(1), Is.EqualTo(expected));
                Assert.That(Exam.GeneratePrimes(2), Is.EqualTo(expected1));
                Assert.That(Exam.GeneratePrimes(10), Is.EqualTo(expected2));
                Assert.That(Exam.GeneratePrimes(20), Is.EqualTo(expected3));
                Assert.That(Exam.GeneratePrimes(50), Is.EqualTo(expected4));
            });
        }

        [Test]
        [PointsCalculator(6, 2)]
        public void Test_FahrenheitToCelsius()
        {
            Assert.Multiple(() =>
            {
                // Test Celsius to Fahrenheit
                double celsius = 0;
                double expectedFahrenheit = 32;
                double actualFahrenheit = Exam.ConvertTemperature(celsius, "Celsius", "Fahrenheit");
                Assert.That(actualFahrenheit, Is.EqualTo(expectedFahrenheit));

                // Test Fahrenheit to Celsius
                double fahrenheit = 32;
                double expectedCelsius = 0;
                double actualCelsius = Exam.ConvertTemperature(fahrenheit, "Fahrenheit", "Celsius");
                Assert.That(actualCelsius, Is.EqualTo(expectedCelsius));

                double temperature = 100;
                Assert.Throws<ArgumentException>(() => Exam.ConvertTemperature(temperature, "Kelvin", "Fahrenheit"));
            });
        }
    }
}
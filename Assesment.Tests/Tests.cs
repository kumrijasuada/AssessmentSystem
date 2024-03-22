using Assess.Services;
using NUnit.Framework.Internal;

namespace Assesment.Tests
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
                Assert.AreEqual(120, result);
                Assert.That(result, Is.EqualTo(120));
                Assert.Throws<ArgumentException>(() => Exam.Factorial(-5), $"Factorial of {-5} should throw ArgumentException.");
            });
        }

        [Test]
        [PointsCalculator(1, 1)]
        public void DisplayEvenNumbers_EmptyArray_ReturnsNothing()
        {
            int[] numbers = new int[0];
            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                Exam.DisplayEvenNumbers(numbers);
                string expected = "\nEven numbers entered:\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        [PointsCalculator(1, 1)]
        public void DisplayEvenNumbers_LessThanTenElements_ReturnsNothing()
        {
            int[] numbers = new int[5];
            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                Exam.DisplayEvenNumbers(numbers);
                string expected = "\nEven numbers entered:\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        [PointsCalculator(1, 1)]
        public void DisplayEvenNumbers_ExactlyTenElements_ReturnsEvenNumbers()
        {
            int[] numbers = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                Exam.DisplayEvenNumbers(numbers);
                string expected = "\nEven numbers entered:\r\n2\r\n4\r\n6\r\n8\r\n10\r\n12\r\n14\r\n16\r\n18\r\n20\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        [PointsCalculator(1, 1)]
        public void DisplayEvenNumbers_MoreThanTenElements_ReturnsFirstTenEvenNumbers()
        {
            int[] numbers = new int[15] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29 };
            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                Exam.DisplayEvenNumbers(numbers);
                string expected = "\nEven numbers entered:\r\n2\r\n4\r\n6\r\n8\r\n10\r\n12\r\n14\r\n16\r\n18\r\n20\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        [PointsCalculator(1, 1)]
        public void DisplayEvenNumbers_InvalidIntegerInput_ReturnsValidEvenNumbers()
        {
            int[] numbers = new int[10];
            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                using (StringReader sr = new("a\nb\nc\nd\ne\n2\n4\n6\n8\n10\n"))
                {
                    Console.SetIn(sr);
                    Exam.DisplayEvenNumbers(numbers);
                    string expected = "\nEven numbers entered:\r\n2\r\n4\r\n6\r\n8\r\n10\r\n";
                    Assert.That(sw.ToString(), Is.EqualTo(expected));
                }
            }
        }

        [Test]
        [PointsCalculator(8, 1)]
        public void VerifyPalindrome()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Exam.IsPalindrome(""), Is.True);
                Assert.That(Exam.IsPalindrome("a"), Is.True);
                Assert.That(Exam.IsPalindrome("level"), Is.True);
                Assert.That(Exam.IsPalindrome("radar"), Is.False);
                Assert.That(Exam.IsPalindrome("hello"), Is.False);
                Assert.That(Exam.IsPalindrome("Panama!"), Is.True);
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
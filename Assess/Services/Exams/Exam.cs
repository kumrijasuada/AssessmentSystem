namespace Assess.Services.Exams
{
    public class Exam
    {
        // Write a C# program to find the factorial of a given number using a recursive function.
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.", nameof(n));

            if (n == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // Write a program in C# that asks the user for 10 integers to store them in an array of integers
        // and show only even integers.
        public static void DisplayEvenNumbers(int[] numbers)
        {
            if (numbers.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        numbers[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        i--;
                    }
                }

                Console.WriteLine("\nEven numbers entered:");
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }

        // Write a C# program that checks whether a given string is a palindrome or not
        // (a palindrome is a word, phrase, number, or other sequence of characters that
        // reads the same forward and backward).
        // Example => Ada
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(str[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(str[right]))
                {
                    right--;
                }

                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // Develop a C# program to generate and display all prime numbers less than a specified number.
        public static int[] GeneratePrimes(int n)
        {
            if (n <= 2)
            {
                if (n == 2)
                    return new int[] { 2 };
                else
                    return new int[] { };
            }

            bool[] prime = new bool[n];
            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i < n; i += p)
                        prime[i] = false;
                }
            }

            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (prime[i] == true)
                    count++;
            }

            int[] primes = new int[count];
            int index = 0;
            for (int p = 2; p < n; p++)
            {
                if (prime[p] == true)
                    primes[index++] = p;
            }

            return primes;
        }

        // Create a C# program that converts temperature from Celsius to Fahrenheit and vice versa.
        public static double ConvertTemperature(double temperature, string unitFrom, string unitTo)
        {
            if (unitFrom.Equals("Celsius") && unitTo.Equals("Fahrenheit"))
            {
                return temperature * 9 / 5 + 32;
            }
            else if (unitFrom.Equals("Fahrenheit") && unitTo.Equals("Celsius"))
            {
                return (temperature - 32) * 5 / 9;
            }
            else
            {
                throw new ArgumentException("Unsupported temperature conversion.");
            }
        }


        public char GetMostFrequent(string input)
        {

            var charMap = input.Distinct()
                .ToDictionary(c => c, c => input.Count(s => s == c));

            return charMap.OrderByDescending(v => v.Value).First().Key;
        }
    }
}

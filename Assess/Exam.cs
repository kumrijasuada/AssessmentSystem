namespace Assess
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
        

        // Write a C# program that checks whether a given string is a palindrome or not
        // (a palindrome is a word, phrase, number, or other sequence of characters that
        // reads the same forward and backward).
        // Example => Ada
        public static bool IsPalindrome(string value)
        {
            value = value.ToLower();
            int left = 0;
            int right = value.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(value[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(value[right]))
                {
                    right--;
                }

                if (value[left] != value[right])
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
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty.");

            int[] charCount = new int[256];
            int length = input.Length;

            // Count frequency of each character
            for (int i = 0; i < length; i++)
            {
                charCount[input[i]]++;
            }

            int maxCount = -1;
            char character = ' ';

            // Find the character with maximum count
            for (int i = 0; i < 256; i++)
            {
                if (maxCount < charCount[i])
                {
                    maxCount = charCount[i];
                    character = (char)i;
                }
            }

            return character;
        }


        public static int ReverseNum(int num)
        {
            int reversedNum = 0, value;

            int originalSign = num < 0 ? -1 : 1;

            num = Math.Abs(num);

            while (num != 0)
            {
                value = num % 10;
                reversedNum = reversedNum * 10 + value;
                num /= 10;
            }

            return reversedNum * originalSign;
        }

    }
}

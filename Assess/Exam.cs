namespace Assess
{
    public class Exam
    {
        // Write a C# function to find the most frequent char in a given string.
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

        // Write a C# function to find the factorial of a given number.
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

        // Write a C# function that checks whether a given string is a palindrome or not
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

        // Write a C# function that reverts the given value.
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

        // Write a C# function to calculate the sum of the elements in an array.
        public static int ArraySum(int[] array)
        {
            if (!array.Any())
            {
                throw new ArgumentException("The given array is empty");
            }

            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            return total;
        }
    }
}

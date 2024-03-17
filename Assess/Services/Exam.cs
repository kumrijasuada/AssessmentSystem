namespace Assess.Services
{
    public class Exam
    {
        public char GetMostFrequent(string input)
        {
            var charMap = input.Distinct()
                .ToDictionary(c => c, c => input.Count(s => s == c));

            return charMap.OrderByDescending(v => v.Value).First().Key;
        }

    }
}

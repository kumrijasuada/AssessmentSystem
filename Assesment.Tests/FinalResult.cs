using System.Text;

namespace Assesment.Tests
{
    [Order(9999)]
    public class FinalResult
    {
        [Test]
        public void Test()
        {
            StringBuilder resultBuilder = new();
            decimal totalPoints = 0;
            decimal totalEarnedPoints = 0;
            decimal totalFailedPoints = 0;

            foreach (var TestResult in ExamResults.ExamResultList)
            {
                totalPoints += TestResult.TotalPoints;
                totalEarnedPoints += TestResult.EarnedPoints;
                totalFailedPoints += TestResult.FailedPoints;
            }

            string data = $"TotalPoints:{totalPoints}Passed:{totalEarnedPoints}Fail:{totalFailedPoints}";

            //resultBuilder.AppendLine();
            //resultBuilder.AppendLine($"Total Points : **{totalPoints}**");
            //resultBuilder.AppendLine($"Passed : **{totalEarnedPoints}**");
            //resultBuilder.AppendLine($"Fail : **{totalFailedPoints}**");

            Console.Write(data); 
        }
    }
}

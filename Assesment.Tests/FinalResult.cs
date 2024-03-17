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

            resultBuilder.AppendLine($"Total Points: {totalPoints}");
            resultBuilder.AppendLine($"Passed : {totalEarnedPoints}");
            resultBuilder.AppendLine($"Fail :  {totalFailedPoints}");
            resultBuilder.AppendLine();

            Console.WriteLine(resultBuilder.ToString()); 

        }
    }
}

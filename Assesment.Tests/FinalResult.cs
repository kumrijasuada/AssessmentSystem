using Assesment.Tests.Models;

namespace Assesment.Tests
{
    [Order(9999)]
    public class FinalResult
    {
        [Test]
        public void Test()
        {
            decimal totalPoints = 0;
            decimal totalEarnedPoints = 0;
            decimal totalFailedPoints = 0;

            foreach (var TestResult in ExamResults.ExamResultList)
            {
                totalPoints += TestResult.TotalPoints;
                totalEarnedPoints += TestResult.EarnedPoints;
                totalFailedPoints += TestResult.FailedPoints;
            }

            string data = $"Total Points: **{totalPoints}**<br>Passed: **{totalEarnedPoints}**<br>Fail: **{totalFailedPoints}**";

            Console.Write(data);
        }
    }
}

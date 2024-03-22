namespace Assesment.Tests.Models
{
    public class ExamResult
    {
        public TestContext ExamContext { get; set; }
        public decimal EarnedPoints { get; set; }
        public decimal FailedPoints { get; set; }
        public decimal TotalPoints { get; set; }
        public decimal PointsPerAssert { get; set; }
    }
}

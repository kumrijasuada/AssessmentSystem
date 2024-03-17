namespace Assesment.Tests
{
    public static class ExamResults
    {
        public static List<ExamResult> ExamResultList = new();
    }

    public class ExamResult
    {
        public ExamResult()
        { }
        public  TestContext ExamContext { get; set; }
        public  decimal EarnedPoints { get; set; }
        public  decimal FailedPoints { get; set; }
        public  decimal TotalPoints { get; set; }
        public  decimal PointsPerAssert { get; set; }
    }
}

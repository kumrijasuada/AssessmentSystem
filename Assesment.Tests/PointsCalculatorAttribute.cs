using NUnit.Framework.Interfaces;

namespace Assesment.Tests
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class |
                 AttributeTargets.Interface | AttributeTargets.Assembly,
                 AllowMultiple = true)]


    public class PointsCalculatorAttribute : Attribute, ITestAction
    {
        private int _TotalPoints;
        private int _PointsPerAssert;
        public PointsCalculatorAttribute(int totalPoints,int pointsPerAssert) 
        { _TotalPoints = totalPoints; _PointsPerAssert = pointsPerAssert; }

        public void BeforeTest(ITest test)
        {
            //WriteToConsole("Before", test);
        }

        public void AfterTest(ITest test)
        {
            var Success = TestContext.CurrentContext.AssertCount - TestContext.CurrentContext.Result.Assertions.Count();

            ExamResult examResult = new ExamResult()
            {
                ExamContext = TestContext.CurrentContext,
                TotalPoints = _TotalPoints,
                EarnedPoints = Success * _PointsPerAssert,
                FailedPoints = _TotalPoints - (Success * _PointsPerAssert),
                PointsPerAssert = _PointsPerAssert
            };

            ExamResults.ExamResultList.Add(examResult);
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test | ActionTargets.Suite; }
        }

        //private void WriteToConsole(string eventMessage, ITest details)
        //{
        //    Console.WriteLine("{0} {1}: {2}, from {3}.{4}.",
        //        eventMessage,
        //        details.IsSuite ? "Suite" : "Case",
        //        _Message,
        //       /* details.FixtureType != null ? details.FixtureType.Name :*/ "{no fixture}",
        //        details.Method != null ? details.Method.Name : "{no method}");
        //}
    }
}

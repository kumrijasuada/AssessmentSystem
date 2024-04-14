using Assesment.Tests.Models;
using NUnit.Framework.Interfaces;

namespace Assesment.Tests.Configurations
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class |
                 AttributeTargets.Interface | AttributeTargets.Assembly,
                 AllowMultiple = true)]

    public class PointsCalculatorAttribute : Attribute, ITestAction
    {
        private int _totalPoints;
        private int _pointsPerAssert;

        public PointsCalculatorAttribute(
            int totalPoints,
            int pointsPerAssert)
        {
            _totalPoints = totalPoints;
            _pointsPerAssert = pointsPerAssert;
        }

        public void BeforeTest(ITest test)
        {
            //WriteToConsole("Before", test);
        }



        public void AfterTest(ITest test)
        {
            var Success =
                TestContext.CurrentContext.AssertCount - TestContext.CurrentContext.Result.Assertions.Count();

            ExamResult examResult = new()
            {
                TotalPoints = _totalPoints,
                EarnedPoints = Success * _pointsPerAssert,
                FailedPoints = _totalPoints - Success * _pointsPerAssert,
                PointsPerAssert = _pointsPerAssert
            };

            ExamResults.ExamResultList.Add(examResult);
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test | ActionTargets.Suite; }
        }
    }
}

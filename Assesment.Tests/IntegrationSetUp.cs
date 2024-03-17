using NUnit.Framework.Internal;
using System.Diagnostics;

namespace Assesment.Tests
{
    [SetUpFixture]
    public class IntegrationSetUpFixture : IDisposable
    {
        public IntegrationSetUpFixture()
        {
            // runs before all tests
            ExamResults.ExamResultList = new List<TestContext>();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // This method runs once before all tests
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // This method runs once after all tests
            var AssetSuccess = 0;
            var AssetFail = 0;
            foreach (var e in ExamResults.ExamResultList)
            {
                AssetFail += e.Result.Assertions.Count();
                AssetSuccess += e.AssertCount- e.Result.Assertions.Count();
            }

            TestContext.Progress.WriteLine($"Assert Success: {AssetSuccess},Assert Fail = {AssetFail}");
        }

        public void Dispose()
        {
            // This code runs once after all tests

        }
    }
}

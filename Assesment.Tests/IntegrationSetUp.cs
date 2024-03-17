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
        }

        public void Dispose()
        {
            // This code runs once after all tests

        }
    }
}

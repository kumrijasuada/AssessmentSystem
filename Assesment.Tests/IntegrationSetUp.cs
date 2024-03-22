using Assesment.Tests.Models;
using NUnit.Framework.Internal;

namespace Assesment.Tests
{
    [SetUpFixture]
    public class IntegrationSetUpFixture : IDisposable
    {
        public IntegrationSetUpFixture()
        {
            // runs before all tests
            ExamResults.ExamResultList = new List<ExamResult>();
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

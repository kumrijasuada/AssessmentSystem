﻿using Assesment.Tests.Models;
using NUnit.Framework.Internal;

namespace Assesment.Tests.Configurations
{
    [SetUpFixture]
    public class IntegrationSetUpFixture : IDisposable
    {
        public IntegrationSetUpFixture()
        {
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

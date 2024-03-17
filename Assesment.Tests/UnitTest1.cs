using Assess.Services;
using NUnit.Framework.Internal;

namespace Assesment.Tests
{
    [Order(0)]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Exam e = new();

            Assert.AreEqual('a', e.GetMostFrequent("mamaaa"));
            Assert.AreEqual('g', e.GetMostFrequent("gaga"));
            Assert.AreEqual('a', e.GetMostFrequent("agag"));
            Assert.AreEqual('3', e.GetMostFrequent("123123"));

           // TestExecutionContext.CurrentContext.OutWriter.WriteLine(TestExecutionContext.CurrentContext.CurrentResult);
            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Exam e = new();

            Assert.AreEqual('a', e.GetMostFrequent("mamaaa"));
            Assert.AreEqual('g', e.GetMostFrequent("gaga"));
            Assert.AreEqual('3', e.GetMostFrequent("12312312333456"));
            // TestExecutionContext.CurrentContext.OutWriter.WriteLine(TestExecutionContext.CurrentContext.CurrentResult);

            //Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            ExamResults.ExamResultList.Add(TestContext.CurrentContext);
        }
    }
}
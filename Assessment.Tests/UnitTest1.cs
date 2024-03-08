using Assess.Services;

namespace Assessment.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetMostFrequentCharTest()
        {
            Exam e = new();

            Assert.Equal('a', e.GetMostFrequent("mamaaa"));
            Assert.Equal('g', e.GetMostFrequent("gaga"));
            Assert.Equal('a', e.GetMostFrequent("agag"));
            Assert.Equal('3', e.GetMostFrequent("12312312333456"));


        }
    }
}
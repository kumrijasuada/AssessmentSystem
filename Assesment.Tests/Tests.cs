using Assess.Services;
using NUnit.Framework.Internal;

namespace Assesment.Tests
{
    [Order(0)]
    public class Tests
    {
        [Test]
        [PointsCalculator(8, 2)]
        public void Test1()
        {
            Exam e = new();
            Assert.Multiple(() =>
            {
                Assert.That(e.GetMostFrequent("mamaaa"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("gaga"), Is.EqualTo('g'));
                Assert.That(e.GetMostFrequent("agag"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("1231"), Is.EqualTo('3'));
            });
        }

        [Test]
        [PointsCalculator(3, 1)]
        public void Test2()
        {
            Exam e = new();
            Assert.Multiple(() =>
            {
                Assert.That(e.GetMostFrequent("mamaaa"), Is.EqualTo('a'));
                Assert.That(e.GetMostFrequent("gaga"), Is.EqualTo('g'));
                Assert.That(e.GetMostFrequent("12312312333456"), Is.EqualTo('3'));
            });
        }
    }
}
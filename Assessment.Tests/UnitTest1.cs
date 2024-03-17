using Assess.Services;

namespace Assessment.Tests
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Points",""10)]
        [Points(5)]
        public void GetMostFrequentCharTest()
        {
            Exam e = new();

            Assert.Equal('a', e.GetMostFrequent("mamaaa"));
            Assert.Equal('g', e.GetMostFrequent("gaga"));
            Assert.Equal('a', e.GetMostFrequent("agag"));
            Assert.Equal('3', e.GetMostFrequent("12312312333456"));

        }

        //private Mock<ITestPassed> SubstituteTestPassedMessage(string displayName, string traitName = null, string traitValue = null)
        //{
        //    var testPassedMessage = new Mock<ITestPassed>();
        //    var testCase = new Mock<ITestCase>();
        //    var testMethod = new Mock<IMethodInfo>();

        //    testCase.Setup(tc => tc.DisplayName).Returns(displayName);
        //    testPassedMessage.Setup(m => m.TestCase).Returns(testCase.Object);

        //    if (traitName != null && traitValue != null)
        //    {
        //        var traitAttribute = new TraitAttribute(traitName, traitValue);
        //        var traitAttributeInterface = traitAttribute as ITraitAttribute;
        //        IEnumerable<IAttributeInfo> attributes = new List<IAttributeInfo>();
        //        testMethod.Setup(m => m.GetCustomAttributes(typeof(TraitAttribute))).Returns(attributes);
        //    }

        //    return testPassedMessage;
        //}
    }
}
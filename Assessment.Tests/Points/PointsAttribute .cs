
namespace Assessment.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PointsAttribute : Attribute
    {
        public int Points { get; }

        public PointsAttribute(int points)
        {
            Points = points;
        }
    }
}


//public class PointCollector : LongLivedMarshalByRefObject, IMessageSinkMessage
//{
//    private readonly Dictionary<string, int> _pointsPerTest = new();

//    public PointCollector()
//    {
//    }

//    public Dictionary<string, int> PointsPerTest => _pointsPerTest;

//    public void OnMessage(IMessageSinkMessage message)
//    {
//        if (message is ITestPassed testPassed)
//        {
//            int points = CalculatePointsForTest(testPassed);
//            _pointsPerTest[testPassed.TestCase.DisplayName] = points;
//        }
//        // Handle other message types if needed
//    }


//    private static int CalculatePointsForTest(ITestPassed testPassed)
//    {
//        IMethodInfo testMethod = testPassed.TestCase.TestMethod.Method;
//        int defaultPoints = 0;

//        // Look for PointsAttribute on the test method
//        foreach (var attr in testMethod.GetCustomAttributes(typeof(TraitAttribute)))
//        {
//            if (attr.GetNamedArgument<string>("Name") == "Points")
//            {
//                if (int.TryParse(attr.GetNamedArgument<string>("Value"), out int points))
//                {
//                    return points;
//                }
//            }
//        }

//        return defaultPoints;
//    }
//}

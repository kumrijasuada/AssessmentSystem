using System.Reflection;

namespace Assessment.Tests.Points
{
    public class TestValidator
    {
        public static bool ValidatePoints(Type testClass)
        {
            var testMethods = testClass.GetMethods().Where(m => m.GetCustomAttributes(typeof(PointsAttribute), true).Any());

            int totalPoints = 0;
            foreach (var method in testMethods)
            {
                var pointsAttribute = method.GetCustomAttribute<PointsAttribute>();
                totalPoints += pointsAttribute.Points;
            }

            // Example validation criteria: Total points must be at least 10
            return totalPoints >= 10;
        }
    }

}

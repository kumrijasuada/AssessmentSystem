using System.Reflection;

namespace Assessment.Tests
{
    public static class TestValidatorUtility
    {
        public static bool ValidatePoints(Type testClassType)
        {
            var testMethods = testClassType.GetMethods().Where(m => m.GetCustomAttributes(typeof(PointsAttribute), true).Any());

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

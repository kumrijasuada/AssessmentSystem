using Assess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Tests
{
    [Order(9999)]
    public class FinalResult
    {

        [Test]
        public void Result()
        {
            var AssetSuccess = 0;
            var AssetFail = 0;
            foreach (var e in ExamResults.ExamResultList)
            {
                AssetFail += e.Result.Assertions.Count();
                AssetSuccess += e.AssertCount - e.Result.Assertions.Count();
            }
            Assert.Inconclusive($"Assert Success: {AssetSuccess},Assert Fail = {AssetFail}");
        }
    }
}

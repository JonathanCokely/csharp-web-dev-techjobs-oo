using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job astronaut = new Job();
            Job spaceman = new Job();
            Assert.AreNotEqual(astronaut.Id, spaceman.Id);

        }
    }
}

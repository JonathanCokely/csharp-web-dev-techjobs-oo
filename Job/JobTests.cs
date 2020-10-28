using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
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

        [TestMethod]
        public void TestConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job productTester = new Job("Product tester",employer,location,positionType,coreCompetency);
            Assert.IsTrue(productTester.Name=="Product tester"
                && productTester.EmployerName.ToString()=="ACME"
                && productTester.JobType.ToString()=="Quality control" 
                && productTester.JobCoreCompetency.ToString()=="Persistence" );

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job programmer = new Job("Programmer", employer, location, positionType, coreCompetency);
            Job developer = new Job("Programmer", employer, location, positionType, coreCompetency);
            //Job developer = programmer;
            Assert.IsFalse(programmer.Equals(developer));

        }

        [TestMethod]
        public void TestJobNameToString()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job programmer = new Job("Programmer", employer, location, positionType, coreCompetency);
            Assert.AreEqual(programmer.ToString(),
                $"\nID: {programmer.Id}\nName: {programmer.Name}\nEmployer: {programmer.EmployerName}\nLocation: {programmer.EmployerLocation}\nPosition Type: {programmer.JobType}\nCore Competency: {programmer.JobCoreCompetency}\n");
        }

        [TestMethod]
        public void TestJobDoesntExist()
        {
            Job emptyJob = new Job();
            Assert.IsTrue(emptyJob.ToString() == "OOPS! This job does not seem to exist.");
        }
    }
}

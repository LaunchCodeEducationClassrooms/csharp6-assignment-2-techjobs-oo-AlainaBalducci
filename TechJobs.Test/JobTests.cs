
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(1, job1.Id, 0.001);
            Assert.AreEqual(2, job2.Id, 0.001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(Environment.NewLine+"ID: 3"+ Environment.NewLine+"Name: Product tester"+Environment.NewLine+"Employer: ACME"+ Environment.NewLine+"Location: Desert"+ Environment.NewLine+"Position Type: Quality control"+ Environment.NewLine+"Core Competency: Persistence"+ Environment.NewLine, job3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job4 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(Environment.NewLine + "ID: " +job4.Id + Environment.NewLine + "Name: Data not available" + Environment.NewLine + "Employer: ACME" + Environment.NewLine + "Location: Desert" + Environment.NewLine + "Position Type: Quality control" + Environment.NewLine + "Core Competency: Persistence" + Environment.NewLine, job4.ToString());
        }
    }
}


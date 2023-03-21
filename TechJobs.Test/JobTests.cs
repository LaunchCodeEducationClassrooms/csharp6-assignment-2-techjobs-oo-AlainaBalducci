
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
            Assert.IsTrue(job3.ToString().EndsWith("\n"));
            Assert.IsTrue(job3.ToString().StartsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual("\nID: 3\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", job3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual("\nID: 1\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n", job3.ToString());
        }
    }
}


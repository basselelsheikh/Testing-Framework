
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using Testing_Framework.Assertions;
namespace Testing_Framework
{
    internal class TestCaseTest : TestCase
    {
        private WasRunTestCase test;

        public TestCaseTest(string name) : base(name)
        { }
        public override void SetUp()
        {

        }
        public void TestTemplateMethod()
        {
            test = new WasRunTestCase("TestMethod");
            test.run();
            Assert.AreEqual("SetUp TestMethod TearDown ", test.Log);
        }
        public void TestResult()
        {
            test = new WasRunTestCase("TestMethod");
            var result = test.run();
            Assert.AreEqual("1 Run, 0 Failed", result.GetSummary());
        }
        public void TestFailedResult()
        {
            test = new WasRunTestCase("TestBrokenMethod");
            var result = test.run();
            Assert.AreEqual("1 Run, 1 Failed", result.GetSummary());
        }
        public void TestFailedResultFormatting()
        {
            var result = new Result();
            result.IncrementNumberOfRuns();
            result.IncrementNumberOfFailedTests();
            Assert.AreEqual("1 Run, 1 Failed", result.GetSummary());
        }
    }
}

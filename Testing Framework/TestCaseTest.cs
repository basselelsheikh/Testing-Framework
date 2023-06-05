
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Testing_Framework
{
    internal class TestCaseTest : TestCase
    {
        private WasRunTestCase test;
        public void AssertTrue(bool temp)
        {
            if (temp) Console.WriteLine("PASS");
            else Console.WriteLine("FAIL");
        }
        public TestCaseTest(string name) : base(name)
        { }
        public override void SetUp()
        {
            test = new WasRunTestCase("TestMethod");
        }
        public void TestRunning()
        {
            var test = new WasRun("TestMethod");
            Console.WriteLine(test.wasRun);
            test.run();
            AssertTrue(test.WasRun);
        }
        public void TestSetUp()
        {
            var test = new WasRun("TestMethod");
            test.run();
        }
    }
}

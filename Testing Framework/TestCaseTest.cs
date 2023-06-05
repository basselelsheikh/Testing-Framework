
namespace Testing_Framework
{
    internal class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name)
        { }
        public void TestRunning()
        {
            var test = new WasRun("TestMethod");
            Console.WriteLine(test.wasRun);
            test.run();
            Console.WriteLine(test.wasRun);
        }
        public void TestSetUp()
        {
            var test = new WasRun("TestMethod");
            test.run();
            if (test.WasSetUp) Console.WriteLine("PASS");
            else Console.WriteLine("FAIL");
        }
    }
}

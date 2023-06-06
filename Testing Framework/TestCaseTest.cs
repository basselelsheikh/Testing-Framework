
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

    }
}

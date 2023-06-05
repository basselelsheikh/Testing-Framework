using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Framework
{
    internal class WasRunTestCase : TestCase
    {
        public bool WasRun;
        public bool WasSetUp;
       
        public WasRunTestCase(string name) : base(name)
        {
        }

        public void TestMethod()
        {
            WasRun = true;
        }
        public override void SetUp()
        {
            WasRun = false;
            WasSetUp = true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Framework
{
    internal class WasRun : TestCase
    {
        public bool wasRun;
        public bool WasSetUp;
       
        public WasRun(string name) : base(name)
        {
            wasRun = false;
        }

        public void TestMethod()
        {
            wasRun = true;
        }
        public override void SetUp()
        {
            WasSetUp = true;
        }

    }
}

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
        public string Log ="";
       
        public WasRunTestCase(string name) : base(name)
        {
        }

        public void TestMethod()
        {
            Log += "TestMethod ";
        }
        public void TestBrokenMethod()
        {
            throw new Exception();
        }
        public override void SetUp()
        {
            Log += "SetUp ";
        }
        public override void TearDown()
        {
            Log += "TearDown ";
        }

    }
}

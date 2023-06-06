using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Framework
{
    internal class TestCase
    {
        private string name;


        public TestCase(string name)
        {
            this.name = name;
        }
        public virtual void SetUp() { }
        public virtual void TearDown() { }
        public void run()
        {
            this.SetUp();
            this.GetType().GetMethod(name).Invoke(this, null);
            this.TearDown();
        }

    }
}

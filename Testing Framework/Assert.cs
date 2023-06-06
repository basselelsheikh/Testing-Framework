using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Framework.Assertions
{
    public static class Assert
    {
        public static void IsTrue(bool temp)
        {
            if (temp) Console.WriteLine("PASS");
            else Console.WriteLine("FAIL");
        }
        public static void AreEqual<T1, T2>(T1 par1, T2 par2)
        {
            switch (par1?.Equals(par2))
            {
                case true:
                    Console.WriteLine("PASS");
                    break;
                case false:
                    Console.WriteLine("FAIL");
                    Console.WriteLine("Expected: " + par1 + "\nActual: " + par2);
                    break;
            };
        }
    }
}

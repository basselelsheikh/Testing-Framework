using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Framework
{
    internal class Result
    {
        private int _numberOfRuns = 0;
        private int _numberOfFails = 0;
        public void IncrementNumberOfRuns()
        {
            _numberOfRuns++;
        }
        public void IncrementNumberOfFailedTests()
        {
            _numberOfFails++;
        }
        public string GetSummary()
        {
            return $"{_numberOfRuns} Run, {_numberOfFails} Failed";
        }

       
    }
}

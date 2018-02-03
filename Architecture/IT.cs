using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class IT : DepartmentBase
    {
        public int NumberOfComputers { get; set; }
        public int NumberOfCases { get; set; }
        public int Broke { get; set; }
        public int Fix { get; set; }

        public void ComputersBroken(int Broken)
        {
            Broke += Broken;
            
        }

        public void ComputersFixed(int Fixed)
        {
            Fix += Fixed;
            
        }

        public override double setBudget(double standardBudget)
        {
            //standardBudget = standardBudget + 10000.00;
            standardBudget += 1000.00;
            return base.setBudget(standardBudget);
        }

    }
}

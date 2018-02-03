using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class DepartmentBase
    {
        public string name { get; set; }
        public string supervisor { get; set; }
        public double Budget { get; private set; }

        public virtual void SetEmployeeCount (int Employees)
        {

            Console.WriteLine($"number of {Employees}");
        }

        public virtual double setBudget(double budget)
        {
            Budget = budget;
            return Budget;
        }
    }
  
}

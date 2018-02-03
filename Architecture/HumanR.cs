using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class HumanR : DepartmentBase
    {
        public string payroll { get; set; }
        public int numberOfOpenOccurances { get; set; }
        public int Hire { get; set; }
        public int Fire { get; set; }
        public int employees { get; set; }

        
        public void PeopleHired(int Hired)
        {
            Hire += Hired;
            
        }

        public void PeopleFired(int Fired)
        {
            Fire += Fired;
            
        }

        //override overrides default functionality from a base class
        public override void employeeCount(int Employees)
        {
            employees += Employees + 8;
        }
    }

    
}

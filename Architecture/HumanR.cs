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

        //override overrides default functionality from a base class
        public void PeopleHired(int Hired)
        {
            Hire += Hired;
            Console.WriteLine($"{Hire}");
        }

        public void PeopleFired(int Fired)
        {
            Fire += Fired;
            Console.WriteLine($"{Fire}");
        }
    }

    
}

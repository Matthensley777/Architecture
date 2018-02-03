using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Sales : DepartmentBase
    {
        public int makingPlan { get; set; }

        public void SalesPlan(int Plan)
        {
            makingPlan += Plan;
        }
    }


}

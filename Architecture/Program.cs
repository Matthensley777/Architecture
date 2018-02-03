using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Program
    {
        static void Main(string[] args)
        {

            var HumanResources = new HumanR
            {
                name = "humanResouces",
                supervisor = "John Doe",
                payroll = "behind",
                numberOfOpenOccurances = 89,
                Hire = 6,
                Fire = 4
            };

            var Marketing = new Marketing
            {
                name = "Marketing",
                supervisor = "Jane Doe",
                Budget = 1000,
                NumberOfAdCampaigns = 3
            };

            var IT = new IT
            {
                name = "IT",
                supervisor = "Boss",
                NumberOfComputers = 15,
                NumberOfCases = 5,
                Broke = 7,
                Fix = 1
            };

            var sales = new Sales
            {
                name = "Sales",
                supervisor = "Samwise",
                makingPlan = 1
            };

            var departments = new List<DepartmentBase>
            {
                Marketing,
                IT,
                HumanResources,
                sales,

            };

            foreach ( DepartmentBase department in departments )
            {
                if (department is HumanR humanResourcesDepartment)
                {
                    humanResourcesDepartment.PeopleHired(4);
                    humanResourcesDepartment.PeopleFired(6);
                }
                break;
            }

            foreach (DepartmentBase department in departments)
            {
                if (department is IT ITDepartment)
                {
                    ITDepartment.ComputersBroken(7);
                    ITDepartment.ComputersFixed(1);
                }
                break;
            }

            foreach (DepartmentBase department in departments)
            {
                if (department is Marketing MarketingDepartment)
                {
                    MarketingDepartment.MarketingBudget(700);
                    MarketingDepartment.Ads(3);
                }
                break;
            }

            foreach (DepartmentBase department in departments)
            {
                if (department is Sales SalesDepartment)
                {
                    SalesDepartment.SalesPlan(500000);
                }
                break;
            }

            foreach (DepartmentBase department in departments)
            {
                department.SetEmployeeCount(8);
            }


        }
    }
}

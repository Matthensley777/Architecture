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
                employeeCount = 6,
                numberOfOpenOccurances = 89,
                Hire = 6,
                Fire = 4
            };

            var Marketing = new Marketing
            {
                name = "Marketing",
                supervisor = "Jane Doe",
                employeeCount = 8,
                budget = 1000,
                numberOfAdCampaigns = 3
            };

            var IT = new IT
            {
                name = "IT",
                supervisor = "Boss",
                employeeCount = 1,
                NumberOfComputers = 15,
                NumberOfCases = 5
            };

            var sales = new Sales
            {
                name = "Sales",
                supervisor = "Samwise",
                employeeCount = 25,
                makingPlan = false
            };

            var departments = new List<DepartmentBase>
            {
                Marketing,
                IT,
                HumanResources,
                sales,

            };

            foreach ( department in departments )
            {
                department.PeopleHired(4);
                department.PeopleFired(6);
                break;
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Marketing : DepartmentBase
    {
        public int Budget { get; set; }
        public int NumberOfAdCampaigns { get; set; }

        public void MarketingBudget(int MarketingBudgets)
        {
            Budget += MarketingBudgets;

        }

        public void Ads ( int NumberOfAdds )
        {
            NumberOfAdCampaigns += NumberOfAdds;
        }
    }
}

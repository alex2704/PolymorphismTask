using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class PersonalMobileOperator : MobileOperator
    {
        public bool Pay { get; set; }
        public PersonalMobileOperator(string name, int minutecost, int coveragearea, bool pay) : base(name, minutecost, coveragearea)
        {
            Pay = pay;
        }
        public override void Cost()
        {
            Q = 100 * CoverageArea / MinuteCost;
            if (Pay)
            {
                this.Q = 0.7 * Q;
            }
            else
                this.Q = 1.5 * Q;
        }

    }
}

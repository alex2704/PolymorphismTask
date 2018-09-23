using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MobileOperator
    {
        public string Name { get; set; }
        public int MinuteCost { get; set; }
        public int CoverageArea { get; set; }
        public double Q { get; set; }
        public MobileOperator(string name, int minutecost, int coveragearea)
        {
            this.Name = name;
            this.MinuteCost = minutecost;
            this.CoverageArea = coveragearea;
        }
        public virtual void Cost()
        {
            Q = 100 * CoverageArea / MinuteCost;
        }
    }
}

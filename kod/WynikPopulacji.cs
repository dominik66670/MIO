using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class WynikPopulacji
    {
        public double FxMax { get; set; }
        public double FxAvg { get; set; }
        public double FxMin { get; set; }
        public int LP { get; set; }
        public WynikPopulacji() { }
        public WynikPopulacji(double fxMax, double fxAvg, double fxMin, int lp)
        {
            FxMax = fxMax;
            FxAvg = fxAvg;
            FxMin = fxMin;
            LP = lp;
        }
    }
}

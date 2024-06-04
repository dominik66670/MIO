using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class WielkiWynik
    {
        public int N { get; set; }
        public double Pk { get; set; }
        public double Pm { get; set; }
        public int T { get; set; }
        public double FxAvg { get; set; }
        public WielkiWynik() { }
        public WielkiWynik(int n, double pk, double pm, int t, double fxAvg)
        {
            N = n;
            Pk = pk;
            Pm = pm;
            T = t;
            FxAvg = fxAvg;
        }
    }
}

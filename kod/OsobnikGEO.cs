using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class OsobnikGEO
    {
        public double XReal { get; set; }
        public string XBin { get; set; }
        public double Fx { get; set; }
        public OsobnikGEO() { }
        public OsobnikGEO(double xReal, double l, int a, int b)
        {
            XReal = xReal;
            XBin = Przybornik.xIntToXBin(l,Przybornik.xRealToXInt(a,b,l,XReal));
            Fx = Przybornik.obliczFX(xReal);
        }
        public OsobnikGEO(string xbin, int a, int b, double L, int precyzja)
        {
            XBin = xbin;
            XReal = Przybornik.xIntToXReal(Przybornik.xBinToXInt(XBin),a,b,L,precyzja);
            Fx = Przybornik.obliczFX(XReal);
        }
        public override string ToString()
        {
            return "XReal = "+XReal+" XBin = "+XBin+" F(x) = "+Fx;
        }
    }
}

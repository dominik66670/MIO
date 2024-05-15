using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class Osobnik : IComparable<Osobnik>
    {
        public double XReal { get; set; }
        public double XInt { get; set; }
        public string XBin { get; set; }
        public double XIntCalculated { get; set; }
        public double XRealCalculated { get; set; }
        public double Fx { get; set; }
        public double Gx { get; set; }
        public double P { get; set; }
        public double Q { get; set; }
        public double R { get; set; }
        public Osobnik Xn { get; set; }
        public Osobnik(double xReal, double l, int a,int b, int precision)
        {
            XReal = xReal;
            XInt = xRealToXInt(a,b,l);
            XBin = xIntToXBin(l);
            //XIntCalculated = xBinToXInt();
            //XRealCalculated = xIntToXReal(a,b,l,precision);
            Fx = obliczFX();
        }
        private double obliczFX()
        {
            return mantysa(XReal) * ((Math.Cos(20 * Math.PI * XReal) - Math.Sin(XReal)));
        }
        // przekształca i zaaokrągla xint do xreal
        private double xIntToXReal(int a, int b, double l, int precision)
        {
            return Math.Round((((b - a) * XIntCalculated) / (Math.Pow(2, l) - 1)) + a,precision);
        }
        // przekształca xbin do xint
        private double xBinToXInt()
        {
            return Convert.ToInt32(XBin, 2);
        }
        // zwraca postać binarną z uzupełnieniem do l
        private string xIntToXBin(double l)
        {
            string xbin = Convert.ToString((long)XInt, 2);
            while (xbin.Length < l)
            {
                xbin = "0" + xbin;
            }
            return xbin;
        }
        //Zwraca zaaokrąglone xint
        private double xRealToXInt(int a, int b, double l)
        {
            return Math.Round(1.0 / (b - a) * (XReal - a) * (Math.Pow(2, l) - 1));
        }
        public override string ToString()
        {
            return $"{XReal} {XInt} {XBin} {XIntCalculated} {XRealCalculated}";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return this.GetHashCode()==obj.GetHashCode();
        }

        public int CompareTo(Osobnik? other)
        {
            if (other.XReal > this.XReal)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        private double mantysa(double x)
        {
            return x - Math.Floor(x);
        }
    }
}

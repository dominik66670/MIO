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
        public Osobnik(double xReal, double l, int a,int b, int precision)
        {
            XReal = xReal;
            XInt = (1.0/(b-a)*(XReal-a) * (Math.Pow(2, l) - 1));
            XInt = Math.Round(XInt);
            //XBin = Convert.ToString(BitConverter.DoubleToInt64Bits(XInt), 2);
            XBin = Convert.ToString((long)XInt, 2);
            while (XBin.Length<l) 
            {
                XBin = "0" + XBin;
            }
            //XIntCalculated = BitConverter.Int64BitsToDouble(Convert.ToInt64(XBin, 2));
            XIntCalculated = Convert.ToInt32(XBin, 2);
            XIntCalculated = Math.Round(XIntCalculated);
            XRealCalculated = (((b-a) * XIntCalculated) / (Math.Pow(2, l) - 1)) + a;
            XRealCalculated = Math.Round(XRealCalculated,precision);
            Fx = mantysa(XReal) * ((Math.Cos(20 * Math.PI * XReal) - Math.Sin(XReal)));
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

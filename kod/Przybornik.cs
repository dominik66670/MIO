using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace kod
{
    public static class Przybornik
    {
        public static List<Osobnik> DystrybuantaPopulacji(List<Osobnik> osobniki)
        {
            osobniki[0].Q = osobniki[0].P;
            for (int i = 1; i < osobniki.Count; i++)
            {
                osobniki[i].Q= osobniki[i].P+osobniki[i-1].Q;
            }
            return osobniki;
        }
        // obliczanie Pi dla populacji
        public static List<Osobnik> ObliczPiPopulacji(List<Osobnik> osobniki)
        {
            double gxsum = osobniki.Sum(osobnik => osobnik.Gx);
            osobniki.ForEach(osobnik => osobnik.P = _obliczPiOsobnika(osobnik,gxsum));
            return osobniki;
        }
        // obliczanie P dla osobika
        private static double _obliczPiOsobnika(Osobnik osobnik, double gxsum)
        {
            return osobnik.Gx/gxsum;
        }
        public static List<double> Generuj(int a, int b, int precyzja, int N)
        {
            List<double> osobniki = new List<double>();
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                
                osobniki.Add(Math.Round((a + (random.NextDouble() * (b - a))), precyzja));
            }
            return osobniki;
        }
        public static double ObliczL(int a, int b,double d)
        {
            double x = Math.Log2((b - a) * Math.Pow(10.0, d));
            return Math.Ceiling(x);
        }
        // wyliczenie gx dla całej populacji
        public static List<Osobnik> ObliczGxPopulacji(List<Osobnik> osobniki,double D)
        {
            double fxmax = osobniki.Min(x => x.Fx);
            osobniki.ForEach(x => x.Gx=_obliczGxOsobnika(x,fxmax,D));
            return osobniki;
        }
        // obliczenie gx dal osobnika
        private static double _obliczGxOsobnika(Osobnik osobnik,double fxmax,double D)
        {
            return osobnik.Fx - fxmax + D;
        }
    }
}

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
    }
}

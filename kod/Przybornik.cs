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
        public static List<Osobnik> RobienieDzieci(List<Osobnik> osobniki)
        {
            int ileRodzicow = osobniki.FindAll(o => o.CzyRodzic != "-").Count;
            if (ileRodzicow % 2 == 0)
            {
                foreach (var osobnik in osobniki)
                {
                    if (osobnik.CzyRodzic == "-")
                    {
                        osobnik.PopulacjaPoKrzyzowaniu = osobnik.XnBin;
                        osobnik.Dziecko = "-";
                    }

                }
            }
            
            return osobniki;
        }
        // wybiera które osobniki zostaną rodzicami
        public static List<Osobnik> DecyzjaODziecku(List<Osobnik> osobniki,double Pk)
        {
            Random rnd = new Random();
            foreach (var osobnik in osobniki)
            {
                if (rnd.NextDouble()<Pk)
                {
                    osobnik.CzyRodzic = osobnik.XnBin;
                }
                else
                {
                    osobnik.CzyRodzic = "-";
                }
            }
            return osobniki;
        }
        // Przlicza Xn to XnBin dla całej populacji
        public static List<Osobnik> XnToXnBin(List<Osobnik> osobniki, int a, int b, double l)
        {
            osobniki.ForEach(o => o.XnBin = Przybornik.przeliczNaBin(Przybornik.przeliczNaXInt(o.Xn,a,b,l), l));
            return osobniki;
        }
        private static double przeliczNaXInt(double XReal, int a, int b, double l)
        {
            return Math.Round(1.0 / (b - a) * (XReal - a) * (Math.Pow(2, l) - 1));
        }
        private static string przeliczNaBin(double XInt, double l)
        {
            string xbin = Convert.ToString((long)XInt, 2);
            while (xbin.Length < l)
            {
                xbin = "0" + xbin;
            }
            return xbin;
        } 
        // Metoda agregująca elementy selekcji osobników
        public static List<Osobnik> KrecimyRuletka(List<Osobnik> _osobniki,double D)
        {
            // wyliczenie gx dla całej populacji
            _osobniki = ObliczGxPopulacji(_osobniki, D);
            // wyliczanie Pi dla populacji
            _osobniki = ObliczPiPopulacji(_osobniki);
            // wyliczanie Q dla populacji
            _osobniki = DystrybuantaPopulacji(_osobniki);
            // losowanie R dla populacji
            _osobniki = LosowanieRDlaPopulacji(_osobniki);
            // Selekcja osobników
            _osobniki = SelekcjaOsobnikow(_osobniki);
            return _osobniki;
        }
        // Selekcja populacji
        public static List<Osobnik> SelekcjaOsobnikow(List<Osobnik> osobnicy)
        {
            for (int i = 0; i < osobnicy.Count;i++)
            {
                for(int j = 0; j < osobnicy.Count; j++)
                {
                    if (osobnicy[i].R <= osobnicy[j].Q)
                    {
                        osobnicy[i].Xn = osobnicy[j].XReal;
                        break;
                    }
                    else
                    {
                        osobnicy[i].Xn = osobnicy[osobnicy.Count - 1].XReal;
                    }
                }
            }
            return osobnicy;
        }
        public static List<Osobnik> LosowanieRDlaPopulacji(List<Osobnik> osobnicy)
        {
            Random rnd = new Random();
            osobnicy.ForEach(osobnik => osobnik.R = _losowanieRDlaOsobnika(rnd));
            return osobnicy;
        }
        private static double _losowanieRDlaOsobnika(Random random) 
        {
            return random.NextDouble();
        }
        // dustrybuanta dla populacji
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace kod
{
    public static class Przybornik
    {
        // zwraca losowego osobnika GEO
        public static OsobnikGEO GenerujGEO(int a, int b, int precyzja, double L)
        {
            Random random = new Random();
            return new OsobnikGEO(Math.Round((a + (random.NextDouble() * (b - a))), precyzja),L,a,b);
        }
        // zwraca średnie przystosowanie populacji po T pokoleniech
        public static double Testy(int N, double Pk, double Pm, int T)
        {
            int a = -4;
            int b = 12;
            int precyzja = 3;
            double D = 0.001;
            List<Osobnik> _osobniki = new List<Osobnik>();
            var L = Przybornik.ObliczL(a, b, precyzja);
            _osobniki.Clear();
            // Losowanie liczb z zadanego zakresu ze wskazaną precyzją
            Przybornik.Generuj(a, b, precyzja, N).ForEach(x =>
            {
                _osobniki.Add(new Osobnik(x, L, a, b, precyzja));
            });
            // selekcja populacji
            _osobniki = Przybornik.KrecimyRuletka(_osobniki, D);
            _osobniki = Przybornik.XnToXnBin(_osobniki, a, b, L);
            _osobniki = Przybornik.DecyzjaODziecku(_osobniki, Pk);
            _osobniki = Przybornik.RobienieDzieci(_osobniki, L);
            _osobniki = Przybornik.Mutacje(_osobniki, Pm);
            _osobniki = Przybornik.KonwersjaXBinXRealDlaKoncowejPopulacjiIOcena(_osobniki, a, b, L, precyzja);
            List<Osobnik> nowePokolenie = new List<Osobnik>();
            for (int i = 1; i < T; i++)
            {
                nowePokolenie = new List<Osobnik>();
                _osobniki.ForEach(o => nowePokolenie.Add(new Osobnik(o.XRealKoncowy, L, a, b, precyzja)));
                _osobniki = nowePokolenie;
                _osobniki = Przybornik.KrecimyRuletka(_osobniki, D);
                _osobniki = Przybornik.XnToXnBin(_osobniki, a, b, L);
                _osobniki = Przybornik.DecyzjaODziecku(_osobniki, Pk);
                _osobniki = Przybornik.RobienieDzieci(_osobniki, L);
                _osobniki = Przybornik.Mutacje(_osobniki, Pm);
                _osobniki = Przybornik.KonwersjaXBinXRealDlaKoncowejPopulacjiIOcena(_osobniki, a, b, L, precyzja);
            }
            return _osobniki.Average(o => o.Fx);
        }
        public static List<Osobnik> KonwersjaXBinXRealDlaKoncowejPopulacjiIOcena(List<Osobnik> osobniki, int a, int b, double l, int precision)
        {
            // konwersja do xReal
            osobniki.ForEach(o => o.XRealKoncowy = Przybornik.xIntToXReal(Przybornik.xBinToXInt(o.OsobnikPoMutacji),a, b, l, precision));
            //Funkcja Oceny
            osobniki.ForEach(o => o.FxKoncowy = Przybornik.obliczFX(o.XRealKoncowy));

            return osobniki;
        }
        public static List<Osobnik> Mutacje(List<Osobnik> osobniki, double Pm)
        {
            Random rng = new Random();
            foreach (Osobnik osobnik in osobniki)
            {
                osobnik.MutowaneElementy = "";
                // pierwsze porównanie jest z orginalnym genomem
                var orginalnyGenom = osobnik.PopulacjaPoKrzyzowaniu.ToCharArray();
                for (int i = 0; i < osobnik.PopulacjaPoKrzyzowaniu.Length; i++)
                {
                    // sprawdzanie czy mutacja zaistniała
                    if (rng.NextDouble()<Pm)
                    {

                        //sprawdzanie w jaki sposób zmienić element pierwsze porównanie jest z orginalnym genomem
                        if (orginalnyGenom[i] =='1')
                        {
                            orginalnyGenom[i] = '0';
                            osobnik.OsobnikPoMutacji = new string(orginalnyGenom);
                            osobnik.MutowaneElementy += ""+i+",";

                        }
                        else
                        {
                            orginalnyGenom[i] = '1';
                            osobnik.OsobnikPoMutacji = new string(orginalnyGenom);
                            osobnik.MutowaneElementy += "" + i + ",";
                        }
                        // kolejne już ze zmutowanym
                        orginalnyGenom = osobnik.OsobnikPoMutacji.ToCharArray();
                    }
                }
                // przy braku mutacji daje informację zwrotną
                if (osobnik.MutowaneElementy=="")
                {
                    osobnik.MutowaneElementy = "Nie mutował";
                    osobnik.OsobnikPoMutacji = osobnik.PopulacjaPoKrzyzowaniu;
                }
            }
            return osobniki;
        }
        public static List<Osobnik> RobienieDzieci(List<Osobnik> osobniki, double L)
        {
            // L to długość genomu
            // pobranie ilości osobników chętnych do rozmnażania
            int ileRodzicow = osobniki.FindAll(o => o.CzyRodzic != "-").Count;
            // przeniesienie osobników nie rozmnażających się do następnego kroku
            foreach (var osobnik in osobniki)
            {
                if (osobnik.CzyRodzic == "-")
                {
                    osobnik.PopulacjaPoKrzyzowaniu = osobnik.XnBin;
                    osobnik.Dziecko = "-";
                }

            }
            // Wyrównanie populacji jeśli nie parzysta
            if (ileRodzicow % 2 == 1)
            {
                var samotnik = osobniki.Where(o => o.CzyRodzic != "-").Last();
                samotnik.Dziecko = "-";
                samotnik.PopulacjaPoKrzyzowaniu=samotnik.XnBin;
                ileRodzicow--;
            }
            Random random = new Random();
            // osobni są brane parami i mają wspólny punkt przecięcia
            while (ileRodzicow>0)
            {
                int punktP = random.Next(1,(int)L);
                Osobnik rodzicA = osobniki.FindAll(o => o.CzyRodzic != "-" && o.Dziecko=="").First();
                Osobnik rodzicB = osobniki.FindAll(o => o.CzyRodzic != "-" && o.Dziecko == "").Skip(1).First();
                rodzicA.Pc = punktP;
                rodzicB.Pc = punktP;
                List<string> dzieci = krzyzowania(rodzicA, rodzicB);
                rodzicA.Dziecko = dzieci.First();
                rodzicA.PopulacjaPoKrzyzowaniu = dzieci.First();
                rodzicB.Dziecko = dzieci.Last();
                rodzicB.PopulacjaPoKrzyzowaniu = dzieci.Last();
                ileRodzicow -=2;
            }


            return osobniki;
        }
        // robienie dzieci z osobników
        private static List<string> krzyzowania(Osobnik rodzicA,Osobnik rodzicB)
        {
            List<string> dzieci = new List<string>();
            dzieci.Add(rodzicA.CzyRodzic.Substring(0,rodzicA.Pc)+ rodzicB.CzyRodzic.Substring(rodzicA.Pc));
            dzieci.Add(rodzicB.CzyRodzic.Substring(0, rodzicA.Pc) + rodzicA.CzyRodzic.Substring(rodzicA.Pc));
            return dzieci;
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
        private static double mantysa(double x)
        {
            return x - Math.Floor(x);
        }
        public static int xBinToXInt(string XBin)
        {
            return Convert.ToInt32(XBin, 2);
        }
        public static double xIntToXReal(int XInt,int a, int b, double l, int precision)
        {
            return Math.Round((((b - a) * XInt) / (Math.Pow(2, l) - 1)) + a, precision);
        }
        public static double obliczFX(double XReal)
        {
            return mantysa(XReal) * ((Math.Cos(20 * Math.PI * XReal) - Math.Sin(XReal)));
        }
        public static string xIntToXBin(double l,int XInt)
        {
            string xbin = Convert.ToString((long)XInt, 2);
            while (xbin.Length < l)
            {
                xbin = "0" + xbin;
            }
            return xbin;
        }
        public static int xRealToXInt(int a, int b, double l,double XReal)
        {
            return (int)Math.Round(1.0 / (b - a) * (XReal - a) * (Math.Pow(2, l) - 1));
        }
    }
}

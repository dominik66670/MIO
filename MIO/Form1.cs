using kod;
using ScottPlot;
using System.CodeDom;
using System.Xml.Linq;
namespace MIO
{
    public partial class Form1 : Form
    {
        private List<Osobnik> _osobniki = new List<Osobnik>();
        private List<WielkiWynik> _wielkieWyniki = new List<WielkiWynik>();

        public Form1()
        {
            InitializeComponent();
            osobnikBindingSource.DataSource = _osobniki;
            wielkiWynikBindingSource.DataSource = _wielkieWyniki;
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int T = Convert.ToInt32(textBoxT.Text);
                double D;
                double Pk;
                double Pm;
                int precyzja = 0;
                formsPlotWyniki.Reset();
                List<WynikPopulacji> wynikiPopulacji = new List<WynikPopulacji>();
                // sprawdzanie czy w precyzji jest liczba rzeczywista
                if (!textBoxPrecyzja.Text.Contains(",") && !textBoxPrecyzja.Text.Contains(".")) { throw new NotANumberException(); }
                // obs³uga , i .
                try
                {
                    precyzja = textBoxPrecyzja.Text.Split(',')[1].Length;
                    D = Convert.ToDouble(textBoxPrecyzja.Text);

                }
                catch (Exception)
                {
                    precyzja = textBoxPrecyzja.Text.Split('.')[1].Length;
                    D = Convert.ToDouble(textBoxPrecyzja.Text.Replace('.', ','));

                }
                try
                {
                    Pk = Convert.ToDouble(texBoxPk.Text);
                    Pm = Convert.ToDouble(textBoxPm.Text);
                }
                catch (Exception)
                {
                    Pk = Convert.ToDouble(texBoxPk.Text.Replace('.', ','));
                    Pm = Convert.ToDouble(textBoxPm.Text.Replace('.', ','));
                }
                // sprawdzanie poprwaniœci zakresu
                if (a >= b) { throw new RangeError("Podano niew³aœciwy zakres"); }
                // sprawdzanie czy N jest ujemne
                if (N <= 0) { throw new RangeError("Licznoœæ populacji (N) nie mo¿e byæ ujemne lub równe 0"); }
                // obliczanie L
                var L = Przybornik.ObliczL(a, b, precyzja);
                _osobniki.Clear();
                osobnikBindingSource.Clear();
                // Losowanie liczb z zadanego zakresu ze wskazan¹ precyzj¹
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
                wynikiPopulacji.Add(new WynikPopulacji(_osobniki.Max(o => o.Fx), _osobniki.Average(o => o.Fx), _osobniki.Min(O => O.Fx), 0));
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
                    wynikiPopulacji.Add(new WynikPopulacji(_osobniki.Max(o => o.Fx), _osobniki.Average(o => o.Fx), _osobniki.Min(O => O.Fx), i));
                }
                var fMax = formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxMax).ToArray());
                fMax.LegendText = "F(x) Max";
                var fAvg = formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxAvg).ToArray());
                fAvg.LegendText = "F(x) Avg";
                var fMin = formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxMin).ToArray());
                fMin.LegendText = "F(x) Min";
                formsPlotWyniki.Refresh();
                formsPlotWyniki.Plot.ShowLegend();
                //formsPlotWyniki.Plot.Axes.Title.Label.Text ="Wyniki poszczególnych populacji dla plrametrów N = "+N+" Pk = "+Pk+" Pm = "+Pm+" T = "+T;

                osobnikBindingSource.ResetBindings(false);
                osobnikBindingSource.DataSource = _osobniki;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d");
            }
        }

        private void buttonWielkieTesty_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            _wielkieWyniki.Clear();
            int iteracje = 10;
            progressBar1.Maximum = iteracje * 10 * 17 * 20 * 10;
            for (int N = 30; N < 80; N+=5)
            {
                for (int Pk = 5; Pk < 90; Pk+=5)
                {
                    for (int Pm = 1; Pm < 100; Pm+=5)
                    {
                        for (int T = 50; T < 150; T+=10)
                        {
                            List<double> wyniki = new List<double>();
                            Console.WriteLine("N = " + N + " Pk = " + Pk * 0.01 + " Pm = " + Pm * 0.0001 + " T = " + T);
                            for (int i = 0; i < iteracje; i++)
                            {
                                wyniki.Add(Przybornik.Testy(N,Pk*0.01,Pm*0.001,T));
                                progressBar1.Value+=1;
                            }
                            _wielkieWyniki.Add(new WielkiWynik(N, Pk * 0.01, Pm * 0.001,T,wyniki.Average()));

                        }
                    }
                }
            }
            _wielkieWyniki = _wielkieWyniki.OrderByDescending(x => x.FxAvg).ToList();
            new XElement("Wyniki",
                _wielkieWyniki.Select(w =>
                    new XElement("Wynik",
                    new XElement("N", w.N),
                    new XElement("Pk", w.Pk),
                    new XElement("Pm", w.Pm),
                    new XElement("T", w.T),
                    new XElement("FxAvg", w.FxAvg)
                    ))
                ).Save("Wyniki.xml");
            wielkiWynikBindingSource.ResetBindings(false);
            wielkiWynikBindingSource.DataSource = _wielkieWyniki;
        }
    }
}

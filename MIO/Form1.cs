using kod;
using System.CodeDom;
namespace MIO
{
    public partial class Form1 : Form
    {
        private List<Osobnik> _osobniki = new List<Osobnik>();

        public Form1()
        {
            InitializeComponent();
            osobnikBindingSource.DataSource = _osobniki;
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
                catch(Exception)
                {
                    precyzja = textBoxPrecyzja.Text.Split('.')[1].Length;
                    D = Convert.ToDouble(textBoxPrecyzja.Text.Replace('.',','));
                    
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
                if (a >= b) {throw new RangeError("Podano niew³aœciwy zakres");}
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
                _osobniki = Przybornik.KrecimyRuletka(_osobniki,D);
                _osobniki = Przybornik.XnToXnBin(_osobniki,a,b,L);
                _osobniki = Przybornik.DecyzjaODziecku(_osobniki, Pk);
                _osobniki = Przybornik.RobienieDzieci(_osobniki,L);
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
                //ScottPlot.Plot myPlot = new (400, 300);
                formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxMax).ToArray());
                formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxAvg).ToArray());
                formsPlotWyniki.Plot.Add.Scatter(Enumerable.Range(0, T).ToArray(), wynikiPopulacji.Select(o => o.FxMin).ToArray());
                formsPlotWyniki.Refresh();
                osobnikBindingSource.ResetBindings(false);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d");
            }
        }
    }
}

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
                double D;
                int precyzja = 0;
                // sprawdzanie czy w precyzji jest liczba rzeczywista
                if (!textBoxPrecyzja.Text.Contains(",") && !textBoxPrecyzja.Text.Contains(".")) { throw new NotANumberException(); }
                // obs�uga , i .
                try
                {
                    precyzja = textBoxPrecyzja.Text.Split(',')[1].Length;
                    D = Convert.ToDouble(textBoxPrecyzja.Text);
                }catch(Exception)
                {
                    precyzja = textBoxPrecyzja.Text.Split('.')[1].Length;
                    D = Convert.ToDouble(textBoxPrecyzja.Text.Replace('.',','));
                }
                // sprawdzanie poprwani�ci zakresu
                if (a >= b) {throw new RangeError("Podano niew�a�ciwy zakres");}
                // sprawdzanie czy N jest ujemne
                if (N <= 0) { throw new RangeError("Liczno�� populacji (N) nie mo�e by� ujemne lub r�wne 0"); }
                // obliczanie L
                var L = Przybornik.ObliczL(a, b, precyzja);
                _osobniki.Clear();
                osobnikBindingSource.Clear();
                // Losowanie liczb z zadanego zakresu ze wskazan� precyzj�
                Przybornik.Generuj(a, b, precyzja, N).ForEach(x =>
                {
                    _osobniki.Add(new Osobnik(x, L, a, b, precyzja));
                });
                // wyliczenie gx dla ca�ej populacji
                _osobniki = Przybornik.ObliczGxPopulacji(_osobniki, D);
                // wyliczanie Pi dla populacji
                _osobniki = Przybornik.ObliczPiPopulacji(_osobniki);
                // wyliczanie Q dla populacji
                _osobniki = Przybornik.DystrybuantaPopulacji(_osobniki);
                // losowanie R dla populacji
                _osobniki = Przybornik.LosowanieRDlaPopulacji(_osobniki);
                // to do poprawy
                _osobniki = Przybornik.SelekcjaOsobnikow(_osobniki);
                osobnikBindingSource.ResetBindings(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B��d");
            }
        }
    }
}

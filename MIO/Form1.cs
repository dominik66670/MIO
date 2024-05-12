using kod;
using System.CodeDom;
namespace MIO
{
    public partial class Form1 : Form
    {
        List<Osobnik> _osobniki = new List<Osobnik>();

        public Form1()
        {
            InitializeComponent();
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
                // Losowanie liczb z zadanego zakresu ze wskazan� precyzj�
                //string wygenerowane = "";
                //Przybornik.Generuj(a, b, precyzja, N).ForEach(x => { wygenerowane += " " + x.ToString(); });
                // obliczanie zakresu
                var L = Przybornik.ObliczL(a, b, precyzja);
                MessageBox.Show(L.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B��d");
            }
        }
    }
}

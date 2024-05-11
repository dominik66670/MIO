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
                double N = Convert.ToInt32(textBoxN.Text);
                int precyzja = 0;
                // sprawdzanie czy w precyzji jest liczba rzeczywista
                if (!textBoxPrecyzja.Text.Contains(",") && !textBoxPrecyzja.Text.Contains(".")) { throw new NotANumberException(); }
                // obs�uga , i .
                try
                {
                    precyzja = textBoxPrecyzja.Text.Split(',')[1].Length;
                }catch(Exception)
                {
                    precyzja = textBoxPrecyzja.Text.Split('.')[1].Length;
                }
                // sprawdzanie poprwani�ci zakresu
                if (a >= b) {throw new RangeError("Podano niew�a�ciwy zakres");}
                // sprawdzanie czy N jest ujemne
                if (N <= 0) { throw new RangeError("Liczno�� populacji (N) nie mo�e by� ujemne lub r�wne 0"); }
                MessageBox.Show(precyzja.ToString());
                // TO DO Pracowa� na losowaniem liczb

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B��d");
            }
        }
    }
}

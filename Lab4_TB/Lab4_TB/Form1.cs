using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_TB
{
    public partial class Form1 : Form
    {
        List<Nukleobaza> listaNukleobaza;
        public Form1()
        {
            InitializeComponent();
            listaNukleobaza = new List<Nukleobaza>();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            char prvi, drugi, treci, cetvrti;

            prvi = char.Parse(textBoxPrvi.Text);
            drugi = char.Parse(textBoxDrugi.Text);
            treci = char.Parse(textBoxTreci.Text);
            cetvrti = char.Parse(textBoxCetvrti.Text);

            Nukleobaza novaNukleobaza = new Nukleobaza(prvi,drugi,treci,cetvrti);

            listaNukleobaza.Add(novaNukleobaza);

            textBoxRezultat.Clear();

            foreach (var clan in listaNukleobaza)
            {
                    if (clan.Prvi == 'A')
                    {
                        textBoxRezultat.Text += clan.Prvi + " - " + "T" + Environment.NewLine;
                    }
                    if (clan.Prvi == 'T')
                    {
                        textBoxRezultat.Text += clan.Prvi + " - " + "A" + Environment.NewLine;
                    }
                    if (clan.Prvi == 'C')
                    {
                        textBoxRezultat.Text += clan.Prvi + " - " + "G" + Environment.NewLine;
                    }
                    if (clan.Prvi == 'G')
                    {
                        textBoxRezultat.Text += clan.Prvi + " - " + "C" + Environment.NewLine;
                    }
                    if (clan.Drugi == 'A')
                    {
                        textBoxRezultat.Text += clan.Drugi + " - " + "T" + Environment.NewLine;
                    }
                    if (clan.Drugi == 'T')
                    {
                        textBoxRezultat.Text += clan.Drugi + " - " + "A" + Environment.NewLine;
                    }
                    if (clan.Drugi == 'C')
                    {
                        textBoxRezultat.Text += clan.Drugi + " - " + "G" + Environment.NewLine;
                    }
                    if (clan.Drugi == 'G')
                    {
                        textBoxRezultat.Text += clan.Drugi + " - " + "C" + Environment.NewLine;
                    }
                    if (clan.Treci == 'A')
                    {
                        textBoxRezultat.Text += clan.Treci + " - " + "T" + Environment.NewLine;
                    }
                    if (clan.Treci == 'T')
                    {
                        textBoxRezultat.Text += clan.Treci + " - " + "A" + Environment.NewLine;
                    }
                    if (clan.Treci == 'C')
                    {
                        textBoxRezultat.Text += clan.Treci + " - " + "G" + Environment.NewLine;
                    }
                    if (clan.Treci == 'G')
                    {
                        textBoxRezultat.Text += clan.Treci + " - " + "C" + Environment.NewLine;
                    }
                    if (clan.Cetvrti == 'A')
                    {
                        textBoxRezultat.Text += clan.Cetvrti + " - " + "T" + Environment.NewLine;
                    }
                    if (clan.Cetvrti == 'T')
                    {
                        textBoxRezultat.Text += clan.Cetvrti + " - " + "A" + Environment.NewLine;
                    }
                    if (clan.Cetvrti == 'C')
                    {
                        textBoxRezultat.Text += clan.Cetvrti + " - " + "G" + Environment.NewLine;
                    }
                 if (clan.Cetvrti == 'G')
                {
                    textBoxRezultat.Text += clan.Cetvrti + " - " + "C" + Environment.NewLine;
                }
                
            }
        }
    }
}

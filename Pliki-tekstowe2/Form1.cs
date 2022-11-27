using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pliki_tekstowe2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imie = textBox2.Text;
            var nazwisko = textBox3.Text;
            var klasa = textBox4.Text;

            if (imie == "" || nazwisko == "" || klasa == "")
            {
                MessageBox.Show("Pola nie moga byc puste");
            }
            else
            {
                StreamReader odczyt = new StreamReader(@"C:\Users\tyszk\Desktop\Pliki-tekstowe-17.10-master\Pliki tekstowe 17.10\uczen.txt", true);
                int liczba = 0;
                string linia;
                string id_ucznia = "";
                while ((linia = odczyt.ReadLine()) != null)
                {
                    liczba++;
                }
                if (liczba >= 100)
                {
                    id_ucznia += liczba.ToString();
                }
                else if (liczba >= 10)
                {
                    id_ucznia += "0" + liczba.ToString();
                }
                else
                {
                    id_ucznia += "00" + liczba.ToString();
                }
                odczyt.Close();
                StreamWriter fs = new StreamWriter(@"C:\Users\tyszk\Desktop\Pliki-tekstowe-17.10-master\Pliki tekstowe 17.10\uczen.txt", true);
                string do_dopisania = $"{id_ucznia};{imie};{nazwisko};{klasa}";
                fs.Write(Environment.NewLine + do_dopisania);
                fs.Close();
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[][] tablica;
            StreamReader fs = new StreamReader(@"C:\Users\tyszk\Desktop\Pliki-tekstowe-17.10-master\Pliki tekstowe 17.10\uczen.txt", true);
            string linia;

            List<string[]> lista = new List<string[]>();
            while ((linia = fs.ReadLine()) != null)
            {
                string[] tablica2 = linia.Split(';');
                lista.Add(tablica2);
            }
            tablica = lista.ToArray();
            fs.Close();
            int i;
            if (comboBox1.Text == "Imie")
            {
                i = 1;
            }
            else if (comboBox1.Text == "Nazwisko")
            {
                i = 2;
            }
            else
            {
                i = 3;
            }
            string wyniki = "";
            if (comboBox2.Text == "jest równe")
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i] == textBox1.Text)
                    {
                        wyniki += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            else if (comboBox2.Text == "rozpoczyna sie od")
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i].StartsWith(textBox1.Text))
                    {
                        wyniki += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            else
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i].Contains(textBox1.Text))
                    {
                        wyniki += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            textBox5.Text = wyniki;
        }
    }
    }


using Pliki_tekstowe2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pliki_tekstowe_17._10
{
    public partial class Form1 : Form
    {
        public string kod_z_obrazka = "";
        public Image pic1 = Image.FromFile(@"C:\\Users\\student\\Desktop\\1.png");
        public Image pic2 = Image.FromFile(@"C:\\Users\\student\\Desktop\\2.png");
        public Image pic3 = Image.FromFile(@"C:\\Users\\student\\Desktop\\3.png");
        public Image pic4 = Image.FromFile(@"C:\\Users\\student\\Desktop\\4.png");
        public Image pic5 = Image.FromFile(@"C:\\Users\\student\\Desktop\\5.png");
        public Image pic6 = Image.FromFile(@"C:\\Users\\student\\Desktop\\6.png");
        public Form1()
        {
            InitializeComponent();


        }
        public void Picture_generator()
        {
            Random random_number_gen = new Random();
            int random_number = random_number_gen.Next(1, 7);

            switch (random_number)
            {
                case 1:
                    pictureBox1.Image = pic1;
                    kod_z_obrazka = "unxyxw";
                    break;
                case 2:
                    pictureBox1.Image = pic2;
                    kod_z_obrazka = "b5nmm";
                    break;
                case 3:
                    pictureBox1.Image = pic3;
                    kod_z_obrazka = "74853";
                    break;
                case 4:
                    pictureBox1.Image = pic4;
                    kod_z_obrazka = "cg5dd";
                    break;
                case 5:
                    pictureBox1.Image = pic5;
                    kod_z_obrazka = "x3deb";
                    break;
                case 6:
                    pictureBox1.Image = pic6;
                    kod_z_obrazka = "befbd";
                    break;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string popr_uzytkownik = "admin";
            string popr_haslo = "Qwerty1@34";
            string wprow_uzytkownik = textBox1.Text;
            string wprow_haslo = textBox2.Text;
            string wprow_kod_z_obrazka = textBox3.Text;

            if (wprow_uzytkownik == "" || wprow_haslo == "" || wprow_kod_z_obrazka == "")
            {
                MessageBox.Show("Sprawdz czy wypełniłeś wszystkie pola", "Error");
            }
            else if (wprow_uzytkownik != popr_uzytkownik)
            {
                MessageBox.Show("Niepoprawne pole \"Uzytkownik\"", "Error");
            }
            else if (wprow_haslo != popr_haslo)
            {
                MessageBox.Show("Niepoprawne pole \"Haslo\"", "Error");
            }
            else if (wprow_kod_z_obrazka != kod_z_obrazka)
            {
                MessageBox.Show("Niepoprawny kod z obrazka", "Error");
            }
            else
            {
                MessageBox.Show("Zalogowales sie");
                Form2 f = new Form2();
                f.ShowDialog();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Picture_generator();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}


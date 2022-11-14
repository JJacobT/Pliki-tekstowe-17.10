using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            if(imie == "" || nazwisko == "" || klasa == "")
            {
                MessageBox.Show("Pola nie moga byc puste");
            }
            else
            {

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

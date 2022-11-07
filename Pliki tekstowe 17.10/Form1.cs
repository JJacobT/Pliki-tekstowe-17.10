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
        public Image pic1 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\1.png");
        public Image pic2 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\2.png");
        public Image pic3 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\3.png");
        public Image pic4 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\4.png");
        public Image pic5 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\5.png");
        public Image pic6 = Image.FromFile(@"C: \Users\student\Desktop\Pliki - tekstowe - 17.10\Pliki tekstowe 17.10\\6.png");
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

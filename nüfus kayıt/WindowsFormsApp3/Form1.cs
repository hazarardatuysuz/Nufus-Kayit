using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KayitCONTEXT db=new KayitCONTEXT();
        private void button1_Click(object sender, EventArgs e)
        {
            EKLE YENİ = new EKLE();
            YENİ.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme YENİ = new Listeleme();
            YENİ.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sil YENİ = new Sil();
            YENİ.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ara YENİ = new Ara();
            YENİ.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guncelle YENİ = new guncelle();
            YENİ.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var maxadet = (from veriler in db.kayitlar
                           select veriler).Max(i => i.DOĞUMYILI);

            label4.Text = maxadet.ToString();


            var minadet = (from veriler in db.kayitlar
                           select veriler).Min(i => i.DOĞUMYILI);

            label6.Text = minadet.ToString();


            var ort = (from veriler in db.kayitlar
                       select veriler).Average(i => i.DOĞUMYILI);

            label8.Text = ort.ToString();


            var top = (from veriler in db.kayitlar
                       select veriler).Sum(i => i.DOĞUMYILI);


            label10.Text = top.ToString();









            

            label1.Text = db.kayitlar.Count().ToString();
            int say = 0;
            var tumkayitlar = db.kayitlar.ToList();
            foreach(var item in tumkayitlar)
            {
                say++;
            }
            label1.Text = say.ToString();
        }
    }
}

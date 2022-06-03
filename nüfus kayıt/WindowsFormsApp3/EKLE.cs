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
    public partial class EKLE : Form
    {
        public EKLE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KAYIT yenikayit = new KAYIT();
            KayitCONTEXT db = new KayitCONTEXT();
            yenikayit.TC = Convert.ToInt32(textBox1.Text);
            yenikayit.SERINO = Convert.ToInt32(textBox2.Text);
            yenikayit.AD = textBox3.Text;
            yenikayit.SOYAD = textBox4.Text;
            yenikayit.DOĞUMYILI = Convert.ToInt32(textBox5.Text);
            yenikayit.DOĞUMYERİ = textBox6.Text;
            yenikayit.CİLTNO = Convert.ToInt32(textBox7.Text);
            yenikayit.AİLESIRANO = Convert.ToInt32(textBox8.Text);
            yenikayit.MEDENİDURUM = textBox9.Text;
            yenikayit.KANGRUBU = textBox10.Text;
            db.kayitlar.Add(yenikayit);
            db.SaveChanges();


        }

        private void EKLE_Load(object sender, EventArgs e)
        {
           
        }
    }
}

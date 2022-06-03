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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        KayitCONTEXT DB = new KayitCONTEXT();
        private void Sil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.kayitlar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int silinecekid = Convert.ToInt32(textBox1.Text);
            var sil = (from silveri in DB.kayitlar where silveri.id == silinecekid select silveri).FirstOrDefault();
            DB.kayitlar.Remove(sil);
            DB.SaveChanges();
            dataGridView1.DataSource = DB.kayitlar.ToList();
        }
    }
}

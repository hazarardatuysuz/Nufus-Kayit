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
    public partial class Ara : Form
    {
        public Ara()
        {
            InitializeComponent();
        }
        KayitCONTEXT DB = new KayitCONTEXT();
        private void button1_Click(object sender, EventArgs e)
        {
            string aranacak = textBox1.Text;
            var ara = (from araveri in DB.kayitlar where araveri.AD.Contains(aranacak) select araveri).ToList();
            dataGridView1.DataSource = ara;
            DB.SaveChanges();
        }

        private void Ara_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.kayitlar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranacak = textBox2.Text;
            var ara = (from araveri in DB.kayitlar where araveri.AD==aranacak  select araveri).ToList();
            dataGridView1.DataSource = ara;
            DB.SaveChanges();
        }
    }
}

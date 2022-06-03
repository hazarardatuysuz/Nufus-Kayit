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
    public partial class Listeleme : Form
    {
        public Listeleme()
        {
            InitializeComponent();
        }
        KayitCONTEXT DB = new KayitCONTEXT();
        
        private void Listeleme_Load(object sender, EventArgs e)
        {
            var sirali = (from veri in DB.kayitlar
                          orderby veri.DOĞUMYILI descending
                          select veri).Skip(1).Take(1).ToList();
            



            dataGridView1.DataSource = sirali;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int sayar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int toplamkayit = DB.kayitlar.Count();
            sayar++;
            if (sayar<toplamkayit)
            {
                var sirali = (from veri in DB.kayitlar
                              orderby veri.DOĞUMYILI descending
                              select veri).Skip(sayar).Take(1).ToList();
                dataGridView1.DataSource = sirali;
            }
            else
            {
                sayar = toplamkayit - 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayar--;
            if (sayar >= 0)
            {
                var sirali = (from veri in DB.kayitlar
                              orderby veri.DOĞUMYILI descending
                              select veri).Skip(sayar).Take(1).ToList();
                dataGridView1.DataSource = sirali;
            }
            else
            {
                sayar = 0;
            }
        }
    }
}

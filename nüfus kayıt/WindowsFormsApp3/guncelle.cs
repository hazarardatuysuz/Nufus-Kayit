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
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }
        KayitCONTEXT db = new KayitCONTEXT();
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox11.Text);
            var b = db.kayitlar.Find(id);
            b.TC = Convert.ToInt32(textBox1.Text);
            b.SERINO = Convert.ToInt32(textBox2.Text);
            b.AD = textBox3.Text;
            b.SOYAD = textBox4.Text;
            b.DOĞUMYILI = Convert.ToInt32(textBox5.Text);
            b.DOĞUMYERİ = textBox6.Text;
            b.CİLTNO = Convert.ToInt32(textBox7.Text);
            b.AİLESIRANO = Convert.ToInt32(textBox8.Text);
            b.MEDENİDURUM = textBox9.Text;
            b.KANGRUBU = textBox10.Text;
            dataGridView1.DataSource = db.kayitlar.ToList();
            db.SaveChanges();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kayitlar.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;
            textBox11.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var max = db.kayitlar.Max(KAYIT => KAYIT.DOĞUMYILI);
            var min = db.kayitlar.Min(KAYIT => KAYIT.DOĞUMYILI);
            label12.Text = "max" + max;
            label13.Text = "min" + min;
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

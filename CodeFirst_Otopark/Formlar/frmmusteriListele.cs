using CodeFirst_Otopark.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_Otopark.Formlar
{
    public partial class frmmusteriListele : Form
    {
        public frmmusteriListele()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void frmmusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLMusteri.ToList();

        }
        void temizle()
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                pictureBox1.ImageLocation = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void txtıd_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TBLMusteri
                      where x.ID.ToString() == txtıd.Text
                      select x;
            foreach (var item in ara)
            {
                txtadsoyad.Text = item.Adisoyadi;
                txttel.Text = item.Telefon;
                txtadres.Text = item.Adres;
                txtemail.Text = item.Email;
                pictureBox1.ImageLocation = item.Resim;
                dateTimePicker1.Value = item.Tarih;
            }
            if(txtıd.Text=="")
            {
                temizle();
            }
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            var ekle = new Musteri();
            ekle.Adisoyadi = txtadsoyad.Text;
            ekle.Telefon = txttel.Text;
            ekle.Adres = txtadres.Text;
            ekle.Email = txtemail.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = dateTimePicker1.Value;
            db.TBLMusteri.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.TBLMusteri.FirstOrDefault(x=>x.ID==id);
            db.TBLMusteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            
            int id = int.Parse(txtıd.Text);
            var guncelle = db.TBLMusteri.FirstOrDefault(x => x.ID == id);
            guncelle.Adisoyadi = txtadsoyad.Text;
            guncelle.Telefon = txttel.Text;
            guncelle.Adres = txtadres.Text;
            guncelle.Email = txtemail.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = dateTimePicker1.Value;
           
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }
    }
}

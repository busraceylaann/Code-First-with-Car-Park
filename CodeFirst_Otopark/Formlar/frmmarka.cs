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
    public partial class frmmarka : Form
    {
        public frmmarka()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count>0)
            {
                txtmarkaıd.Text = secilen.SubItems[0].Text;
                txtmarkaadi.Text = secilen.SubItems[1].Text;
            }
        }
        void Temizle()
        {
            txtmarkaıd.Text = "";
            txtmarkaadi.Text = "";
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            var tbl = new Marka();
            tbl.MarkaAdi = txtmarkaadi.Text;
            db.TBLMarka.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void frmmarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markalistesi = db.TBLMarka.ToList();
            for (int i = 0; i < markalistesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistesi[i].ID.ToString());
                ekle.SubItems.Add(markalistesi[i].MarkaAdi);
                listView1.Items.Add(ekle);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ListViewItem secilenıd = listView1.SelectedItems[0];
            int secilenid=int.Parse(secilenıd.SubItems[0].Text);
            var sil = db.TBLMarka.FirstOrDefault(x=>x.ID==secilenid);
            db.TBLMarka.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmarkaıd.Text);
            var guncelle = db.TBLMarka.FirstOrDefault(x=>x.ID==id);
            guncelle.MarkaAdi = txtmarkaadi.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Markası Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }
    }
}

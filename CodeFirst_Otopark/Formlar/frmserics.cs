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
    public partial class frmserics : Form
    {
        public frmserics()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void frmserics_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.TBLMarka.ToList();
            cmbmarka.DataSource = comboliste;
            cmbmarka.DisplayMember = "MarkaAdi";
            cmbmarka.ValueMember = "ID";

        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.TBLSeri
                        join y in db.TBLMarka on
         x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.seri
                        };
            foreach (var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);
            }
        }
        void temizle()
        {
            txtserid.Text = "";
            txtseri.Text = "";
            cmbmarka.Text = "";
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            int markaid = (int)cmbmarka.SelectedValue;
            var ekle = new Seri();
            ekle.MarkaID = markaid;
            ekle.seri = txtseri.Text;
            db.TBLSeri.Add(ekle);
            db.SaveChanges();
            temizle();
            Listele();
            MessageBox.Show("Araca Yeni Seri Eklendi", "Seri Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            ListViewItem secilenıd = listView1.SelectedItems[0];
            int secilenid = int.Parse(secilenıd.SubItems[0].Text);
            var sil = db.TBLSeri.FirstOrDefault(x => x.ID == secilenid);
            db.TBLSeri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç Seri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtserid.Text);
            var guncelle = db.TBLSeri.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaID = (int)cmbmarka.SelectedValue;
            guncelle.seri = txtseri.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Seri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtserid.Text = secilen.SubItems[0].Text;
                cmbmarka.Text = secilen.SubItems[1].Text;
                txtseri.Text = secilen.SubItems[2].Text;
            }
        }
    }
}

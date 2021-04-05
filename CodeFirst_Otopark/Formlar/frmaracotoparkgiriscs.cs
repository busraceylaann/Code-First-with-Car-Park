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
    public partial class frmaracotoparkgiriscs : Form
    {
        public frmaracotoparkgiriscs()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void frmaracotoparkgiriscs_Load(object sender, EventArgs e)
        {
            var markagetir = db.TBLMarka.ToList();
            cmbmarka.DataSource = markagetir;
            cmbmarka.DisplayMember = "MarkaAdi";
            cmbmarka.ValueMember = "ID";

            Parkyeriyenile();
        }

        private void Parkyeriyenile()
        {
            var parkyerigetir = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            cmbparkyeri.DataSource = parkyerigetir;
            cmbparkyeri.DisplayMember = "Parkyerleri";
            cmbparkyeri.ValueMember = "ID";
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)cmbmarka.SelectedValue).ToList();
                cmnseri.DataSource = serigetir;
                cmnseri.DisplayMember = "Seri";
                cmnseri.ValueMember = "ID";
            }
            catch (Exception)
            {

                
            }
        }

        private void cmbmarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)cmbmarka.SelectedValue).ToList();
            cmnseri.DataSource = serigetir;
            cmnseri.DisplayMember = "Seri";
            cmnseri.ValueMember = "ID";
        }

        private void txtmusterid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var musterigetir = db.TBLMusteri.Where(x => x.ID.ToString() == txtmusterid.Text).ToList();
                foreach (var item in musterigetir)
                {
                    txtadsoyad.Text = item.Adisoyadi;
                    txttel.Text = item.Telefon;
                }
                if (txtmusterid.Text == "")
                {
                    txtadsoyad.Text = "";
                    txttel.Text = "";
                }
            }
            catch (Exception)
            {

                
            }
           
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";

                }
                       
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var ekle = new AracParkBilgileri();
            ekle.MusteriID = int.Parse(txtmusterid.Text);
            ekle.AdiSoyadi = txtadsoyad.Text;
            ekle.Telefon = txttel.Text;
            ekle.MarkaID = (int)cmbmarka.SelectedValue;
            ekle.SeriID = (int)cmnseri.SelectedValue;
            ekle.Plaka = txtplaka.Text;
            ekle.Renk = txtrenk.Text;
            ekle.Yil = txtyıl.Text;
            ekle.ParkyeriID = (int)cmbparkyeri.SelectedValue;
            ekle.Aciklama = txtacıklama.Text;
            ekle.GirisTarihi = DateTime.Now;
            db.TBLAracParkBilgileri.Add(ekle);
            db.SaveChanges();
            var parkyeriddoldur = db.TBLAracParkYerleri.FirstOrDefault(x=>x.ID==(int)cmbparkyeri.SelectedValue);
            parkyeriddoldur.Durumu = "DOLU";
            db.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btntemizle.PerformClick();
            Parkyeriyenile();
        }
    }
}

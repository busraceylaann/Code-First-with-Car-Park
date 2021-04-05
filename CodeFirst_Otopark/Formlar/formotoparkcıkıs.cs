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
    public partial class formotoparkcıkıs : Form
    {
        public formotoparkcıkıs()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void formotoparkcıkıs_Load(object sender, EventArgs e)
        {
            cmbsaatucreti.SelectedIndex = 0;
           
           
            Yenile();
            var markagetir = db.TBLMarka.ToList();
            cbmmarka.DataSource = markagetir;
            cbmmarka.DisplayMember = "MarkaAdi";
            cbmmarka.ValueMember = "ID";
        }

        private void Yenile()
        {
            cmbplakara.Text = "";
            cmbplakara.Items.Clear();
            var plakagetir = db.TBLAracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                cmbplakara.Items.Add(item.Plaka);
            }
            var bosparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            cmbparkyeri.DataSource = bosparkyerleri;
            cmbparkyeri.DisplayMember = "Parkyerleri";
            cmbparkyeri.ValueMember = "ID";
            var Doluparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            cmbplakayeriara.DataSource = Doluparkyerleri;
            cmbplakayeriara.DisplayMember = "Parkyerleri";
            cmbplakayeriara.ValueMember = "ID";
            cmbplakayeriara.Text = "";
            cmbparkyeri.Text = "";

        }

        private void cbmmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)cbmmarka.SelectedValue).ToList();
                comboseri.DataSource = serigetir;
                comboseri.DisplayMember = "seri";
                comboseri.ValueMember = "ID";

            }
            catch (Exception)
            {

               
            }
        }
        void ucrethesapla()
        {
            try
            {
                lblcıkıst.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = DateTime.Parse(lblcıkıst.Text) - DateTime.Parse(lblgirist.Text);              
                decimal saatucreti = 0, sure, tutar = 0;
                lblsüre.Text = fark.TotalHours.ToString("0.00");
      
                saatucreti = decimal.Parse(cmbsaatucreti.Text);
                sure = decimal.Parse(lblsüre.Text);
                tutar = sure * saatucreti;
                lbltutar.Text = tutar.ToString("0.00");

            }
            catch (Exception)
            {

               
            }
        }
        private void txtidara_TextChanged(object sender, EventArgs e)
        {

            if(txtidara.Text=="")
            {
                foreach (Control item in panelislem.Controls )
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            #region ID_Ara
            var ıdara = (from x in db.TBLAracParkBilgileri
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new { x.ID, x.MusteriID, x.AdiSoyadi, x.Telefon, x.Plaka, x.Renk, x.Aciklama, x.GirisTarihi,
                         y.MarkaAdi, z.seri, w.Parkyerleri
                         }).Where(ara => ara.ID.ToString() == txtidara.Text).ToList();
            foreach (var item in ıdara)
            {
                txtıd.Text = item.ID.ToString();
                txtmusteriid.Text = item.MusteriID.ToString();
                txtadsoyad.Text = item.AdiSoyadi.ToString();
                txttelefon.Text = item.Telefon.ToString();
                cbmmarka.Text = item.MarkaAdi;
                comboseri.Text = item.seri;
                txtplaka.Text = item.Plaka;
                txtrenk.Text = item.Renk;
                cmbparkyeri.Text = item.Parkyerleri;
                txtacıklama.Text = item.Aciklama;
                lblgirist.Text = item.GirisTarihi.ToString();
                ucrethesapla();
                
            }
            #endregion
        }

        private void txtmusteriara_TextChanged(object sender, EventArgs e)
        {
            if (txtmusteriara.Text == "")
            {
                foreach (Control item in panelislem.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            #region MusteriID_Ara
            var musteriıdara = (from x in db.TBLAracParkBilgileri
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.GirisTarihi,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri
                         }).Where(ara => ara.MusteriID.ToString() == txtmusteriara.Text).ToList();
            foreach (var item in musteriıdara)
            {
                txtıd.Text = item.ID.ToString();
                txtmusteriid.Text = item.MusteriID.ToString();
                txtadsoyad.Text = item.AdiSoyadi.ToString();
                txttelefon.Text = item.Telefon.ToString();
                cbmmarka.Text = item.MarkaAdi;
                comboseri.Text = item.seri;
                txtplaka.Text = item.Plaka;
                txtrenk.Text = item.Renk;
                cmbparkyeri.Text = item.Parkyerleri;
                txtacıklama.Text = item.Aciklama;
                lblgirist.Text = item.GirisTarihi.ToString();
                ucrethesapla();
            }
            #endregion
        }

        private void txtadsoyadara_TextChanged(object sender, EventArgs e)
        {
            if (txtadsoyadara.Text == "")
            {
                foreach (Control item in panelislem.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            #region adsoyad_Ara
            var adsoyadara = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                  x.MarkaID equals y.ID
                                join z in db.TBLSeri on x.SeriID equals z.ID
                                join
               w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.Parkyerleri
                                }).Where(ara => ara.AdiSoyadi.ToString() == txtadsoyadara.Text).ToList();
            foreach (var item in adsoyadara)
            {
                txtıd.Text = item.ID.ToString();
                txtmusteriid.Text = item.MusteriID.ToString();
                txtadsoyad.Text = item.AdiSoyadi.ToString();
                txttelefon.Text = item.Telefon.ToString();
                cbmmarka.Text = item.MarkaAdi;
                comboseri.Text = item.seri;
                txtplaka.Text = item.Plaka;
                txtrenk.Text = item.Renk;
                cmbparkyeri.Text = item.Parkyerleri;
                txtacıklama.Text = item.Aciklama;
                lblgirist.Text = item.GirisTarihi.ToString();
                ucrethesapla();
            }
            #endregion
        }

        private void cmbplakara_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            #region plaka_Ara
            var plakaara= (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                  x.MarkaID equals y.ID
                                join z in db.TBLSeri on x.SeriID equals z.ID
                                join
               w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.Parkyerleri
                                }).Where(ara => ara.Plaka.ToString() == cmbplakara.Text).ToList();
            foreach (var item in plakaara)
            {
                txtıd.Text = item.ID.ToString();
                txtmusteriid.Text = item.MusteriID.ToString();
                txtadsoyad.Text = item.AdiSoyadi.ToString();
                txttelefon.Text = item.Telefon.ToString();
                cbmmarka.Text = item.MarkaAdi;
                comboseri.Text = item.seri;
                txtplaka.Text = item.Plaka;
                txtrenk.Text = item.Renk;
                cmbparkyeri.Text = item.Parkyerleri;
                txtacıklama.Text = item.Aciklama;
                lblgirist.Text = item.GirisTarihi.ToString();
                ucrethesapla();
            }
            #endregion
        }

        private void cmbplakayeriara_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region parkyeri_Ara
            var parkyeriara = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                  x.MarkaID equals y.ID
                                join z in db.TBLSeri on x.SeriID equals z.ID
                                join
               w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.Parkyerleri
                                }).Where(ara => ara.Parkyerleri.ToString() == cmbplakayeriara.Text).ToList();
            foreach (var item in parkyeriara)
            {
                txtıd.Text = item.ID.ToString();
                txtmusteriid.Text = item.MusteriID.ToString();
                txtadsoyad.Text = item.AdiSoyadi.ToString();
                txttelefon.Text = item.Telefon.ToString();
                cbmmarka.Text = item.MarkaAdi;
                comboseri.Text = item.seri;
                txtplaka.Text = item.Plaka;
                txtrenk.Text = item.Renk;
                cmbparkyeri.Text = item.Parkyerleri;
                txtacıklama.Text = item.Aciklama;
                lblgirist.Text = item.GirisTarihi.ToString();
                ucrethesapla();
            }
            #endregion
        }

        private void cmbplakara_TextChanged(object sender, EventArgs e)
        {
            if (cmbplakara.Text == "")
            {
                foreach (Control item in panelislem.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void cmbplakayeriara_TextChanged(object sender, EventArgs e)
        {
            if (cmbparkyeri.Text == "")
            {
                foreach (Control item in panelislem.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var doluparkyeridegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.Parkyerleri == cmbplakayeriara.Text);
            doluparkyeridegistir.Durumu = "BOŞ";
            db.SaveChanges();
            var bosparkyeridegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.Parkyerleri == cmbparkyeri.Text);
             bosparkyeridegistir.Durumu = "DOLU";
            db.SaveChanges();
            var aracparkyeridegistir = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == txtplaka.Text);
            aracparkyeridegistir.ParkyeriID = (int)cmbparkyeri.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Araç Park Yeri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbplakayeriara.Items.Clear();
            Yenile();
            button6.PerformClick();
            lblsüre.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgirist.Text = DateTime.Now.ToString();
            lblcıkıst.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelarama.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in panelislem.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    if(item!=cmbsaatucreti)
                    {
                        item.Text = "";
                    }
                }
            }
            lblsüre.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgirist.Text = DateTime.Now.ToString();
            lblcıkıst.Text = DateTime.Now.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            #region sil
            kayitsil();
            MessageBox.Show("Araç Park Yeri Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbplakayeriara.Items.Clear();
            Yenile();
            button6.PerformClick();
            lblsüre.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgirist.Text = DateTime.Now.ToString();
            lblcıkıst.Text = DateTime.Now.ToString();
            #endregion
        }

        private void kayitsil()
        {
            var sil = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == txtplaka.Text);
            db.TBLAracParkBilgileri.Remove(sil);
            db.SaveChanges();


            var aracparkyeribosalt = db.TBLAracParkYerleri.FirstOrDefault(x => x.Parkyerleri == cmbparkyeri.Text);
            aracparkyeribosalt.Durumu = "BOŞ";
            db.SaveChanges();
        }

        private void btnaraccıkıs_Click(object sender, EventArgs e)
        {
            if (cmbplakayeriara.Text!="")
            {
                var ekle = new Satis();
                ekle.SatisID = int.Parse(txtıd.Text);
                ekle.MusteriID = int.Parse(txtmusteriid.Text);
                ekle.AdiSoyadi = txtadsoyad.Text;
                ekle.Telefon = txttelefon.Text;
                ekle.MarkaID = (int)cbmmarka.SelectedValue;
                ekle.SeriID = (int)comboseri.SelectedValue;
                ekle.Plaka = txtplaka.Text;
                ekle.Yil = "Belirtilmedi";
                ekle.Renk = txtrenk.Text;
                ekle.ParkyeriID = (int)cmbplakayeriara.SelectedValue;
                ekle.saatUcreti = decimal.Parse(cmbsaatucreti.Text);
                ekle.Sure = decimal.Parse(lblsüre.Text);
                ekle.Tutar = decimal.Parse(lbltutar.Text);
                ekle.Aciklama = txtacıklama.Text;
                ekle.GirisTarihi = DateTime.Parse(lblgirist.Text);
                ekle.CikisTarihi = DateTime.Parse(lblcıkıst.Text);
                db.TBLSatis.Add(ekle);
                db.SaveChanges();
                MessageBox.Show("Araç Otopark Çıkışı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayitsil();
                Yenile();
                button6.PerformClick();         
                lblsüre.Text = "0.00";
                lbltutar.Text = "0.00";
                lblgirist.Text = DateTime.Now.ToString();
                lblcıkıst.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Dolu Park Yerinin Seçilmesi Gerekir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
          

        }

        private void cmbsaatucreti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucrethesapla();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.TBLAracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == txtıd.Text);
            guncelle.MarkaID = (int)cbmmarka.SelectedValue;
            guncelle.SeriID = (int)comboseri.SelectedValue;
            guncelle.Plaka = txtplaka.Text;
            guncelle.Renk = txtrenk.Text;
            guncelle.Aciklama = txtacıklama.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Park Bilgileri Güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            Yenile();
            button6.PerformClick();
            lblsüre.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgirist.Text = DateTime.Now.ToString();
            lblcıkıst.Text = DateTime.Now.ToString();
        }
    }
}

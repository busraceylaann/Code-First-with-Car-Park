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
    public partial class frmsatiscs : Form
    {
        public frmsatiscs()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void frmsatiscs_Load(object sender, EventArgs e)
        {
            TumKayitlar();
        }

        private void TumKayitlar()
        {
            #region kayitgoster
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).ToList();
            dataGridView1.DataSource = liste;
            lbltutar.Text = "Toplam Tutar="+db.TBLSatis.Sum(x => x.Tutar);
            lblkayit.Text = "Toplam" + db.TBLSatis.Count()+"Kayıt Listelendi";
            lblortalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblmin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            lblmax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);

            #endregion
        }

        private void txtidara_TextChanged(object sender, EventArgs e)
        {

            #region IDAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.ID.ToString() == txtidara.Text).ToList();
            dataGridView1.DataSource = liste;
            if (txtidara.Text=="")
            {
                TumKayitlar();
            }

            #endregion
        }

        private void txtmusteriara_TextChanged(object sender, EventArgs e)
        {

            #region musteriAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.MusteriID.ToString() == txtmusteriara.Text).ToList();
            dataGridView1.DataSource = liste;
            if (txtmusteriara.Text == "")
            {
                TumKayitlar();
            }

            #endregion
        }

        private void txtadsoyadara_TextChanged(object sender, EventArgs e)
        {
            #region adsoyadAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.AdiSoyadi.Contains(txtadsoyadara.Text)).ToList();
            dataGridView1.DataSource = liste;
            lbltutar.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            lblkayit.Text = "Toplam" + db.TBLSatis.Count() + "Kayıt Listelendi";
            lblortalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblmin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            lblmax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);


            #endregion
        }

        private void txtplakara_TextChanged(object sender, EventArgs e)
        {
            #region plakaAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.Plaka.Contains(txtplakara.Text)).ToList();
            dataGridView1.DataSource = liste;
            lbltutar.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            lblkayit.Text = "Toplam" + db.TBLSatis.Count() + "Kayıt Listelendi";
            lblortalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblmin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            lblmax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);


            #endregion
        }

        private void txtplakayeriara_TextChanged(object sender, EventArgs e)
        {
            #region parkyeriAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
           x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join
        w in db.TBLAracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.Parkyerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.Parkyerleri.Contains(txtplakayeriara.Text)).ToList();
            dataGridView1.DataSource = liste;
            lbltutar.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            lblkayit.Text = "Toplam " + db.TBLSatis.Count() + " Kayıt Listelendi";
            lblortalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblmin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            lblmax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);

            #endregion
        }
    }
}

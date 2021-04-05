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
    public partial class frmotoparkyerics : Form
    {
        public frmotoparkyerics()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();
        private void frmotoparkyerics_Load(object sender, EventArgs e)
        {
            PanelParkyerleri();
            veritabaniparkyerleri();
            var plakagoster = from x in db.TBLAracParkBilgileri
                              select new { x.Plaka, x.ParkyeriID };
            foreach (var item in plakagoster)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (lbl.Name==item.ParkyeriID.ToString()&&lbl.BackColor==Color.Red)
                    {
                        lbl.Text = item.Plaka;
                    }
                }
               
                foreach (Control lbl in panel2.Controls)
                {
                    if (lbl.Name == item.ParkyeriID.ToString() && lbl.BackColor == Color.Red)
                    {
                        lbl.Text = item.Plaka;
                    }
                }

            }
        }

        private void veritabaniparkyerleri()
        {
            var parkyerleri = from i in db.TBLAracParkYerleri

                              select new
                              {
                                  i.Durumu,
                                  i,
                                  i.ID,
                                  i.Parkyerleri
                              };
            foreach (var item in parkyerleri)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (item.Durumu == "BOŞ" && item.Parkyerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.LightSeaGreen;
                    }
                    else if (item.Durumu == "DOLU" && item.Parkyerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
            }
            foreach (var item in parkyerleri)
            {
                foreach (Control lbl in panel2.Controls)
                {
                    if (item.Durumu == "BOŞ" && item.Parkyerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.LightSeaGreen;
                    }
                    else if (item.Durumu == "DOLU" && item.Parkyerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
            }
        }

        private void PanelParkyerleri()
        {
            int x = 1, y = 1, z = 11;
            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    item.Text = "A-" + x;
                    item.Name = x.ToString();
                    x++;
                }
            }
            foreach (Control item in panel2.Controls)
            {
                if (item is Label)
                {
                    item.Text = "B-" + y;
                    item.Name = z.ToString();
                    y++;
                    z++;
                }
            }
        }
    }
}

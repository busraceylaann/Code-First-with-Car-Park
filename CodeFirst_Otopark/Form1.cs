using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_Otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.frmmarka marka = new Formlar.frmmarka();
            marka.Show();
        }

        private void btnmarka_Click(object sender, EventArgs e)
        {
            Formlar.frmmarka marka = new Formlar.frmmarka();
            marka.Show();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            Formlar.frmserics seri= new Formlar.frmserics();
            seri.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {

            Formlar.frmserics seri = new Formlar.frmserics();
            seri.Show();
        }

        private void btmusterilistele_Click(object sender, EventArgs e)
        {
            Formlar.frmmusteriListele listele= new Formlar.frmmusteriListele();
            listele.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void btnotoparkyerleri_Click(object sender, EventArgs e)
        {
            Formlar.frmotoparkyerics frmotoparkyerics = new Formlar.frmotoparkyerics();
            frmotoparkyerics.Show();
        }

        private void btnaracotoparkgirisi_Click(object sender, EventArgs e)
        {
            Formlar.frmaracotoparkgiriscs  frm = new Formlar.frmaracotoparkgiriscs();
           frm.Show();
        }

        private void saatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnotoparkcikis_Click(object sender, EventArgs e)
        {
            Formlar.formotoparkcıkıs frm = new Formlar.formotoparkcıkıs();
            frm.Show();
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            Formlar.frmmusteriListele listele = new Formlar.frmmusteriListele();
            listele.Show();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {

            Formlar.frmsatiscs listele = new Formlar.frmsatiscs();
            listele.Show();
        }
    }
}

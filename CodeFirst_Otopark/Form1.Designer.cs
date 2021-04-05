namespace CodeFirst_Otopark
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkÇıkışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.seriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoParkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsatis = new System.Windows.Forms.Button();
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnmarka = new System.Windows.Forms.Button();
            this.btnotoparkyerleri = new System.Windows.Forms.Button();
            this.btnotoparkcikis = new System.Windows.Forms.Button();
            this.btnaracotoparkgirisi = new System.Windows.Forms.Button();
            this.btmusterilistele = new System.Windows.Forms.Button();
            this.btnmusteriekle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.otoParkToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.saatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriDüzenleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            // 
            // müşteriDüzenleToolStripMenuItem
            // 
            this.müşteriDüzenleToolStripMenuItem.Name = "müşteriDüzenleToolStripMenuItem";
            this.müşteriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.müşteriDüzenleToolStripMenuItem.Text = "Müşteri Düzenle";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçOtoparkGirişiToolStripMenuItem,
            this.araçOtoparkÇıkışıToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.araçlarToolStripMenuItem.Text = "Araç İşlemler";
            // 
            // araçOtoparkGirişiToolStripMenuItem
            // 
            this.araçOtoparkGirişiToolStripMenuItem.Name = "araçOtoparkGirişiToolStripMenuItem";
            this.araçOtoparkGirişiToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.araçOtoparkGirişiToolStripMenuItem.Text = "Araç Otopark Girişi";
            // 
            // araçOtoparkÇıkışıToolStripMenuItem
            // 
            this.araçOtoparkÇıkışıToolStripMenuItem.Name = "araçOtoparkÇıkışıToolStripMenuItem";
            this.araçOtoparkÇıkışıToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.araçOtoparkÇıkışıToolStripMenuItem.Text = "Araç Otopark Çıkışı";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaTool,
            this.seriTool});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // markaTool
            // 
            this.markaTool.Name = "markaTool";
            this.markaTool.Size = new System.Drawing.Size(125, 26);
            this.markaTool.Text = "Marka";
            this.markaTool.Click += new System.EventHandler(this.markaTool_Click);
            // 
            // seriTool
            // 
            this.seriTool.Name = "seriTool";
            this.seriTool.Size = new System.Drawing.Size(125, 26);
            this.seriTool.Text = "Seri";
            this.seriTool.Click += new System.EventHandler(this.seriTool_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // otoParkToolStripMenuItem
            // 
            this.otoParkToolStripMenuItem.Name = "otoParkToolStripMenuItem";
            this.otoParkToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.otoParkToolStripMenuItem.Text = "Otopark";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // saatToolStripMenuItem
            // 
            this.saatToolStripMenuItem.Name = "saatToolStripMenuItem";
            this.saatToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            this.saatToolStripMenuItem.Click += new System.EventHandler(this.saatToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsatis);
            this.panel1.Controls.Add(this.btnSeri);
            this.panel1.Controls.Add(this.btnmarka);
            this.panel1.Controls.Add(this.btnotoparkyerleri);
            this.panel1.Controls.Add(this.btnotoparkcikis);
            this.panel1.Controls.Add(this.btnaracotoparkgirisi);
            this.panel1.Controls.Add(this.btmusterilistele);
            this.panel1.Controls.Add(this.btnmusteriekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 133);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "universityiconsArtboard_1_copy_17-512.png");
            this.ımageList1.Images.SetKeyName(1, "users3_add.png");
            this.ımageList1.Images.SetKeyName(2, "images.jpg");
            this.ımageList1.Images.SetKeyName(3, "eca72588d12b45fa8bd98f111f31009e.png");
            this.ımageList1.Images.SetKeyName(4, "images (1).jpg");
            this.ımageList1.Images.SetKeyName(5, "images.png");
            this.ımageList1.Images.SetKeyName(6, "cat-1.png");
            this.ımageList1.Images.SetKeyName(7, "images (2).jpg");
            // 
            // btnsatis
            // 
            this.btnsatis.FlatAppearance.BorderSize = 0;
            this.btnsatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsatis.ImageKey = "images.png";
            this.btnsatis.ImageList = this.ımageList1;
            this.btnsatis.Location = new System.Drawing.Point(576, 9);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(95, 109);
            this.btnsatis.TabIndex = 7;
            this.btnsatis.Text = "Satış";
            this.btnsatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsatis.UseVisualStyleBackColor = true;
            this.btnsatis.Click += new System.EventHandler(this.btnsatis_Click);
            // 
            // btnSeri
            // 
            this.btnSeri.FlatAppearance.BorderSize = 0;
            this.btnSeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeri.ImageKey = "images (2).jpg";
            this.btnSeri.ImageList = this.ımageList1;
            this.btnSeri.Location = new System.Drawing.Point(815, 9);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(117, 112);
            this.btnSeri.TabIndex = 6;
            this.btnSeri.Text = "Seri";
            this.btnSeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnmarka
            // 
            this.btnmarka.FlatAppearance.BorderSize = 0;
            this.btnmarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmarka.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmarka.ImageKey = "cat-1.png";
            this.btnmarka.ImageList = this.ımageList1;
            this.btnmarka.Location = new System.Drawing.Point(677, 12);
            this.btnmarka.Name = "btnmarka";
            this.btnmarka.Size = new System.Drawing.Size(111, 109);
            this.btnmarka.TabIndex = 5;
            this.btnmarka.Text = "Marka";
            this.btnmarka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmarka.UseVisualStyleBackColor = true;
            this.btnmarka.Click += new System.EventHandler(this.btnmarka_Click);
            // 
            // btnotoparkyerleri
            // 
            this.btnotoparkyerleri.FlatAppearance.BorderSize = 0;
            this.btnotoparkyerleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotoparkyerleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnotoparkyerleri.ImageKey = "eca72588d12b45fa8bd98f111f31009e.png";
            this.btnotoparkyerleri.ImageList = this.ımageList1;
            this.btnotoparkyerleri.Location = new System.Drawing.Point(441, 9);
            this.btnotoparkyerleri.Name = "btnotoparkyerleri";
            this.btnotoparkyerleri.Size = new System.Drawing.Size(106, 109);
            this.btnotoparkyerleri.TabIndex = 4;
            this.btnotoparkyerleri.Text = "Otopark ";
            this.btnotoparkyerleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnotoparkyerleri.UseVisualStyleBackColor = true;
            this.btnotoparkyerleri.Click += new System.EventHandler(this.btnotoparkyerleri_Click);
            // 
            // btnotoparkcikis
            // 
            this.btnotoparkcikis.FlatAppearance.BorderSize = 0;
            this.btnotoparkcikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotoparkcikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnotoparkcikis.ImageKey = "universityiconsArtboard_1_copy_17-512.png";
            this.btnotoparkcikis.ImageList = this.ımageList1;
            this.btnotoparkcikis.Location = new System.Drawing.Point(328, 9);
            this.btnotoparkcikis.Name = "btnotoparkcikis";
            this.btnotoparkcikis.Size = new System.Drawing.Size(95, 109);
            this.btnotoparkcikis.TabIndex = 3;
            this.btnotoparkcikis.Text = "Araç Çıkış";
            this.btnotoparkcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnotoparkcikis.UseVisualStyleBackColor = true;
            this.btnotoparkcikis.Click += new System.EventHandler(this.btnotoparkcikis_Click);
            // 
            // btnaracotoparkgirisi
            // 
            this.btnaracotoparkgirisi.FlatAppearance.BorderSize = 0;
            this.btnaracotoparkgirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaracotoparkgirisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaracotoparkgirisi.ImageKey = "images.jpg";
            this.btnaracotoparkgirisi.ImageList = this.ımageList1;
            this.btnaracotoparkgirisi.Location = new System.Drawing.Point(226, 9);
            this.btnaracotoparkgirisi.Name = "btnaracotoparkgirisi";
            this.btnaracotoparkgirisi.Size = new System.Drawing.Size(106, 109);
            this.btnaracotoparkgirisi.TabIndex = 2;
            this.btnaracotoparkgirisi.Text = "Araç Giriş";
            this.btnaracotoparkgirisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaracotoparkgirisi.UseVisualStyleBackColor = true;
            this.btnaracotoparkgirisi.Click += new System.EventHandler(this.btnaracotoparkgirisi_Click);
            // 
            // btmusterilistele
            // 
            this.btmusterilistele.FlatAppearance.BorderSize = 0;
            this.btmusterilistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmusterilistele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmusterilistele.ImageKey = "images (1).jpg";
            this.btmusterilistele.ImageList = this.ımageList1;
            this.btmusterilistele.Location = new System.Drawing.Point(127, 12);
            this.btmusterilistele.Name = "btmusterilistele";
            this.btmusterilistele.Size = new System.Drawing.Size(93, 109);
            this.btmusterilistele.TabIndex = 1;
            this.btmusterilistele.Text = "Müşteriler";
            this.btmusterilistele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmusterilistele.UseVisualStyleBackColor = true;
            this.btmusterilistele.Click += new System.EventHandler(this.btmusterilistele_Click);
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.FlatAppearance.BorderSize = 0;
            this.btnmusteriekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusteriekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmusteriekle.ImageKey = "users3_add.png";
            this.btnmusteriekle.ImageList = this.ımageList1;
            this.btnmusteriekle.Location = new System.Drawing.Point(11, 12);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(99, 109);
            this.btnmusteriekle.TabIndex = 0;
            this.btnmusteriekle.Text = "Müşteri Ekle";
            this.btnmusteriekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmusteriekle.UseVisualStyleBackColor = true;
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkÇıkışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaTool;
        private System.Windows.Forms.ToolStripMenuItem seriTool;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoParkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnmarka;
        private System.Windows.Forms.Button btnotoparkyerleri;
        private System.Windows.Forms.Button btnotoparkcikis;
        private System.Windows.Forms.Button btnaracotoparkgirisi;
        private System.Windows.Forms.Button btmusterilistele;
        private System.Windows.Forms.Button btnmusteriekle;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}


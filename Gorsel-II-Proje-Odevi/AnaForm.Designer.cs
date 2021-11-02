namespace Gorsel_II_Proje_Odevi
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Basvuru = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Fatura = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Musteri = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BasvuruTur = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_BasvuruDurum = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Personela = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Fatura_islemleri = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_kartTur = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_HesapTur = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Eft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Havale = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_musteriTur = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctnxmenu_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnxmenu_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnxmenu_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.timerOturum = new System.Windows.Forms.Timer(this.components);
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.statusStripDurum = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_sure = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgbr_sure = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.statusStripDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Basvuru,
            this.tsbtn_Fatura,
            this.tsbtn_Musteri,
            this.tsbtn_BasvuruTur,
            this.tsbtn_BasvuruDurum,
            this.tsbtn_Personela,
            this.tsbtn_Fatura_islemleri,
            this.tsbtn_kartTur,
            this.tsbtn_HesapTur,
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsbtn_musteriTur,
            this.tsbtn_Havale,
            this.tsbtn_Eft,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Basvuru
            // 
            this.tsbtn_Basvuru.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Basvuru.Image")));
            this.tsbtn_Basvuru.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Basvuru.Name = "tsbtn_Basvuru";
            this.tsbtn_Basvuru.Size = new System.Drawing.Size(100, 35);
            this.tsbtn_Basvuru.Text = "Başvuru İşlemleri";
            this.tsbtn_Basvuru.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Basvuru.Click += new System.EventHandler(this.tsbtn_Basvuru_Click);
            // 
            // tsbtn_Fatura
            // 
            this.tsbtn_Fatura.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Fatura.Image")));
            this.tsbtn_Fatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Fatura.Name = "tsbtn_Fatura";
            this.tsbtn_Fatura.Size = new System.Drawing.Size(91, 35);
            this.tsbtn_Fatura.Text = "Fatura İşlemleri";
            this.tsbtn_Fatura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Fatura.Click += new System.EventHandler(this.tsbtn_Fatura_Click);
            // 
            // tsbtn_Musteri
            // 
            this.tsbtn_Musteri.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Musteri.Image")));
            this.tsbtn_Musteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Musteri.Name = "tsbtn_Musteri";
            this.tsbtn_Musteri.Size = new System.Drawing.Size(98, 35);
            this.tsbtn_Musteri.Text = "Müşteri İşlemleri";
            this.tsbtn_Musteri.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Musteri.Click += new System.EventHandler(this.tsbtn_Musteri_Click_1);
            // 
            // tsbtn_BasvuruTur
            // 
            this.tsbtn_BasvuruTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BasvuruTur.Image")));
            this.tsbtn_BasvuruTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BasvuruTur.Name = "tsbtn_BasvuruTur";
            this.tsbtn_BasvuruTur.Size = new System.Drawing.Size(127, 35);
            this.tsbtn_BasvuruTur.Text = "Başvuru Türü İşlemleri";
            this.tsbtn_BasvuruTur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_BasvuruTur.Click += new System.EventHandler(this.tsbtn_BasvuruTur_Click);
            // 
            // tsbtn_BasvuruDurum
            // 
            this.tsbtn_BasvuruDurum.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_BasvuruDurum.Image")));
            this.tsbtn_BasvuruDurum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_BasvuruDurum.Name = "tsbtn_BasvuruDurum";
            this.tsbtn_BasvuruDurum.Size = new System.Drawing.Size(140, 35);
            this.tsbtn_BasvuruDurum.Text = "Başvuru Durum İşlemleri";
            this.tsbtn_BasvuruDurum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_BasvuruDurum.Click += new System.EventHandler(this.tsbtn_BasvuruDurum_Click);
            // 
            // tsbtn_Personela
            // 
            this.tsbtn_Personela.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Personela.Image")));
            this.tsbtn_Personela.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Personela.Name = "tsbtn_Personela";
            this.tsbtn_Personela.Size = new System.Drawing.Size(123, 35);
            this.tsbtn_Personela.Text = "Personel Tür İşlemleri";
            this.tsbtn_Personela.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Personela.Click += new System.EventHandler(this.tsbtn_Personela_Click);
            // 
            // tsbtn_Fatura_islemleri
            // 
            this.tsbtn_Fatura_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Fatura_islemleri.Image")));
            this.tsbtn_Fatura_islemleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Fatura_islemleri.Name = "tsbtn_Fatura_islemleri";
            this.tsbtn_Fatura_islemleri.Size = new System.Drawing.Size(111, 35);
            this.tsbtn_Fatura_islemleri.Text = "Fatura Tür İşlemleri";
            this.tsbtn_Fatura_islemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Fatura_islemleri.Click += new System.EventHandler(this.tsbtn_Fatura_islemleri_Click);
            // 
            // tsbtn_kartTur
            // 
            this.tsbtn_kartTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_kartTur.Image")));
            this.tsbtn_kartTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_kartTur.Name = "tsbtn_kartTur";
            this.tsbtn_kartTur.Size = new System.Drawing.Size(106, 35);
            this.tsbtn_kartTur.Text = "Kart Türü İşlemleri";
            this.tsbtn_kartTur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_kartTur.Click += new System.EventHandler(this.tsbtn_kartTur_Click);
            // 
            // tsbtn_HesapTur
            // 
            this.tsbtn_HesapTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_HesapTur.Image")));
            this.tsbtn_HesapTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_HesapTur.Name = "tsbtn_HesapTur";
            this.tsbtn_HesapTur.Size = new System.Drawing.Size(118, 35);
            this.tsbtn_HesapTur.Text = "Hesap Türü İşlemleri";
            this.tsbtn_HesapTur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_HesapTur.Click += new System.EventHandler(this.tsbtn_HesapTur_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 35);
            this.toolStripButton1.Text = "Personel İşlemleri";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtn_Eft
            // 
            this.tsbtn_Eft.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Eft.Image")));
            this.tsbtn_Eft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Eft.Name = "tsbtn_Eft";
            this.tsbtn_Eft.Size = new System.Drawing.Size(76, 35);
            this.tsbtn_Eft.Text = "EFT İşlemleri";
            this.tsbtn_Eft.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Eft.Click += new System.EventHandler(this.tsbtn_Eft_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 35);
            this.toolStripButton2.Text = "Kart İşlemleri";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbtn_Havale
            // 
            this.tsbtn_Havale.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Havale.Image")));
            this.tsbtn_Havale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Havale.Name = "tsbtn_Havale";
            this.tsbtn_Havale.Size = new System.Drawing.Size(94, 35);
            this.tsbtn_Havale.Text = "Havale İşlemleri";
            this.tsbtn_Havale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_Havale.Click += new System.EventHandler(this.tsbtn_Havale_Click);
            // 
            // tsbtn_musteriTur
            // 
            this.tsbtn_musteriTur.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_musteriTur.Image")));
            this.tsbtn_musteriTur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_musteriTur.Name = "tsbtn_musteriTur";
            this.tsbtn_musteriTur.Size = new System.Drawing.Size(125, 35);
            this.tsbtn_musteriTur.Text = "Müşteri Türü İşlemleri";
            this.tsbtn_musteriTur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtn_musteriTur.Click += new System.EventHandler(this.tsbtn_musteriTur_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(119, 35);
            this.toolStripButton3.Text = "Transfer Tür İşlemleri";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(84, 35);
            this.toolStripButton4.Text = "Şube İşlemleri";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Gorsel_II_Proje_Odevi.Properties.Resources.user__1_;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(44, 35);
            this.toolStripButton5.Text = "Hesap";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // notifyIconBanka
            // 
            this.notifyIconBanka.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIconBanka.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBanka.Icon")));
            this.notifyIconBanka.Text = "Banka Uygulaması";
            this.notifyIconBanka.Visible = true;
            this.notifyIconBanka.DoubleClick += new System.EventHandler(this.notifyIconBanka_DoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctnxmenu_Goster,
            this.ctnxmenu_Gizle,
            this.ctnxmenu_Kapat});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(112, 70);
            // 
            // ctnxmenu_Goster
            // 
            this.ctnxmenu_Goster.Name = "ctnxmenu_Goster";
            this.ctnxmenu_Goster.Size = new System.Drawing.Size(111, 22);
            this.ctnxmenu_Goster.Text = " Göster";
            this.ctnxmenu_Goster.Click += new System.EventHandler(this.ctnxmenu_Goster_Click);
            // 
            // ctnxmenu_Gizle
            // 
            this.ctnxmenu_Gizle.Name = "ctnxmenu_Gizle";
            this.ctnxmenu_Gizle.Size = new System.Drawing.Size(111, 22);
            this.ctnxmenu_Gizle.Text = "Gizle";
            this.ctnxmenu_Gizle.Click += new System.EventHandler(this.ctnxmenu_Gizle_Click);
            // 
            // ctnxmenu_Kapat
            // 
            this.ctnxmenu_Kapat.Name = "ctnxmenu_Kapat";
            this.ctnxmenu_Kapat.Size = new System.Drawing.Size(111, 22);
            this.ctnxmenu_Kapat.Text = "Kapat";
            this.ctnxmenu_Kapat.Click += new System.EventHandler(this.ctnxmenu_Kapat_Click);
            // 
            // timerOturum
            // 
            this.timerOturum.Interval = 5000;
            this.timerOturum.Tick += new System.EventHandler(this.timerOturum_Tick);
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // statusStripDurum
            // 
            this.statusStripDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslbl_sure,
            this.tspgbr_sure});
            this.statusStripDurum.Location = new System.Drawing.Point(0, 727);
            this.statusStripDurum.Name = "statusStripDurum";
            this.statusStripDurum.Size = new System.Drawing.Size(1370, 22);
            this.statusStripDurum.TabIndex = 4;
            this.statusStripDurum.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "Kalan Süre :";
            // 
            // tslbl_sure
            // 
            this.tslbl_sure.Name = "tslbl_sure";
            this.tslbl_sure.Size = new System.Drawing.Size(56, 17);
            this.tslbl_sure.Text = "tslbl_sure";
            // 
            // tspgbr_sure
            // 
            this.tspgbr_sure.Maximum = 1800;
            this.tspgbr_sure.Name = "tspgbr_sure";
            this.tspgbr_sure.Size = new System.Drawing.Size(500, 16);
            this.tspgbr_sure.Value = 1800;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.statusStripDurum);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuNotify.ResumeLayout(false);
            this.statusStripDurum.ResumeLayout(false);
            this.statusStripDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtn_Basvuru;
        public System.Windows.Forms.ToolStripButton tsbtn_Fatura;
        public System.Windows.Forms.ToolStripButton tsbtn_Musteri;
        public System.Windows.Forms.ToolStripButton tsbtn_BasvuruTur;
        public System.Windows.Forms.ToolStripButton tsbtn_BasvuruDurum;
        public System.Windows.Forms.ToolStripButton tsbtn_Personela;
        public System.Windows.Forms.ToolStripButton tsbtn_Fatura_islemleri;
        public System.Windows.Forms.ToolStripButton tsbtn_kartTur;
        public System.Windows.Forms.ToolStripButton tsbtn_HesapTur;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ToolStripButton tsbtn_Eft;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbtn_Havale;
        private System.Windows.Forms.ToolStripButton tsbtn_musteriTur;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem ctnxmenu_Goster;
        private System.Windows.Forms.ToolStripMenuItem ctnxmenu_Gizle;
        private System.Windows.Forms.ToolStripMenuItem ctnxmenu_Kapat;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Timer timerOturum;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.StatusStrip statusStripDurum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_sure;
        private System.Windows.Forms.ToolStripProgressBar tspgbr_sure;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}
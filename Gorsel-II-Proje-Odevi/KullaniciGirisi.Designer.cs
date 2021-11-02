namespace Gorsel_II_Proje_Odevi
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            this.chbx_beniHatirla = new System.Windows.Forms.CheckBox();
            this.chbx_sifreGoster = new System.Windows.Forms.CheckBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            this.chbx_windowsIleBaslama = new MetroFramework.Controls.MetroCheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbx_beniHatirla
            // 
            this.chbx_beniHatirla.AutoSize = true;
            this.chbx_beniHatirla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_beniHatirla.Location = new System.Drawing.Point(97, 225);
            this.chbx_beniHatirla.Name = "chbx_beniHatirla";
            this.chbx_beniHatirla.Size = new System.Drawing.Size(83, 17);
            this.chbx_beniHatirla.TabIndex = 12;
            this.chbx_beniHatirla.Text = "Beni Hatırla:";
            this.tt_basvuru.SetToolTip(this.chbx_beniHatirla, "Beni Hatırla");
            this.chbx_beniHatirla.UseVisualStyleBackColor = true;
            this.chbx_beniHatirla.CheckedChanged += new System.EventHandler(this.chbx_beniHatirla_CheckedChanged);
            // 
            // chbx_sifreGoster
            // 
            this.chbx_sifreGoster.AutoSize = true;
            this.chbx_sifreGoster.Location = new System.Drawing.Point(286, 201);
            this.chbx_sifreGoster.Name = "chbx_sifreGoster";
            this.chbx_sifreGoster.Size = new System.Drawing.Size(88, 17);
            this.chbx_sifreGoster.TabIndex = 11;
            this.chbx_sifreGoster.Text = "Şifreyi Göster";
            this.chbx_sifreGoster.UseVisualStyleBackColor = true;
            this.chbx_sifreGoster.CheckedChanged += new System.EventHandler(this.chbx_sifreGoster_CheckedChanged);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(168, 199);
            this.tx_sifre.MaxLength = 64;
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 10;
            this.tt_basvuru.SetToolTip(this.tx_sifre, "Şifre");
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(168, 173);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tx_tcNo.TabIndex = 9;
            this.tt_basvuru.SetToolTip(this.tx_tcNo, "TC No ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tc No:";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(183, 249);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Location = new System.Drawing.Point(286, 249);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_Kapat.TabIndex = 13;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntx_Goster,
            this.cntx_Gizle,
            this.cntx_Kapat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 70);
            // 
            // cntx_Goster
            // 
            this.cntx_Goster.Name = "cntx_Goster";
            this.cntx_Goster.Size = new System.Drawing.Size(108, 22);
            this.cntx_Goster.Text = "Göster";
            this.cntx_Goster.Click += new System.EventHandler(this.cntx_Goster_Click);
            // 
            // cntx_Gizle
            // 
            this.cntx_Gizle.Name = "cntx_Gizle";
            this.cntx_Gizle.Size = new System.Drawing.Size(108, 22);
            this.cntx_Gizle.Text = "Gizle";
            this.cntx_Gizle.Click += new System.EventHandler(this.cntx_Gizle_Click);
            // 
            // cntx_Kapat
            // 
            this.cntx_Kapat.Name = "cntx_Kapat";
            this.cntx_Kapat.Size = new System.Drawing.Size(108, 22);
            this.cntx_Kapat.Text = "Kapat";
            this.cntx_Kapat.Click += new System.EventHandler(this.cntx_Kapat_Click);
            // 
            // notifyIconBanka
            // 
            this.notifyIconBanka.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconBanka.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBanka.Icon")));
            this.notifyIconBanka.Text = "Kullanıcı Girişi";
            this.notifyIconBanka.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gorsel_II_Proje_Odevi.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(183, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // chbx_windowsIleBaslama
            // 
            this.chbx_windowsIleBaslama.AutoSize = true;
            this.chbx_windowsIleBaslama.Location = new System.Drawing.Point(334, 22);
            this.chbx_windowsIleBaslama.Name = "chbx_windowsIleBaslama";
            this.chbx_windowsIleBaslama.Size = new System.Drawing.Size(132, 15);
            this.chbx_windowsIleBaslama.TabIndex = 15;
            this.chbx_windowsIleBaslama.Text = "Windows ile başlasın";
            this.chbx_windowsIleBaslama.UseSelectable = true;
            this.chbx_windowsIleBaslama.CheckedChanged += new System.EventHandler(this.chbx_windowsIleBaslama_CheckedChanged);
            // 
            // KullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 372);
            this.Controls.Add(this.chbx_windowsIleBaslama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.chbx_beniHatirla);
            this.Controls.Add(this.chbx_sifreGoster);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGirisi";
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciGirisi_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciGirisi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbx_beniHatirla;
        private System.Windows.Forms.CheckBox chbx_sifreGoster;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tt_basvuru;
        private MetroFramework.Controls.MetroCheckBox chbx_windowsIleBaslama;
    }
}
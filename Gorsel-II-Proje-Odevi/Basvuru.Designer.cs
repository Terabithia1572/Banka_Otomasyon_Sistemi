namespace Gorsel_II_Proje_Odevi
{
    partial class Basvuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basvuru));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_Basvurular = new System.Windows.Forms.DataGridView();
            this.cbx_BasvuruTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Musteri = new System.Windows.Forms.ComboBox();
            this.cbx_SubeAdresi = new System.Windows.Forms.ComboBox();
            this.cbx_MusteriTur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_basvuruDurum = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basvurular)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri :";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(434, 46);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 53);
            this.btn_Ekle.TabIndex = 6;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(524, 46);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 53);
            this.btn_Guncelle.TabIndex = 6;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(434, 114);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 52);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(524, 114);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(74, 52);
            this.btn_Temizle.TabIndex = 6;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_Basvurular
            // 
            this.dgv_Basvurular.AllowUserToAddRows = false;
            this.dgv_Basvurular.AllowUserToDeleteRows = false;
            this.dgv_Basvurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Basvurular.Location = new System.Drawing.Point(29, 379);
            this.dgv_Basvurular.MultiSelect = false;
            this.dgv_Basvurular.Name = "dgv_Basvurular";
            this.dgv_Basvurular.ReadOnly = true;
            this.dgv_Basvurular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Basvurular.Size = new System.Drawing.Size(644, 197);
            this.dgv_Basvurular.TabIndex = 7;
            this.dgv_Basvurular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Basvurular_CellDoubleClick);
            // 
            // cbx_BasvuruTur
            // 
            this.cbx_BasvuruTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BasvuruTur.FormattingEnabled = true;
            this.cbx_BasvuruTur.Location = new System.Drawing.Point(108, 250);
            this.cbx_BasvuruTur.Name = "cbx_BasvuruTur";
            this.cbx_BasvuruTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_BasvuruTur.TabIndex = 8;
            this.tt_basvuru.SetToolTip(this.cbx_BasvuruTur, "Seç");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Başvuru Türü:";
            // 
            // cbx_Musteri
            // 
            this.cbx_Musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Musteri.FormattingEnabled = true;
            this.cbx_Musteri.Location = new System.Drawing.Point(81, 56);
            this.cbx_Musteri.Name = "cbx_Musteri";
            this.cbx_Musteri.Size = new System.Drawing.Size(253, 21);
            this.cbx_Musteri.TabIndex = 10;
            this.tt_basvuru.SetToolTip(this.cbx_Musteri, "Seçim Yap la");
            // 
            // cbx_SubeAdresi
            // 
            this.cbx_SubeAdresi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SubeAdresi.FormattingEnabled = true;
            this.cbx_SubeAdresi.Location = new System.Drawing.Point(416, 221);
            this.cbx_SubeAdresi.Name = "cbx_SubeAdresi";
            this.cbx_SubeAdresi.Size = new System.Drawing.Size(121, 21);
            this.cbx_SubeAdresi.TabIndex = 22;
            this.tt_basvuru.SetToolTip(this.cbx_SubeAdresi, "Şube Adresi Seç");
            // 
            // cbx_MusteriTur
            // 
            this.cbx_MusteriTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MusteriTur.FormattingEnabled = true;
            this.cbx_MusteriTur.Location = new System.Drawing.Point(108, 277);
            this.cbx_MusteriTur.Name = "cbx_MusteriTur";
            this.cbx_MusteriTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_MusteriTur.TabIndex = 19;
            this.tt_basvuru.SetToolTip(this.cbx_MusteriTur, "Seç");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Şube Adresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Başvuru Durumu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Müşteri Türü:";
            // 
            // cbx_basvuruDurum
            // 
            this.cbx_basvuruDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_basvuruDurum.FormattingEnabled = true;
            this.cbx_basvuruDurum.Location = new System.Drawing.Point(103, 99);
            this.cbx_basvuruDurum.Name = "cbx_basvuruDurum";
            this.cbx_basvuruDurum.Size = new System.Drawing.Size(121, 21);
            this.cbx_basvuruDurum.TabIndex = 10;
            this.tt_basvuru.SetToolTip(this.cbx_basvuruDurum, "Seç ya da Yol al");
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.CustomFormat = "MM:dd:yyyy";
            this.dtp_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tarih.Location = new System.Drawing.Point(81, 153);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_tarih.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih:";
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
            this.notifyIconBanka.Text = "Başvuru İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // Basvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 606);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.cbx_SubeAdresi);
            this.Controls.Add(this.cbx_MusteriTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_basvuruDurum);
            this.Controls.Add(this.cbx_Musteri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_BasvuruTur);
            this.Controls.Add(this.dgv_Basvurular);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basvuru";
            this.Text = "Başvuru İşlemleri";
            this.Load += new System.EventHandler(this.Basvuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basvurular)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_Basvurular;
        private System.Windows.Forms.ComboBox cbx_BasvuruTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Musteri;
        private System.Windows.Forms.ComboBox cbx_SubeAdresi;
        private System.Windows.Forms.ComboBox cbx_MusteriTur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_basvuruDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
    }
}
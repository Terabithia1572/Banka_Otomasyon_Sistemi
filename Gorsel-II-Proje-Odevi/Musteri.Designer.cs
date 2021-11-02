namespace Gorsel_II_Proje_Odevi
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_Ad = new System.Windows.Forms.TextBox();
            this.tx_Soyad = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_Musteriler = new System.Windows.Forms.DataGridView();
            this.cbx_musteriTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_TC = new System.Windows.Forms.TextBox();
            this.tx_Telefon = new System.Windows.Forms.TextBox();
            this.tx_Adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // tx_Ad
            // 
            this.tx_Ad.Location = new System.Drawing.Point(234, 55);
            this.tx_Ad.Name = "tx_Ad";
            this.tx_Ad.Size = new System.Drawing.Size(100, 20);
            this.tx_Ad.TabIndex = 3;
            this.tt_basvuru.SetToolTip(this.tx_Ad, "En az 2 Karakter");
            this.tx_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Ad_KeyPress);
            // 
            // tx_Soyad
            // 
            this.tx_Soyad.Location = new System.Drawing.Point(234, 93);
            this.tx_Soyad.Name = "tx_Soyad";
            this.tx_Soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_Soyad.TabIndex = 3;
            this.tt_basvuru.SetToolTip(this.tx_Soyad, "En az 2 Karakter");
            this.tx_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Soyad_KeyPress);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(484, 55);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 47);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(588, 55);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 47);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(484, 114);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 47);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(588, 114);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 47);
            this.btn_Temizle.TabIndex = 7;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_Musteriler
            // 
            this.dgv_Musteriler.AllowUserToAddRows = false;
            this.dgv_Musteriler.AllowUserToDeleteRows = false;
            this.dgv_Musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Musteriler.Location = new System.Drawing.Point(151, 251);
            this.dgv_Musteriler.MultiSelect = false;
            this.dgv_Musteriler.Name = "dgv_Musteriler";
            this.dgv_Musteriler.ReadOnly = true;
            this.dgv_Musteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Musteriler.Size = new System.Drawing.Size(524, 150);
            this.dgv_Musteriler.TabIndex = 8;
            this.dgv_Musteriler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Musteriler_CellContentDoubleClick);
            // 
            // cbx_musteriTur
            // 
            this.cbx_musteriTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_musteriTur.FormattingEnabled = true;
            this.cbx_musteriTur.Location = new System.Drawing.Point(234, 207);
            this.cbx_musteriTur.Name = "cbx_musteriTur";
            this.cbx_musteriTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_musteriTur.TabIndex = 9;
            this.tt_basvuru.SetToolTip(this.cbx_musteriTur, "Seç");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon:";
            // 
            // tx_TC
            // 
            this.tx_TC.Location = new System.Drawing.Point(234, 124);
            this.tx_TC.MaxLength = 11;
            this.tx_TC.Name = "tx_TC";
            this.tx_TC.Size = new System.Drawing.Size(100, 20);
            this.tx_TC.TabIndex = 3;
            this.tt_basvuru.SetToolTip(this.tx_TC, "11 Karakter ");
            this.tx_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_TC_KeyPress);
            // 
            // tx_Telefon
            // 
            this.tx_Telefon.Location = new System.Drawing.Point(234, 150);
            this.tx_Telefon.MaxLength = 11;
            this.tx_Telefon.Name = "tx_Telefon";
            this.tx_Telefon.Size = new System.Drawing.Size(100, 20);
            this.tx_Telefon.TabIndex = 3;
            this.tt_basvuru.SetToolTip(this.tx_Telefon, "11 KArakter");
            this.tx_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Telefon_KeyPress);
            // 
            // tx_Adres
            // 
            this.tx_Adres.Location = new System.Drawing.Point(234, 183);
            this.tx_Adres.Name = "tx_Adres";
            this.tx_Adres.Size = new System.Drawing.Size(100, 20);
            this.tx_Adres.TabIndex = 3;
            this.tt_basvuru.SetToolTip(this.tx_Adres, "Adres Giriniz");
            this.tx_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Adres_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres:";
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
            this.notifyIconBanka.Text = "Müşteri İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_musteriTur);
            this.Controls.Add(this.dgv_Musteriler);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tx_Adres);
            this.Controls.Add(this.tx_Telefon);
            this.Controls.Add(this.tx_TC);
            this.Controls.Add(this.tx_Soyad);
            this.Controls.Add(this.tx_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_Ad;
        private System.Windows.Forms.TextBox tx_Soyad;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_Musteriler;
        private System.Windows.Forms.ComboBox cbx_musteriTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_TC;
        private System.Windows.Forms.TextBox tx_Telefon;
        private System.Windows.Forms.TextBox tx_Adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
    }
}
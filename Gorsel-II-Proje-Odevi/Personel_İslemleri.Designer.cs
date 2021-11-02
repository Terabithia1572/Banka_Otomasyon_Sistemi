namespace Gorsel_II_Proje_Odevi
{
    partial class Personel_İslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_İslemleri));
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_Ad = new System.Windows.Forms.TextBox();
            this.tx_Soyad = new System.Windows.Forms.TextBox();
            this.tx_TC = new System.Windows.Forms.TextBox();
            this.tx_Gorevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_subeAd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_perTur = new System.Windows.Forms.ComboBox();
            this.dgv_perTur = new System.Windows.Forms.DataGridView();
            this.tx_Adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_Telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perTur)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(565, 122);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 47);
            this.btn_Temizle.TabIndex = 43;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(461, 122);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 47);
            this.btn_Sil.TabIndex = 42;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(565, 63);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 47);
            this.btn_Guncelle.TabIndex = 41;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(461, 63);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 47);
            this.btn_Ekle.TabIndex = 40;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Görevi:";
            // 
            // tx_Ad
            // 
            this.tx_Ad.Location = new System.Drawing.Point(219, 63);
            this.tx_Ad.Name = "tx_Ad";
            this.tx_Ad.Size = new System.Drawing.Size(100, 20);
            this.tx_Ad.TabIndex = 48;
            this.tt_basvuru.SetToolTip(this.tx_Ad, "En az 2 Karakter");
            this.tx_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Ad_KeyPress);
            // 
            // tx_Soyad
            // 
            this.tx_Soyad.Location = new System.Drawing.Point(219, 99);
            this.tx_Soyad.Name = "tx_Soyad";
            this.tx_Soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_Soyad.TabIndex = 48;
            this.tt_basvuru.SetToolTip(this.tx_Soyad, "En az 2 KArakter");
            this.tx_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Soyad_KeyPress);
            // 
            // tx_TC
            // 
            this.tx_TC.Location = new System.Drawing.Point(219, 136);
            this.tx_TC.MaxLength = 11;
            this.tx_TC.Name = "tx_TC";
            this.tx_TC.Size = new System.Drawing.Size(100, 20);
            this.tx_TC.TabIndex = 48;
            this.tt_basvuru.SetToolTip(this.tx_TC, "11 Karakter");
            this.tx_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_TC_KeyPress);
            // 
            // tx_Gorevi
            // 
            this.tx_Gorevi.Location = new System.Drawing.Point(219, 175);
            this.tx_Gorevi.Name = "tx_Gorevi";
            this.tx_Gorevi.Size = new System.Drawing.Size(100, 20);
            this.tx_Gorevi.TabIndex = 48;
            this.tt_basvuru.SetToolTip(this.tx_Gorevi, "En az 2 Karakter");
            this.tx_Gorevi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Gorevi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Şube Adı:";
            // 
            // cbx_subeAd
            // 
            this.cbx_subeAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_subeAd.FormattingEnabled = true;
            this.cbx_subeAd.Location = new System.Drawing.Point(219, 227);
            this.cbx_subeAd.Name = "cbx_subeAd";
            this.cbx_subeAd.Size = new System.Drawing.Size(121, 21);
            this.cbx_subeAd.TabIndex = 50;
            this.tt_basvuru.SetToolTip(this.cbx_subeAd, "Seç");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Personel Türü:";
            // 
            // cbx_perTur
            // 
            this.cbx_perTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_perTur.FormattingEnabled = true;
            this.cbx_perTur.Location = new System.Drawing.Point(219, 270);
            this.cbx_perTur.Name = "cbx_perTur";
            this.cbx_perTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_perTur.TabIndex = 52;
            this.tt_basvuru.SetToolTip(this.cbx_perTur, "Seç");
            // 
            // dgv_perTur
            // 
            this.dgv_perTur.AllowUserToAddRows = false;
            this.dgv_perTur.AllowUserToDeleteRows = false;
            this.dgv_perTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perTur.Location = new System.Drawing.Point(135, 320);
            this.dgv_perTur.Name = "dgv_perTur";
            this.dgv_perTur.ReadOnly = true;
            this.dgv_perTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_perTur.Size = new System.Drawing.Size(580, 149);
            this.dgv_perTur.TabIndex = 53;
            this.dgv_perTur.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_perTur_CellContentDoubleClick);
            // 
            // tx_Adres
            // 
            this.tx_Adres.Location = new System.Drawing.Point(551, 220);
            this.tx_Adres.Name = "tx_Adres";
            this.tx_Adres.Size = new System.Drawing.Size(100, 20);
            this.tx_Adres.TabIndex = 55;
            this.tx_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Adres_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Adres:";
            // 
            // tx_Telefon
            // 
            this.tx_Telefon.Location = new System.Drawing.Point(551, 246);
            this.tx_Telefon.MaxLength = 11;
            this.tx_Telefon.Name = "tx_Telefon";
            this.tx_Telefon.Size = new System.Drawing.Size(100, 20);
            this.tx_Telefon.TabIndex = 57;
            this.tx_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Telefon_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Telefon:";
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
            this.notifyIconBanka.Text = "Fatura İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // Personel_İslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 510);
            this.Controls.Add(this.tx_Telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_Adres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_perTur);
            this.Controls.Add(this.cbx_perTur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_subeAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_Gorevi);
            this.Controls.Add(this.tx_TC);
            this.Controls.Add(this.tx_Soyad);
            this.Controls.Add(this.tx_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel_İslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.Personel_İslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perTur)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_Ad;
        private System.Windows.Forms.TextBox tx_Soyad;
        private System.Windows.Forms.TextBox tx_TC;
        private System.Windows.Forms.TextBox tx_Gorevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_subeAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_perTur;
        private System.Windows.Forms.DataGridView dgv_perTur;
        private System.Windows.Forms.TextBox tx_Adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_Telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
    }
}
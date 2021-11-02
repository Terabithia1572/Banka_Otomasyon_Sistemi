namespace Gorsel_II_Proje_Odevi
{
    partial class Kart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kart));
            this.tx_CVC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Kart = new System.Windows.Forms.DataGridView();
            this.cbx_kartTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.cbx_adSoyad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_hesapDurumu = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            this.tx_kartNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_CVC
            // 
            this.tx_CVC.Location = new System.Drawing.Point(152, 93);
            this.tx_CVC.MaxLength = 3;
            this.tx_CVC.Name = "tx_CVC";
            this.tx_CVC.Size = new System.Drawing.Size(100, 20);
            this.tx_CVC.TabIndex = 41;
            this.tt_basvuru.SetToolTip(this.tx_CVC, "3 Karakter");
            this.tx_CVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_CVC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "CVC:";
            // 
            // dgv_Kart
            // 
            this.dgv_Kart.AllowUserToAddRows = false;
            this.dgv_Kart.AllowUserToDeleteRows = false;
            this.dgv_Kart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kart.Location = new System.Drawing.Point(129, 327);
            this.dgv_Kart.MultiSelect = false;
            this.dgv_Kart.Name = "dgv_Kart";
            this.dgv_Kart.ReadOnly = true;
            this.dgv_Kart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kart.Size = new System.Drawing.Size(530, 150);
            this.dgv_Kart.TabIndex = 39;
            this.dgv_Kart.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kart_CellContentDoubleClick);
            // 
            // cbx_kartTur
            // 
            this.cbx_kartTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_kartTur.FormattingEnabled = true;
            this.cbx_kartTur.Location = new System.Drawing.Point(152, 132);
            this.cbx_kartTur.Name = "cbx_kartTur";
            this.cbx_kartTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_kartTur.TabIndex = 34;
            this.tt_basvuru.SetToolTip(this.cbx_kartTur, "Seç");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kart Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tarih:";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(152, 166);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_tarih.TabIndex = 43;
            this.tt_basvuru.SetToolTip(this.dtp_tarih, "Tarih");
            // 
            // cbx_adSoyad
            // 
            this.cbx_adSoyad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_adSoyad.FormattingEnabled = true;
            this.cbx_adSoyad.Location = new System.Drawing.Point(193, 37);
            this.cbx_adSoyad.Name = "cbx_adSoyad";
            this.cbx_adSoyad.Size = new System.Drawing.Size(121, 21);
            this.cbx_adSoyad.TabIndex = 46;
            this.tt_basvuru.SetToolTip(this.cbx_adSoyad, "Seç");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Aktiflik Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "kart no:";
            // 
            // cbx_hesapDurumu
            // 
            this.cbx_hesapDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_hesapDurumu.FormattingEnabled = true;
            this.cbx_hesapDurumu.Location = new System.Drawing.Point(193, 63);
            this.cbx_hesapDurumu.Name = "cbx_hesapDurumu";
            this.cbx_hesapDurumu.Size = new System.Drawing.Size(121, 21);
            this.cbx_hesapDurumu.TabIndex = 50;
            this.tt_basvuru.SetToolTip(this.cbx_hesapDurumu, "Seç");
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
            this.notifyIconBanka.Text = "Kart İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(501, 64);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 38;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(406, 64);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 37;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(406, 107);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 36;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(501, 107);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 35;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // tx_kartNo
            // 
            this.tx_kartNo.Location = new System.Drawing.Point(155, 235);
            this.tx_kartNo.MaxLength = 3;
            this.tx_kartNo.Name = "tx_kartNo";
            this.tx_kartNo.Size = new System.Drawing.Size(100, 20);
            this.tx_kartNo.TabIndex = 41;
            this.tx_kartNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_CVC_KeyPress);
            // 
            // Kart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 460);
            this.Controls.Add(this.cbx_hesapDurumu);
            this.Controls.Add(this.cbx_adSoyad);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_kartNo);
            this.Controls.Add(this.tx_CVC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Kart);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cbx_kartTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kart";
            this.Text = "Kart";
            this.Load += new System.EventHandler(this.Kart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_CVC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Kart;
        private System.Windows.Forms.ComboBox cbx_kartTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ComboBox cbx_adSoyad;
        private System.Windows.Forms.CheckBox chbx_aktifMi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_musteriTur;
        private System.Windows.Forms.ComboBox cbx_hesapDurumu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Temizle;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
        private System.Windows.Forms.TextBox tx_kartNo;
    }
}
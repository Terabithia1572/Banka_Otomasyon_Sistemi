namespace Gorsel_II_Proje_Odevi
{
    partial class Eft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eft));
            this.dgv_Eft = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cbx_transferTur = new System.Windows.Forms.ComboBox();
            this.cbx_gonderenHesap = new System.Windows.Forms.ComboBox();
            this.tx_soyAd = new System.Windows.Forms.TextBox();
            this.tx_Ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_aliciİban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eft)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Eft
            // 
            this.dgv_Eft.AllowUserToAddRows = false;
            this.dgv_Eft.AllowUserToDeleteRows = false;
            this.dgv_Eft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Eft.Location = new System.Drawing.Point(91, 208);
            this.dgv_Eft.MultiSelect = false;
            this.dgv_Eft.Name = "dgv_Eft";
            this.dgv_Eft.ReadOnly = true;
            this.dgv_Eft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Eft.Size = new System.Drawing.Size(530, 150);
            this.dgv_Eft.TabIndex = 21;
            this.dgv_Eft.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Eft_CellContentDoubleClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(473, 80);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 17;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(378, 80);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(378, 37);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 19;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(473, 37);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 20;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cbx_transferTur
            // 
            this.cbx_transferTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_transferTur.FormattingEnabled = true;
            this.cbx_transferTur.Location = new System.Drawing.Point(159, 134);
            this.cbx_transferTur.Name = "cbx_transferTur";
            this.cbx_transferTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_transferTur.TabIndex = 15;
            this.tt_basvuru.SetToolTip(this.cbx_transferTur, "Seç");
            // 
            // cbx_gonderenHesap
            // 
            this.cbx_gonderenHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_gonderenHesap.FormattingEnabled = true;
            this.cbx_gonderenHesap.Location = new System.Drawing.Point(159, 106);
            this.cbx_gonderenHesap.Name = "cbx_gonderenHesap";
            this.cbx_gonderenHesap.Size = new System.Drawing.Size(121, 21);
            this.cbx_gonderenHesap.TabIndex = 16;
            this.tt_basvuru.SetToolTip(this.cbx_gonderenHesap, "Seç");
            // 
            // tx_soyAd
            // 
            this.tx_soyAd.AcceptsTab = true;
            this.tx_soyAd.Location = new System.Drawing.Point(159, 39);
            this.tx_soyAd.MaxLength = 13;
            this.tx_soyAd.Name = "tx_soyAd";
            this.tx_soyAd.Size = new System.Drawing.Size(100, 20);
            this.tx_soyAd.TabIndex = 12;
            this.tt_basvuru.SetToolTip(this.tx_soyAd, "En Az 2 Hane");
            this.tx_soyAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyAd_KeyPress);
            // 
            // tx_Ad
            // 
            this.tx_Ad.AcceptsTab = true;
            this.tx_Ad.Location = new System.Drawing.Point(159, 10);
            this.tx_Ad.MaxLength = 5;
            this.tx_Ad.Name = "tx_Ad";
            this.tx_Ad.Size = new System.Drawing.Size(100, 20);
            this.tx_Ad.TabIndex = 13;
            this.tt_basvuru.SetToolTip(this.tx_Ad, "En az 2 Hane");
            this.tx_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Ad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transfer Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gönderen Hesap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad:";
            // 
            // tx_aliciİban
            // 
            this.tx_aliciİban.AcceptsTab = true;
            this.tx_aliciİban.Location = new System.Drawing.Point(159, 65);
            this.tx_aliciİban.MaxLength = 16;
            this.tx_aliciİban.Name = "tx_aliciİban";
            this.tx_aliciİban.Size = new System.Drawing.Size(100, 20);
            this.tx_aliciİban.TabIndex = 26;
            this.tt_basvuru.SetToolTip(this.tx_aliciİban, "En az 16 Hane");
            this.tx_aliciİban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_aliciİban_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Alıcı İban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tarih:";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(448, 142);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_tarih.TabIndex = 29;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntx_Goster,
            this.cntx_Gizle,
            this.cntx_Kapat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // cntx_Goster
            // 
            this.cntx_Goster.Name = "cntx_Goster";
            this.cntx_Goster.Size = new System.Drawing.Size(152, 22);
            this.cntx_Goster.Text = "Göster";
            this.cntx_Goster.Click += new System.EventHandler(this.cntx_Goster_Click);
            // 
            // cntx_Gizle
            // 
            this.cntx_Gizle.Name = "cntx_Gizle";
            this.cntx_Gizle.Size = new System.Drawing.Size(152, 22);
            this.cntx_Gizle.Text = "Gizle";
            this.cntx_Gizle.Click += new System.EventHandler(this.cntx_Gizle_Click);
            // 
            // cntx_Kapat
            // 
            this.cntx_Kapat.Name = "cntx_Kapat";
            this.cntx_Kapat.Size = new System.Drawing.Size(152, 22);
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
            // Eft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.tx_aliciİban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Eft);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cbx_transferTur);
            this.Controls.Add(this.cbx_gonderenHesap);
            this.Controls.Add(this.tx_soyAd);
            this.Controls.Add(this.tx_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eft";
            this.Text = "Eft";
            this.Load += new System.EventHandler(this.Eft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Eft)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Eft;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.ComboBox cbx_transferTur;
        private System.Windows.Forms.ComboBox cbx_gonderenHesap;
        private System.Windows.Forms.TextBox tx_soyAd;
        private System.Windows.Forms.TextBox tx_Ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_aliciİban;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
    }
}
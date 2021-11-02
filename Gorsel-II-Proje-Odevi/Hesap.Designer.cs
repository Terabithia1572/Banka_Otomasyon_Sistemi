namespace Gorsel_II_Proje_Odevi
{
    partial class Hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesap));
            this.dgv_Hesap = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.tx_iban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_hesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_hesapBakiye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_hesapDurum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_musteriAd = new System.Windows.Forms.ComboBox();
            this.cbx_subeNo = new System.Windows.Forms.ComboBox();
            this.cbx_hesapTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hesap)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Hesap
            // 
            this.dgv_Hesap.AllowUserToAddRows = false;
            this.dgv_Hesap.AllowUserToDeleteRows = false;
            this.dgv_Hesap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hesap.Location = new System.Drawing.Point(170, 267);
            this.dgv_Hesap.MultiSelect = false;
            this.dgv_Hesap.Name = "dgv_Hesap";
            this.dgv_Hesap.ReadOnly = true;
            this.dgv_Hesap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Hesap.Size = new System.Drawing.Size(530, 150);
            this.dgv_Hesap.TabIndex = 11;
            this.dgv_Hesap.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hesap_CellContentDoubleClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(592, 158);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 7;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(497, 158);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(497, 115);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 9;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(592, 115);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // tx_iban
            // 
            this.tx_iban.Location = new System.Drawing.Point(192, 60);
            this.tx_iban.MaxLength = 16;
            this.tx_iban.Name = "tx_iban";
            this.tx_iban.Size = new System.Drawing.Size(100, 20);
            this.tx_iban.TabIndex = 12;
            this.tt_basvuru.SetToolTip(this.tx_iban, "En az 16 Haneli");
            this.tx_iban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_iban_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "İban:";
            // 
            // tx_hesapNo
            // 
            this.tx_hesapNo.Location = new System.Drawing.Point(192, 97);
            this.tx_hesapNo.MaxLength = 11;
            this.tx_hesapNo.Name = "tx_hesapNo";
            this.tx_hesapNo.Size = new System.Drawing.Size(100, 20);
            this.tx_hesapNo.TabIndex = 12;
            this.tt_basvuru.SetToolTip(this.tx_hesapNo, "En az 11 Hane");
            this.tx_hesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_hesapNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hesap No:";
            // 
            // tx_hesapBakiye
            // 
            this.tx_hesapBakiye.Location = new System.Drawing.Point(233, 127);
            this.tx_hesapBakiye.MaxLength = 10;
            this.tx_hesapBakiye.Name = "tx_hesapBakiye";
            this.tx_hesapBakiye.Size = new System.Drawing.Size(100, 20);
            this.tx_hesapBakiye.TabIndex = 12;
            this.tt_basvuru.SetToolTip(this.tx_hesapBakiye, "Bakiye Giriniz");
            this.tx_hesapBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_hesapBakiye_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hesap Bakiye";
            // 
            // tx_hesapDurum
            // 
            this.tx_hesapDurum.Location = new System.Drawing.Point(233, 162);
            this.tx_hesapDurum.Name = "tx_hesapDurum";
            this.tx_hesapDurum.Size = new System.Drawing.Size(100, 20);
            this.tx_hesapDurum.TabIndex = 12;
            this.tt_basvuru.SetToolTip(this.tx_hesapDurum, "En Az 2 KArakter");
            this.tx_hesapDurum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_hesapDurum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hesap Durum:";
            // 
            // cbx_musteriAd
            // 
            this.cbx_musteriAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_musteriAd.FormattingEnabled = true;
            this.cbx_musteriAd.Location = new System.Drawing.Point(212, 201);
            this.cbx_musteriAd.Name = "cbx_musteriAd";
            this.cbx_musteriAd.Size = new System.Drawing.Size(121, 21);
            this.cbx_musteriAd.TabIndex = 14;
            this.tt_basvuru.SetToolTip(this.cbx_musteriAd, "Seç");
            // 
            // cbx_subeNo
            // 
            this.cbx_subeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_subeNo.FormattingEnabled = true;
            this.cbx_subeNo.Location = new System.Drawing.Point(212, 228);
            this.cbx_subeNo.Name = "cbx_subeNo";
            this.cbx_subeNo.Size = new System.Drawing.Size(121, 21);
            this.cbx_subeNo.TabIndex = 14;
            this.tt_basvuru.SetToolTip(this.cbx_subeNo, "Seç");
            // 
            // cbx_hesapTur
            // 
            this.cbx_hesapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_hesapTur.FormattingEnabled = true;
            this.cbx_hesapTur.Location = new System.Drawing.Point(464, 212);
            this.cbx_hesapTur.Name = "cbx_hesapTur";
            this.cbx_hesapTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_hesapTur.TabIndex = 14;
            this.tt_basvuru.SetToolTip(this.cbx_hesapTur, "Seç");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Müşteri Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Şube No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hesap Türü:";
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
            this.notifyIconBanka.Text = "Hesap İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 440);
            this.Controls.Add(this.cbx_hesapTur);
            this.Controls.Add(this.cbx_subeNo);
            this.Controls.Add(this.cbx_musteriAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_hesapDurum);
            this.Controls.Add(this.tx_hesapBakiye);
            this.Controls.Add(this.tx_hesapNo);
            this.Controls.Add(this.tx_iban);
            this.Controls.Add(this.dgv_Hesap);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hesap";
            this.Text = "Hesap İşlemleri";
            this.Load += new System.EventHandler(this.Hesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hesap)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Hesap;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox tx_iban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_hesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_hesapBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_hesapDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_musteriAd;
        private System.Windows.Forms.ComboBox cbx_subeNo;
        private System.Windows.Forms.ComboBox cbx_hesapTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
    }
}
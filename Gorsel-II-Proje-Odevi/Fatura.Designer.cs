namespace Gorsel_II_Proje_Odevi
{
    partial class Fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Miktar = new System.Windows.Forms.TextBox();
            this.tx_FaturaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_FaturaTur = new System.Windows.Forms.ComboBox();
            this.cbx_HesapNo = new System.Windows.Forms.ComboBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_Faturalar = new System.Windows.Forms.DataGridView();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Faturalar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fatura No:";
            // 
            // tx_Miktar
            // 
            this.tx_Miktar.Location = new System.Drawing.Point(190, 16);
            this.tx_Miktar.MaxLength = 5;
            this.tx_Miktar.Name = "tx_Miktar";
            this.tx_Miktar.Size = new System.Drawing.Size(100, 20);
            this.tx_Miktar.TabIndex = 1;
            this.tt_basvuru.SetToolTip(this.tx_Miktar, "Lütfen Miktar Giriniz");
            this.tx_Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Miktar_KeyPress);
            // 
            // tx_FaturaNo
            // 
            this.tx_FaturaNo.Location = new System.Drawing.Point(188, 45);
            this.tx_FaturaNo.MaxLength = 13;
            this.tx_FaturaNo.Name = "tx_FaturaNo";
            this.tx_FaturaNo.Size = new System.Drawing.Size(100, 20);
            this.tx_FaturaNo.TabIndex = 1;
            this.tt_basvuru.SetToolTip(this.tx_FaturaNo, "Fatura No  Hane");
            this.tx_FaturaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_FaturaNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fatura Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hesap No:";
            // 
            // cbx_FaturaTur
            // 
            this.cbx_FaturaTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FaturaTur.FormattingEnabled = true;
            this.cbx_FaturaTur.Location = new System.Drawing.Point(187, 74);
            this.cbx_FaturaTur.Name = "cbx_FaturaTur";
            this.cbx_FaturaTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_FaturaTur.TabIndex = 4;
            this.tt_basvuru.SetToolTip(this.cbx_FaturaTur, "Seç");
            // 
            // cbx_HesapNo
            // 
            this.cbx_HesapNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_HesapNo.FormattingEnabled = true;
            this.cbx_HesapNo.Location = new System.Drawing.Point(187, 102);
            this.cbx_HesapNo.Name = "cbx_HesapNo";
            this.cbx_HesapNo.Size = new System.Drawing.Size(121, 21);
            this.cbx_HesapNo.TabIndex = 4;
            this.tt_basvuru.SetToolTip(this.cbx_HesapNo, "Seç");
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(504, 43);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(409, 43);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(409, 86);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(504, 86);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 5;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_Faturalar
            // 
            this.dgv_Faturalar.AllowUserToAddRows = false;
            this.dgv_Faturalar.AllowUserToDeleteRows = false;
            this.dgv_Faturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Faturalar.Location = new System.Drawing.Point(166, 226);
            this.dgv_Faturalar.MultiSelect = false;
            this.dgv_Faturalar.Name = "dgv_Faturalar";
            this.dgv_Faturalar.ReadOnly = true;
            this.dgv_Faturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Faturalar.Size = new System.Drawing.Size(530, 150);
            this.dgv_Faturalar.TabIndex = 6;
            this.dgv_Faturalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Faturalar_CellDoubleClick);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tarih.Location = new System.Drawing.Point(189, 133);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(100, 20);
            this.dtp_tarih.TabIndex = 7;
            this.tt_basvuru.SetToolTip(this.dtp_tarih, "Tarih");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tarih:";
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
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 390);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.dgv_Faturalar);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cbx_HesapNo);
            this.Controls.Add(this.cbx_FaturaTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_FaturaNo);
            this.Controls.Add(this.tx_Miktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Faturalar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Miktar;
        private System.Windows.Forms.TextBox tx_FaturaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_FaturaTur;
        private System.Windows.Forms.ComboBox cbx_HesapNo;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_Faturalar;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
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
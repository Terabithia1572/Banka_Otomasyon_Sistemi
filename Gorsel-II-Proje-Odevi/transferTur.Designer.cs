namespace Gorsel_II_Proje_Odevi
{
    partial class transferTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferTur));
            this.dgv_transferTur = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.tx_transferTur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntx_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Gizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cntx_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconBanka = new System.Windows.Forms.NotifyIcon(this.components);
            this.tt_basvuru = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transferTur)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_transferTur
            // 
            this.dgv_transferTur.AllowUserToAddRows = false;
            this.dgv_transferTur.AllowUserToDeleteRows = false;
            this.dgv_transferTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transferTur.Location = new System.Drawing.Point(166, 137);
            this.dgv_transferTur.Name = "dgv_transferTur";
            this.dgv_transferTur.ReadOnly = true;
            this.dgv_transferTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transferTur.Size = new System.Drawing.Size(209, 118);
            this.dgv_transferTur.TabIndex = 26;
            this.dgv_transferTur.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transferTur_CellContentDoubleClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(433, 72);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 47);
            this.btn_Temizle.TabIndex = 25;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(329, 72);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 47);
            this.btn_Sil.TabIndex = 24;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(433, 13);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 47);
            this.btn_Guncelle.TabIndex = 23;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(329, 13);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 47);
            this.btn_Ekle.TabIndex = 22;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tx_transferTur
            // 
            this.tx_transferTur.Location = new System.Drawing.Point(166, 86);
            this.tx_transferTur.Name = "tx_transferTur";
            this.tx_transferTur.Size = new System.Drawing.Size(100, 20);
            this.tx_transferTur.TabIndex = 21;
            this.tt_basvuru.SetToolTip(this.tx_transferTur, "En az 2 KArakter");
            this.tx_transferTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_transferTur_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Transfer Türü:";
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
            this.notifyIconBanka.Text = "Transfer Tür İşlemleri";
            this.notifyIconBanka.Visible = true;
            // 
            // transferTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 278);
            this.Controls.Add(this.dgv_transferTur);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tx_transferTur);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transferTur";
            this.Text = "Transfer Tür İşlemleri";
            this.Load += new System.EventHandler(this.transferTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transferTur)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transferTur;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox tx_transferTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntx_Goster;
        private System.Windows.Forms.ToolStripMenuItem cntx_Gizle;
        private System.Windows.Forms.ToolStripMenuItem cntx_Kapat;
        private System.Windows.Forms.NotifyIcon notifyIconBanka;
        public System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ToolTip tt_basvuru;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;

namespace Gorsel_II_Proje_Odevi
{
    public partial class FaturaTur : MetroFramework.Forms.MetroForm
    {
        public FaturaTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void FaturaTur_Load(object sender, EventArgs e)
        {
            dgv_faturaTur.DataSource = vt.Select(@"select faturaTur_id,faturaTur from tbl_faturaTur");
            dgv_faturaTur.Columns["faturaTur_id"].Visible = false;
        }

        private void dgv_faturaTur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_faturaTur.SelectedRows.Count == 0)
                return;
            tx_faturaTur.Text = dgv_faturaTur.SelectedRows[0].Cells["faturaTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_faturaTur.Text = "";

            if (dgv_faturaTur.SelectedRows.Count > 0)
                dgv_faturaTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_faturaTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Fatura Türü En az 2 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_faturaTur(faturaTur)values('" + tx_faturaTur.Text + "')");
            FaturaTur_Load(null, null);
            MessageBox.Show("Fatura Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_faturaTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Fatura Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_faturaTur where faturaTur_id=" + dgv_faturaTur.SelectedRows[0].Cells["faturaTur_id"].Value);
            FaturaTur_Load(null, null);
            MessageBox.Show(kayitsay + " Fatura Türü Silindi...");
        }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
   }
        

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_faturaTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Fatura Türü En az 2 Karakter Olmalıdır..");
                return;
            }
            if (dgv_faturaTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_faturaTur set faturaTur='" + tx_faturaTur.Text + "' where faturaTur_id=" + dgv_faturaTur.SelectedRows[0].Cells["faturaTur_id"].Value);
            if (kayitsay > 0)
            {
                FaturaTur_Load(null, null);
                MessageBox.Show("Fatura Türü Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_faturaTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void cntx_Goster_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cntx_Gizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cntx_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

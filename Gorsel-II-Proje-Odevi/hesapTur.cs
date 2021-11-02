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
    public partial class hesapTur : MetroFramework.Forms.MetroForm
    {
        public hesapTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void hesapTur_Load(object sender, EventArgs e)
        {
            dgv_hesapTur.DataSource = vt.Select(@"select hesapTur_id,hesapTur from tbl_hesapTur");
            dgv_hesapTur.Columns["hesapTur_id"].Visible = false;
        }

        private void dgv_hesapTur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hesapTur.SelectedRows.Count == 0)
                return;
            tx_hesapTur.Text = dgv_hesapTur.SelectedRows[0].Cells["hesapTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {

            tx_hesapTur.Text = "";

            if (dgv_hesapTur.SelectedRows.Count > 0)
                dgv_hesapTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_hesapTur.Text.Trim().Length < 5)
            {
                MessageBox.Show("Hesap Türü En az 5 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_hesapTur(hesapTur)values('" + tx_hesapTur.Text + "')");
            hesapTur_Load(null, null);
            MessageBox.Show("Hesap Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_hesapTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Hesap Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_hesapTur where hesapTur_id=" + dgv_hesapTur.SelectedRows[0].Cells["hesapTur_id"].Value);
            hesapTur_Load(null, null);
            MessageBox.Show(kayitsay + " Hesap Türü Silindi...");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_hesapTur.Text.Trim().Length < 5)
                {
                    MessageBox.Show("Hesap Türü En az 5 Karakter Olmalıdır..");
                    return;
                }
                if (dgv_hesapTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_hesapTur set hesapTur='" + tx_hesapTur.Text + "' where hesapTur_id=" + dgv_hesapTur.SelectedRows[0].Cells["hesapTur_id"].Value);
                if (kayitsay > 0)
                {
                    hesapTur_Load(null, null);
                    MessageBox.Show("Hesap Türü Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_hesapTur_KeyPress(object sender, KeyPressEventArgs e)
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

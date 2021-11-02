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
    public partial class transferTur : MetroFramework.Forms.MetroForm
    {
        public transferTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void transferTur_Load(object sender, EventArgs e)
        {
            dgv_transferTur.DataSource = vt.Select(@"select transferTur_id,transferTur from tbl_transferTur");
            dgv_transferTur.Columns["transferTur_id"].Visible = false;
        }

        private void dgv_transferTur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_transferTur.SelectedRows.Count == 0)
                return;
            tx_transferTur.Text = dgv_transferTur.SelectedRows[0].Cells["transferTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_transferTur.Text = "";

            if (dgv_transferTur.SelectedRows.Count > 0)
                dgv_transferTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_transferTur.Text.Trim().Length < 5)
            {
                MessageBox.Show("Transfer Türü En az 5 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_transferTur(transferTur)values('" + tx_transferTur.Text + "')");
            transferTur_Load(null, null);
            MessageBox.Show("Transfer Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try {
            if (dgv_transferTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Transfer Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_transferTur where transferTur_id=" + dgv_transferTur.SelectedRows[0].Cells["transferTur_id"].Value);
            transferTur_Load(null, null);
            MessageBox.Show(kayitsay + " Transfer Türü Silindi...");
        } catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            } 
            }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_transferTur.Text.Trim().Length < 5)
            {
                MessageBox.Show("Transfer Türü En az 5 Karakter Olmalıdır..");
                return;
            }
            if (dgv_transferTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_transferTur set transferTur='" + tx_transferTur.Text + "' where transferTur_id=" + dgv_transferTur.SelectedRows[0].Cells["transferTur_id"].Value);
            if (kayitsay > 0)
            {
                transferTur_Load(null, null);
                MessageBox.Show("Transfer Türü Güncellendi...");
            }
            } catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_transferTur_KeyPress(object sender, KeyPressEventArgs e)
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

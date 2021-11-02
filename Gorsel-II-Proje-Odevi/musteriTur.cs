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
    public partial class musteriTur : MetroFramework.Forms.MetroForm
    {
        public musteriTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void musteriTur_Load(object sender, EventArgs e)
        {
            dgv_musteriTur.DataSource = vt.Select(@"select musteriTur_id,musteriTur from tbl_musteriTur");
            dgv_musteriTur.Columns["musteriTur_id"].Visible = false;
        }

        private void dgv_musteriTur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_musteriTur.SelectedRows.Count == 0)
                return;
            tx_musteriTur.Text = dgv_musteriTur.SelectedRows[0].Cells["musteriTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {

            tx_musteriTur.Text = "";

            if (dgv_musteriTur.SelectedRows.Count > 0)
                dgv_musteriTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_musteriTur.Text.Trim().Length < 5)
            {
                MessageBox.Show("Müşteri Türü En az 5 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_musteriTur(musteriTur)values('" + tx_musteriTur.Text + "')");
            musteriTur_Load(null, null);
            MessageBox.Show("Müşteri Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_musteriTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Müşteri Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_musteriTur where musteriTur_id=" + dgv_musteriTur.SelectedRows[0].Cells["musteriTur_id"].Value);
            musteriTur_Load(null, null);
            MessageBox.Show(kayitsay + " Müşteri Türü Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_musteriTur.Text.Trim().Length < 5)
            {
                MessageBox.Show("Müşteri Türü En az 5 Karakter Olmalıdır..");
                return;
            }
            if (dgv_musteriTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_musteriTur set musteriTur='" + tx_musteriTur.Text + "' where musteriTur_id=" + dgv_musteriTur.SelectedRows[0].Cells["musteriTur_id"].Value);
            if (kayitsay > 0)
            {
                musteriTur_Load(null, null);
                MessageBox.Show("Müşteri Türü Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_musteriTur_KeyPress(object sender, KeyPressEventArgs e)
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

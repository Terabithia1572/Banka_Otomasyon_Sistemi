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
    public partial class KartTur : MetroFramework.Forms.MetroForm
    {
        public KartTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void KartTur_Load(object sender, EventArgs e)
        {
            dgv_kartTur.DataSource = vt.Select(@"select kartTur_id,kart_Turu from tbl_kartTur");
            dgv_kartTur.Columns["kartTur_id"].Visible = false;
        }

        private void dgv_kartTur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_kartTur.SelectedRows.Count == 0)
                return;
            tx_kartTur.Text = dgv_kartTur.SelectedRows[0].Cells["kart_Turu"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_kartTur.Text = "";

            if (dgv_kartTur.SelectedRows.Count > 0)
                dgv_kartTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_kartTur.Text.Trim().Length < 3)
            {
                MessageBox.Show("Kart Türü En az 3 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_kartTur(kart_Turu)values('" + tx_kartTur.Text + "')");
            KartTur_Load(null, null);
            MessageBox.Show("Kart Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_kartTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Kart Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_kartTur where kartTur_id=" + dgv_kartTur.SelectedRows[0].Cells["kartTur_id"].Value);
            KartTur_Load(null, null);
            MessageBox.Show(kayitsay + " Kart Türü Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_kartTur.Text.Trim().Length < 3)
            {
                MessageBox.Show("Kart Türü En az 3 Karakter Olmalıdır..");
                return;
            }
            if (dgv_kartTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_kartTur set kart_Turu='" + tx_kartTur.Text + "' where kartTur_id=" + dgv_kartTur.SelectedRows[0].Cells["kartTur_id"].Value);
            if (kayitsay > 0)
            {
                KartTur_Load(null, null);
                MessageBox.Show("Kart Türü Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_kartTur_KeyPress(object sender, KeyPressEventArgs e)
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

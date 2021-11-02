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
    public partial class BasvuruTur : MetroFramework.Forms.MetroForm
    {
        public BasvuruTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 2;
        private void BasvuruTur_Load(object sender, EventArgs e)
        {
            dgv_BasvuruTur.DataSource = vt.Select("select basvuruTur_id,basvuruTur from tbl_BasvuruTur");

            dgv_BasvuruTur.Columns["basvuruTur_id"].Visible = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_basvuruTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Başvuru Türü En az 2 Haneli Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_BasvuruTur(basvuruTur)values('"+tx_basvuruTur.Text+"')");
            BasvuruTur_Load(null, null);
            MessageBox.Show("Basvuru Tür Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_BasvuruTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek BAşvuru Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_BasvuruTur where basvuruTur_id=" + dgv_BasvuruTur.SelectedRows[0].Cells["basvuruTur_id"].Value);
            BasvuruTur_Load(null, null);
            MessageBox.Show(kayitsay + " Başvuru Kaydı Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void dgv_BasvuruTur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BasvuruTur.SelectedRows.Count == 0)
                return;
            tx_basvuruTur.Text = dgv_BasvuruTur.SelectedRows[0].Cells["basvuruTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_basvuruTur.Text = "";

            if (dgv_BasvuruTur.SelectedRows.Count > 0)
                dgv_BasvuruTur.SelectedRows[0].Selected = false;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_basvuruTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Başvuru Türü En az 2 Haneli Olmalıdır..");
                return;
            }
            if (dgv_BasvuruTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_BasvuruTur set basvuruTur='"+tx_basvuruTur.Text+"' where basvuruTur_id=" + dgv_BasvuruTur.SelectedRows[0].Cells["BasvuruTur_id"].Value);
            if (kayitsay > 0)
            {
                BasvuruTur_Load(null, null);
                MessageBox.Show("Başvuru Bilgileri Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_basvuruTur_KeyPress(object sender, KeyPressEventArgs e)
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

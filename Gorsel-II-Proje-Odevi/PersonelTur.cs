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
    public partial class PersonelTur : MetroFramework.Forms.MetroForm
    {
        public PersonelTur()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void PersonelTur_Load(object sender, EventArgs e)
        {
            dgv_personelTur.DataSource = vt.Select(@"select perTur_id,perTur from tbl_personelTur");
            dgv_personelTur.Columns["perTur_id"].Visible = false;
        }

        private void dgv_personelTur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_personelTur.SelectedRows.Count == 0)
                return;
            tx_personelTur.Text = dgv_personelTur.SelectedRows[0].Cells["perTur"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_personelTur.Text = "";

            if (dgv_personelTur.SelectedRows.Count > 0)
                dgv_personelTur.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_personelTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Personel Türü En az 2 Karakter Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_personelTur(perTur)values('" + tx_personelTur.Text + "')");
            PersonelTur_Load(null, null);
            MessageBox.Show("Basvuru Durum Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_personelTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Personel Türü Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_personelTur where perTur_id=" + dgv_personelTur.SelectedRows[0].Cells["perTur_id"].Value);
            PersonelTur_Load(null, null);
            MessageBox.Show(kayitsay + " Personel Türü Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_personelTur.Text.Trim().Length < 2)
            {
                MessageBox.Show("Personel Türü En az 2 Karakter Olmalıdır..");
                return;
            }
            if (dgv_personelTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_personelTur set perTur='" + tx_personelTur.Text + "' where perTur_id=" + dgv_personelTur.SelectedRows[0].Cells["perTur_id"].Value);
            if (kayitsay > 0)
            {
                PersonelTur_Load(null, null);
                MessageBox.Show("Personel Türü Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_personelTur_KeyPress(object sender, KeyPressEventArgs e)
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

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
    public partial class BasvuruDurum : MetroFramework.Forms.MetroForm
    {
        public BasvuruDurum()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 2;
        private void BasvuruDurum_Load(object sender, EventArgs e)
        {
            dgv_BasvuruDurum.DataSource = vt.Select(@"select basvuruDurum_id,basvuruDurum from tbl_basvuruDurum");
            dgv_BasvuruDurum.Columns["basvuruDurum_id"].Visible = false;
        }

        private void dgv_BasvuruDurum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BasvuruDurum.SelectedRows.Count == 0)
                return;
            tx_basvuruDurum.Text = dgv_BasvuruDurum.SelectedRows[0].Cells["basvuruDurum"].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_basvuruDurum.Text = "";

            if (dgv_BasvuruDurum.SelectedRows.Count > 0)
                dgv_BasvuruDurum.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        { try { 
            if (tx_basvuruDurum.Text.Trim().Length < 2)
            {
                MessageBox.Show("Başvuru Durum En az 2 Haneli Olmalıdır..");
                return;
            }
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Insert(@"insert into tbl_basvuruDurum(basvuruDurum)values('"+tx_basvuruDurum.Text+"')");
            BasvuruDurum_Load(null, null);
            MessageBox.Show("Basvuru Durum Kaydı Eklendi..");
        } catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
            }

        
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_BasvuruDurum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek BAşvuru Durum Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_basvuruDurum where basvuruDurum_id=" + dgv_BasvuruDurum.SelectedRows[0].Cells["basvuruDurum_id"].Value);
            BasvuruDurum_Load(null, null);
            MessageBox.Show(kayitsay + " Başvuru Durumu Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 

            if (tx_basvuruDurum.Text.Trim().Length < 2)
            {
                MessageBox.Show("Başvuru Durum En az 2 Haneli Olmalıdır..");
                return;
            }
            if (dgv_BasvuruDurum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_BasvuruDurum set basvuruDurum='" + tx_basvuruDurum.Text + "' where basvuruDurum_id=" + dgv_BasvuruDurum.SelectedRows[0].Cells["BasvuruDurum_id"].Value);
            if (kayitsay > 0)
            {
                BasvuruDurum_Load(null, null);
                MessageBox.Show("Başvuru Durumu Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_basvuruDurum_KeyPress(object sender, KeyPressEventArgs e)
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

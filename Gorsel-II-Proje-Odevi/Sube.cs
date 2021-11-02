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
    public partial class Sube : MetroFramework.Forms.MetroForm
    {
        public Sube()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Sube_Load(object sender, EventArgs e)
        {
            dgv_Sube.DataSource = vt.Select(@"select sube_id,subeAd,subeNo,subeAdres from tbl_Sube");
            dgv_Sube.Columns["sube_id"].Visible = false;
        }

        private void dgv_Sube_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Sube.SelectedRows.Count == 0)
                return;
            tx_subeAd.Text = dgv_Sube.SelectedRows[0].Cells["subeAd"].Value.ToString();
            tx_subeAdres.Text = dgv_Sube.SelectedRows[0].Cells["subeAdres"].Value.ToString();
            tx_subeNo.Text = dgv_Sube.SelectedRows[0].Cells["subeNo"].Value.ToString();

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {

            tx_subeAd.Text =tx_subeAdres.Text=tx_subeNo.Text="";

            if (dgv_Sube.SelectedRows.Count > 0)
                dgv_Sube.SelectedRows[0].Selected = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
           
            if (tx_subeAd.Text.Trim().Length < 4)
            {
                MessageBox.Show("Banka Adı En az 4 Karakter Olmalıdır..");
                return;
            }
            if (tx_subeNo.Text.Trim().Length < 1)
            {
                MessageBox.Show(" Şube No En az 1 Karakter Olmalıdır..");
                return;
            }
            if (tx_subeAdres.Text.Trim().Length < 3)
            {
                MessageBox.Show("Şube Adresi En az 3 Karakter Olmalıdır..");
                return;
            }
            try {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_Sube(subeAd,subeNo,subeAdres)values('"+tx_subeAd.Text+"','"+tx_subeNo.Text+"','"+tx_subeAdres.Text+"')");
            Sube_Load(null, null);
            MessageBox.Show(kayitsay+" Şube Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Lütfen Negatif Değer Girmeyin Veya Tekrar Deneyin..!");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Sube.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Şube Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_sube where sube_id=" + dgv_Sube.SelectedRows[0].Cells["sube_id"].Value);
            Sube_Load(null, null);
            MessageBox.Show(kayitsay + " Şube Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_subeAd.Text.Trim().Length < 4)
            {
                MessageBox.Show("Banka Adı En az 4 Karakter Olmalıdır..");
                return;
            }
            if (tx_subeNo.Text.Trim().Length < 1)
            {
                MessageBox.Show(" Şube No En az 1 Karakter Olmalıdır..");
                return;
            }
            if (tx_subeAdres.Text.Trim().Length < 3)
            {
                MessageBox.Show("Şube Adresi En az 3 Karakter Olmalıdır..");
                return;
            }

            if (dgv_Sube.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_sube set subeAd='"+tx_subeAd.Text+"',subeNo='"+tx_subeNo.Text+"',subeAdres='"+tx_subeAdres.Text+"' where sube_id=" + dgv_Sube.SelectedRows[0].Cells["sube_id"].Value);
            if (kayitsay > 0)
            {
                Sube_Load(null, null);
                MessageBox.Show("Şube Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void tx_subeAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tx_subeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_subeAdres_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Char.IsPunctuation(e.KeyChar);
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

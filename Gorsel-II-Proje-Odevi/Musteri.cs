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
    public partial class Musteri : MetroFramework.Forms.MetroForm
    {
        public Musteri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Musteri_Load(object sender, EventArgs e)
        {
            dgv_Musteriler.DataSource = vt.Select(@"select m.musteri_id,m.ad,m.soyad,m.tc,m.telefon,m.adres,a.musteriTur_id,a.musteriTur from tbl_Musteri m join tbl_MusteriTur a on m.musteriTur_id=a.musteriTur_id");
            dgv_Musteriler.Columns["musteri_id"].Visible = false;
            dgv_Musteriler.Columns["musteriTur_id"].Visible = false;
            cbx_musteriTur.DataSource = vt.Select("select musteriTur,musteriTur_id from tbl_musteriTur");
            cbx_musteriTur.DisplayMember = "musteriTur";
            cbx_musteriTur.ValueMember = "musteriTur_id";

     
        }

        private void dgv_Musteriler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_Musteriler.SelectedRows.Count == 0)
                return;

            cbx_musteriTur.Text = dgv_Musteriler.SelectedRows[0].Cells["musteriTur"].Value.ToString();
            tx_Ad.Text = dgv_Musteriler.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_Soyad.Text = dgv_Musteriler.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_Telefon.Text = dgv_Musteriler.SelectedRows[0].Cells["telefon"].Value.ToString();
            tx_TC.Text = dgv_Musteriler.SelectedRows[0].Cells["TC"].Value.ToString();
            tx_Adres.Text = dgv_Musteriler.SelectedRows[0].Cells["adres"].Value.ToString();

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_Musteri(ad,soyad,tc,telefon,adres,musteriTur_id)values('"+tx_Ad.Text+"','"+tx_Soyad.Text+"','"+tx_TC.Text+"','"+tx_Telefon.Text+"','"+tx_Adres.Text+"','"+cbx_musteriTur.SelectedValue+"')");

            Musteri_Load(null, null);
            MessageBox.Show("Müşteri Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Boş Sutün Bırakmayınız veya Eksik Bırakmayınız");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Musteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Müşteri Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_musteri where musteri_id=" + dgv_Musteriler.SelectedRows[0].Cells["musteri_id"].Value);
            Musteri_Load(null, null);
            MessageBox.Show(kayitsay + " Müşteri Kaydı Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Musteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_Musteri set ad='"+tx_Ad.Text+"',soyad='"+tx_Soyad.Text+"',tc='"+tx_TC.Text+"',telefon='"+tx_Telefon.Text+"',adres='"+tx_Adres.Text+"',musteriTur_id='"+cbx_musteriTur.SelectedValue+"' where musteri_id=" + dgv_Musteriler.SelectedRows[0].Cells["musteri_id"].Value);
            if (kayitsay > 0)
            {
                Musteri_Load(null, null);
                MessageBox.Show("Müşteri Bilgileri Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            cbx_musteriTur.SelectedValue = -1;
            tx_Ad.Text = "";
            tx_Adres.Text = "";
            tx_Soyad.Text = "";
            tx_TC.Text = "";
            tx_Telefon.Text = "";
            if (dgv_Musteriler.SelectedRows.Count > 0)
                dgv_Musteriler.SelectedRows[0].Selected = false;
        }

        private void tx_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void tx_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void tx_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void tx_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }
    }
}

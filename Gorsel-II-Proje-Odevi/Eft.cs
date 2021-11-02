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
    public partial class Eft : MetroFramework.Forms.MetroForm
    {
        public Eft()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 2;
        private void Eft_Load(object sender, EventArgs e)
        {

            try
            {
                dgv_Eft.DataSource = vt.Select(@"select e.ad,e.soyad,ht.hesap_id,ht.hesapNo,e.eft_id,e.gonderenHesap_id,e.aliciiban,t.transferTur_id,t.transferTur,h.havale_id,h.alanHesap_id,h.tutar,h.tarih from tbl_Eft e join tbl_TransferTur t on e.transferTur_id=t.transferTur_id join tbl_Havale h on h.gonderenHesap_id=e.gonderenHesap_id join tbl_Hesap ht on h.gonderenHesap_id=ht.hesap_id");
                dgv_Eft.Columns["eft_id"].Visible = false;
                dgv_Eft.Columns["gonderenHesap_id"].Visible = false;
                dgv_Eft.Columns["transferTur_id"].Visible = false;
                dgv_Eft.Columns["havale_id"].Visible = false;
                dgv_Eft.Columns["hesap_id"].Visible = false;
                dgv_Eft.Columns["alanhesap_id"].Visible = false;
                cbx_transferTur.DataSource = vt.Select("select transferTur,transferTur_id from tbl_transferTur");
                cbx_transferTur.DisplayMember = "transferTur";
                cbx_transferTur.ValueMember = "transferTur_id";
                cbx_gonderenHesap.DataSource = vt.Select("select h.hesapNo,h.hesap_id from tbl_Hesap h join tbl_Havale ha on h.hesap_id=ha.gonderenHesap_id");
                cbx_gonderenHesap.DisplayMember = "hesapNo";
                cbx_gonderenHesap.ValueMember = "hesap_id";
            }
            catch
            {
                MessageBox.Show("Hata Lütfen Kontrol Ediniz..");
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_Eft(ad,soyad,aliciiban,gonderenHesap_id,transferTur_id)values('"+tx_Ad.Text+"','"+tx_soyAd.Text+"','"+tx_aliciİban.Text+"','"+cbx_gonderenHesap.SelectedValue+"','"+cbx_transferTur.SelectedValue+"')");
                Eft_Load(null, null);
                MessageBox.Show(kayitsay + " EFT Kaydı Eklendi...");
            }
            catch
            {
                MessageBox.Show("Hata..! Lütfen Kontrol Ediniz..");
            }
            }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Eft.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Silinecek EFT Seçiniz..!");
                    return;
                }
                int kayitsay = vt.UpdateDelete(@"delete from tbl_eft where eft_id=" + dgv_Eft.SelectedRows[0].Cells["eft_id"].Value);
                Eft_Load(null, null);
                MessageBox.Show(kayitsay + " EFT Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_Ad.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız..");
                return;
            }

            if (tx_soyAd.Text=="")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız..");
                return;
            }
            if (dgv_Eft.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }
            try
            {
                int kayitsay = vt.UpdateDelete(@"update tbl_eft set gonderenHesap_id'"+cbx_gonderenHesap.SelectedValue+"',aliciiban='"+tx_aliciİban.Text+"',ad='"+tx_Ad.Text+"',soyad='"+tx_soyAd.Text+"',transferTur_id='"+cbx_transferTur.SelectedValue+"' where eft_id=" + dgv_Eft.SelectedRows[0].Cells["eft_id"].Value);
                if (kayitsay > 0)
                {
                    Eft_Load(null, null);
                    MessageBox.Show("eft Bilgileri Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Kardeşim Kusura Bakma Bugün Güncelleyemiyoruz...");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Eft.SelectedRows.Count > 0)
                    dgv_Eft.SelectedRows[0].Selected = false;

                tx_Ad.Text =tx_aliciİban.Text=tx_soyAd.Text= "";
                cbx_gonderenHesap.SelectedValue = -1;
                cbx_transferTur.SelectedValue = -1;

            }
            catch
            {
                MessageBox.Show("Temizlendi..");
            }
        }

        private void dgv_Eft_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Eft.SelectedRows.Count == 0)
                return;

            cbx_gonderenHesap.Text = dgv_Eft.SelectedRows[0].Cells["gonderenHesap_id"].Value.ToString();
            cbx_transferTur.Text = dgv_Eft.SelectedRows[0].Cells["transferTur"].Value.ToString();
            tx_Ad.Text = dgv_Eft.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_Eft.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_aliciİban.Text = dgv_Eft.SelectedRows[0].Cells["aliciiban"].Value.ToString();
      

            //     
        }

        private void tx_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }

        private void tx_soyAd_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }

        private void tx_aliciİban_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

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
    public partial class Kart : MetroFramework.Forms.MetroForm
    {
        public Kart()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Kart_Load(object sender, EventArgs e)
        {
            dgv_Kart.DataSource = vt.Select(@"select h.hesap_id,h.hesapDurum,m.ad+' '+m.soyad as 'AdSoyad',k.kart_id,k.SonKTarihi,k.CVC,k.kartNo,kt.kart_Turu,kt.kartTur_id,m.tc,m.musteri_id
 from tbl_kart k join tbl_KartTur kt on k.kartTur_id=kt.kartTur_id
join tbl_Musteri m on m.musteri_id=k.musteri_id
join tbl_Hesap h  on h.hesap_id=k.hesap_id");
             dgv_Kart.Columns["kart_id"].Visible = false;
            dgv_Kart.Columns["kartTur_id"].Visible = false;
            dgv_Kart.Columns["musteri_id"].Visible = false;
            dgv_Kart.Columns["hesap_id"].Visible = false;
            //dgv_Kart.Columns["hesapTur_id"].Visible = false;
            //dgv_Kart.Columns["musteriTur_id"].Visible = false;
            cbx_kartTur.DataSource = vt.Select("select kart_Turu,kartTur_id from tbl_kartTur");
            cbx_kartTur.DisplayMember = "kart_Turu";
            cbx_kartTur.ValueMember = "kartTur_id";
            //cbx_musteriTur.DataSource = vt.Select("select musteriTur_id,musteriTur from tbl_MusteriTur");
            //cbx_musteriTur.DisplayMember = "musteriTur";
            //cbx_musteriTur.ValueMember = "musteriTur_id";
            cbx_adSoyad.DataSource = vt.Select("select ad+' '+soyad as 'AdSoyad',musteri_id from tbl_Musteri");
            cbx_adSoyad.DisplayMember = "AdSoyad";
            cbx_adSoyad.ValueMember = "musteri_id";
       //    cbx_kartNo.DataSource = vt.Select("select kart_id,kartNo from tbl_kart");
           // cbx_kartNo.DisplayMember = "kartNo";
       //    cbx_kartNo.ValueMember = "kart_id";
            cbx_hesapDurumu.DataSource = vt.Select("select hesap_id,hesapDurum from tbl_hesap");
            cbx_hesapDurumu.DisplayMember = "hesapDurum";
            cbx_hesapDurumu.ValueMember = "hesap_id";


        }

        private void dgv_Kart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Kart.SelectedRows.Count == 0)
                return;

            cbx_kartTur.Text = dgv_Kart.SelectedRows[0].Cells["kart_Turu"].Value.ToString();
            cbx_adSoyad.Text = dgv_Kart.SelectedRows[0].Cells["adSoyad"].Value.ToString();
            cbx_hesapDurumu.Text = dgv_Kart.SelectedRows[0].Cells["hesapDurum"].Value.ToString();
            tx_kartNo.Text = dgv_Kart.SelectedRows[0].Cells["kartNo"].Value.ToString();
          // cbx_musteriTur.Text = dgv_Kart.SelectedRows[0].Cells["musteriTur"].Value.ToString();
            tx_CVC.Text = dgv_Kart.SelectedRows[0].Cells["CVC"].Value.ToString();
            cbx_adSoyad.Text= dgv_Kart.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
           // cbx_hesapDurumu.Text= dgv_Kart.SelectedRows[0].Cells["hesapDurum"].Value.ToString();

            //     

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
           try {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_kart(SonKTarihi,CVC,kartNo,kartTur_id,musteri_id,hesap_id)values('"+dtp_tarih.Value.ToShortDateString()+"','"+tx_CVC.Text+"','"+tx_kartNo.Text+"','"+cbx_kartTur.SelectedValue+"','"+cbx_adSoyad.SelectedValue+"','"+cbx_hesapDurumu.SelectedValue+"')");
            Kart_Load(null,null);
                MessageBox.Show("Kayıt Başarıyla Eklendi..");
            }
           catch
          {
              MessageBox.Show("Yavaş la Yavaş Hata var Diyok Kontrol Et veya Boş Bırakma...");
           }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Kart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Kart Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_kart where kart_id=" + dgv_Kart.SelectedRows[0].Cells["kart_id"].Value);
            Kart_Load(null, null);
            MessageBox.Show(kayitsay + " Kart Silindi...");
        }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
            }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {  
            
           if(tx_CVC.Text=="")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız..");
                return;
            }

            if (tx_CVC.Text.Trim().Length < 3)
            {
               MessageBox.Show("CVC En az 3 Karakter Olmalıdır..");
               return;
            }
            if (dgv_Kart.SelectedRows.Count == 0)
            {
               MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }
          try { 
      int kayitsay = vt.UpdateDelete(@"update tbl_Kart set musteri_id='"+cbx_adSoyad.SelectedValue+"', SonKTarihi='"+dtp_tarih.Value+"',CVC='"+tx_CVC.Text+"',kartTur_id='"+cbx_kartTur.SelectedValue+"',musteri_id='"+cbx_musteriTur.SelectedValue+"',hesap_id='"+cbx_hesapDurumu.SelectedValue+"',kartNo='"+tx_kartNo.Text+"' where kart_id= " + dgv_Kart.SelectedRows[0].Cells["kart_id"].Value);
            if (kayitsay > 0)
            {
                Kart_Load(null, null);
                MessageBox.Show("Kart Bilgileri Güncellendi...");
            }
          }
           catch
           {
                MessageBox.Show("Kardeşim Kusura Bakma Bugün Güncelleyemiyoruz...");
           }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Kart.SelectedRows.Count > 0)
                dgv_Kart.SelectedRows[0].Selected = false;

             tx_CVC.Text = "";
            //   cbx_kartTur.SelectedValue = -1;
            //    cbx_musteriTur.SelectedValue = -1;
            cbx_adSoyad.SelectedValue = -1;
            cbx_hesapDurumu.SelectedValue = -1;
            tx_kartNo.Text = "";
            cbx_kartTur.SelectedValue = -1;
            cbx_musteriTur.SelectedValue = -1;
            }
            catch
            {
                MessageBox.Show("Temizlendi..");
            }
            


           
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

        private void tx_CVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chbx_aktifMi_CheckedChanged(object sender, EventArgs e)
        {

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

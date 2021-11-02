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
    public partial class Havale : MetroFramework.Forms.MetroForm
    {
        public Havale()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 2;
        private void Havale_Load(object sender, EventArgs e)
        {
            dgv_Havale.DataSource = vt.Select(@"select h.alanHesap_id,h.havale_id,h.tutar,h.tarih,he.hesap_id,he.hesapNo,tf.transferTur,tf.transferTur_id 
from tbl_Havale h join tbl_Hesap he on h.gonderenHesap_id=he.hesap_id
join tbl_TransferTur tf on tf.transferTur_id=h.transferTur_id");
            dgv_Havale.Columns["havale_id"].Visible = false;
            //dgv_Havale.Columns["gonderenHesap_id"].Visible = false;
            dgv_Havale.Columns["alanHesap_id"].Visible = false;
            dgv_Havale.Columns["transferTur_id"].Visible = false;
            dgv_Havale.Columns["hesap_id"].Visible = false;
            //dgv_Havale.Columns["hesapTur_id"].Visible = false;
            //dgv_Havale.Columns["musteri_id"].Visible = false;
       //  dgv_Havale.Columns["sube_id1"].Visible = false;
          cbx_transferTur.DataSource = vt.Select("select transferTur,transferTur_id from tbl_transferTur");
          cbx_transferTur.DisplayMember = "transferTur";
          cbx_transferTur.ValueMember = "transferTur_id";
            cbx_gonderenHesap.DataSource = vt.Select("select hesapNo,hesapTur_id from tbl_hesap");
            cbx_gonderenHesap.DisplayMember = "hesapNo";
            cbx_gonderenHesap.ValueMember = "hesapTur_id";
           // cbx_alanHesap.DataSource = vt.Select("select hesapNo,hesap_id from tbl_Hesap");
       //    cbx_alanHesap.DisplayMember = "hesapNo";
          //  cbx_alanHesap.ValueMember = "hesap_id";

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
            object kayitsay = vt.Select(@"insert into tbl_Havale(gonderenHesap_id,alanHesap_id,transferTur_id,tutar,tarih)values('"+cbx_gonderenHesap.SelectedValue+"','"+tx_alanHesap.Text+"','"+cbx_transferTur.SelectedValue+"','"+tx_Tutar.Text+"','"+dtp_tarih.Value+"')");


                Havale_Load(null, null);
                MessageBox.Show("Havale Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Kardeşim Bugün Ekleyemiyoruz Kusura Bakma");
            }
        
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Havale.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Silinecek Havale Seçiniz..!");
                    return;
                }
                int kayitsay = vt.UpdateDelete(@"delete from tbl_havale where havale_id=" + dgv_Havale.SelectedRows[0].Cells["havale_id"].Value);
                Havale_Load(null, null);
                MessageBox.Show(kayitsay + " Havale Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            if (dgv_Havale.SelectedRows.Count > 0)
                dgv_Havale.SelectedRows[0].Selected = false;
            tx_Tutar.Text =tx_alanHesap.Text= "";
            cbx_gonderenHesap.SelectedValue = cbx_transferTur.SelectedValue = -1;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgv_Havale.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_Havale set gonderenHesap_id='"+cbx_gonderenHesap.SelectedValue+"',alanHesap_id='"+tx_alanHesap.Text+"',transferTur_id='"+cbx_transferTur.SelectedValue+"',tutar='"+tx_Tutar.Text+"',tarih='"+dtp_tarih.Value+"' where havale_id=" + dgv_Havale.SelectedRows[0].Cells["havale_id"].Value);
                

                if (kayitsay > 0)
                {
                    Havale_Load(null, null);
                    MessageBox.Show("Havale Türü Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void dgv_Havale_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Havale.SelectedRows.Count == 0)
                return;

           tx_Tutar.Text= dgv_Havale.SelectedRows[0].Cells["tutar"].Value.ToString();
            tx_alanHesap.Text= dgv_Havale.SelectedRows[0].Cells["alanHesap_id"].Value.ToString();
            cbx_gonderenHesap.Text= dgv_Havale.SelectedRows[0].Cells["hesapNo"].Value.ToString();
            cbx_transferTur.Text= dgv_Havale.SelectedRows[0].Cells["transferTur"].Value.ToString();

        }
    }
}

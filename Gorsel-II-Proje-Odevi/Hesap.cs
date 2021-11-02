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
    public partial class Hesap : MetroFramework.Forms.MetroForm
    {
        public Hesap()
        {
            InitializeComponent();
        }

        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Hesap_Load(object sender, EventArgs e)
        {
            dgv_Hesap.DataSource=vt.Select(@"select ht.hesapTur,ht.hesapTur_id,h.hesap_id,h.iban,h.hesapNo,h.hesapBakiye,h.hesapDurum,m.musteri_id,m.ad+' '+m.soyad as 'adSoyad',s.sube_id,s.subeNo
 from tbl_Hesap h join tbl_hesapTur ht on ht.hesapTur_id=h.hesapTur_id
join tbl_Musteri m on m.musteri_id=h.musteri_id
join tbl_Sube s on s.sube_id=h.sube_id");

            dgv_Hesap.Columns["hesapTur_id"].Visible = false;
            dgv_Hesap.Columns["hesap_id"].Visible = false;
            dgv_Hesap.Columns["musteri_id"].Visible = false;
            dgv_Hesap.Columns["sube_id"].Visible = false;
            cbx_hesapTur.DataSource = vt.Select("select hesapTur,hesapTur_id from tbl_hesapTur");
            cbx_hesapTur.DisplayMember = "hesapTur";
            cbx_hesapTur.ValueMember = "hesapTur_id";

            cbx_musteriAd.DataSource = vt.Select("select musteri_id,ad+' '+soyad as 'adSoyad' from tbl_Musteri");
            cbx_musteriAd.DisplayMember = "adSoyad";
            cbx_musteriAd.ValueMember = "musteri_id";

            cbx_subeNo.DataSource = vt.Select("select subeNo,sube_id from tbl_sube");
            cbx_subeNo.DisplayMember = "subeNo";
            cbx_subeNo.ValueMember = "sube_id";
        }

        private void dgv_Hesap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_iban.Text = dgv_Hesap.SelectedRows[0].Cells["iban"].Value.ToString();
            tx_hesapNo.Text = dgv_Hesap.SelectedRows[0].Cells["hesapNo"].Value.ToString();
            tx_hesapBakiye.Text = dgv_Hesap.SelectedRows[0].Cells["hesapBakiye"].Value.ToString();
            tx_hesapDurum.Text = dgv_Hesap.SelectedRows[0].Cells["hesapDurum"].Value.ToString();
            cbx_hesapTur.Text = dgv_Hesap.SelectedRows[0].Cells["hesapTur"].Value.ToString();
            cbx_musteriAd.Text = dgv_Hesap.SelectedRows[0].Cells["adSoyad"].Value.ToString();
            cbx_subeNo.Text = dgv_Hesap.SelectedRows[0].Cells["subeNo"].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            if (tx_iban.Text.Trim().Length != 16)
            {
                MessageBox.Show("iban en az 16 karakter olmalıdır...");
                return;
            }
            if (tx_hesapDurum.Text.Trim().Length < 4)
            {
                MessageBox.Show("Hesap Durum en az 4 karakter olmalıdır...");
                return;
            }
            if (tx_hesapNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("hesapNo 11 karakter olmalıdır...");
                return;
            }
            if(tx_hesapBakiye.Text.Trim().Length<0)
            {
                MessageBox.Show("hesapBakiye en az 0 karakter olmalıdır umarım o kadar fakir değilsindir...");
                return;
            }
            if (tx_hesapBakiye.Text==""||tx_hesapDurum.Text==""||tx_hesapNo.Text==""||tx_iban.Text=="")
            {
                MessageBox.Show("Yavaş la Yavaş Boş Bırakma..");
                return;
            }
            try {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_hesap(iban,sube_id,hesapNo,hesapBakiye,hesapTur_id,musteri_id,hesapDurum)values('"+tx_iban.Text+"',"+cbx_subeNo.SelectedValue+",'"+tx_hesapNo.Text+"','"+tx_hesapBakiye.Text+"',"+cbx_hesapTur.SelectedValue+",'"+cbx_musteriAd.SelectedValue+"','"+tx_hesapDurum.Text+"')");
            Hesap_Load(null, null);
            MessageBox.Show("Hesap Kaydı Başarıyla Eklendi..");
            }
            catch
            {
                MessageBox.Show("Unique key olabilir farklı girin veya boş Bırakmayın adam olun bak..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Hesap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Hesap Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_hesap where hesap_id=" + dgv_Hesap.SelectedRows[0].Cells["hesap_id"].Value);
            Hesap_Load(null, null);
            MessageBox.Show(kayitsay + " Kart Silindi...");
        }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        
    }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            cbx_hesapTur.SelectedValue = -1;
            cbx_musteriAd.SelectedValue = -1;
            cbx_subeNo.SelectedValue = -1;
            tx_hesapBakiye.Text = tx_hesapDurum.Text = tx_hesapNo.Text = tx_iban.Text = "";
            if (dgv_Hesap.SelectedRows.Count > 0)
                dgv_Hesap.SelectedRows[0].Selected = false;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
         
            if (tx_hesapBakiye.Text == "" || tx_hesapDurum.Text == "" || tx_hesapNo.Text == "" || tx_iban.Text == "")
            {
                MessageBox.Show("Yavaş la Yavaş Boş Bırakma..");
                return;
            }
            if (tx_iban.Text.Trim().Length != 16)
            {
                MessageBox.Show("iban en az 16 karakter olmalıdır...");
                return;
            }
            if (tx_hesapDurum.Text.Trim().Length < 4)
            {
                MessageBox.Show("Hesap Durum en az 4 karakter olmalıdır...");
                return;
            }
            if (tx_hesapNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("hesapNo 11 karakter olmalıdır...");
                return;
            }
            if (tx_hesapBakiye.Text.Trim().Length < 0)
            {
                MessageBox.Show("hesapBakiye en az 0 karakter olmalıdır umarım o kadar fakir değilsindir...");
                return;
            }
            try { 
            int kayitsay = vt.UpdateDelete(@"update tbl_Hesap set iban='"+tx_iban.Text+"',sube_id='"+cbx_subeNo.SelectedValue+"',hesapNo='"+tx_hesapNo.Text+"',hesapBakiye='"+tx_hesapBakiye.Text+"',hesapDurum='"+tx_hesapDurum.Text+"',hesapTur_id='"+cbx_hesapTur.SelectedValue+"',musteri_id='"+cbx_musteriAd.SelectedValue+"' where hesap_id=" + dgv_Hesap.SelectedRows[0].Cells["hesap_id"].Value);
            if (kayitsay > 0)
            {
                Hesap_Load(null, null);
                MessageBox.Show("Hesap Bilgileri Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Lütfen Güncellenecek Satır Geçiniz..! veya Boş Bırakmayınız");
            }
        }

        private void tx_iban_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_hesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_hesapBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_hesapDurum_KeyPress(object sender, KeyPressEventArgs e)
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

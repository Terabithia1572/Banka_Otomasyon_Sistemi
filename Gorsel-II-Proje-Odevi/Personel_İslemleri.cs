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
    public partial class Personel_İslemleri : MetroFramework.Forms.MetroForm
    {
        public Personel_İslemleri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Personel_İslemleri_Load(object sender, EventArgs e)
        {
            dgv_perTur.DataSource = vt.Select(@"select p.per_id,p.ad,p.soyad,p.TC,gorevi,p.perTur_id,p.Telefon,p.adres,a.PerTur,s.sube_id,s.subeAd,subeAdres from tbl_Personel p join tbl_PersonelTur a on p.perTur_id=a.perTur_id join tbl_Sube s on s.sube_id=p.sube_id");
            dgv_perTur.Columns["per_id"].Visible = false;
            dgv_perTur.Columns["perTur_id"].Visible = false;
            dgv_perTur.Columns["sube_id"].Visible = false;

            cbx_perTur.DataSource = vt.Select("select perTur,perTur_id from tbl_personelTur");
            cbx_perTur.DisplayMember = "perTur";
            cbx_perTur.ValueMember = "perTur_id";

            cbx_subeAd.DataSource = vt.Select("select subeAd,sube_id from tbl_sube");
            cbx_subeAd.DisplayMember = "subeAd";
            cbx_subeAd.ValueMember = "sube_id";
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Select(@"insert into tbl_Personel(ad,soyad,TC,gorevi,perTur_id,sube_id,Telefon,adres) values('"+tx_Ad.Text+"','"+tx_Soyad.Text+"','"+tx_TC.Text+"','"+tx_Gorevi.Text+"','"+cbx_perTur.SelectedValue+"','"+cbx_subeAd.SelectedValue+"','"+tx_Telefon.Text+"','"+tx_Adres.Text+"')");

                Personel_İslemleri_Load(null, null);
                MessageBox.Show("Personel Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata/Lütfen Gerekli Alanları Doldurunuz veya Boş Bırakmayınız..");
            }
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

        private void tx_Gorevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_perTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Silinecek Şube Seçiniz..!");
                    return;
                }
                int kayitsay = vt.UpdateDelete(@"delete from tbl_Personel where per_id=" + dgv_perTur.SelectedRows[0].Cells["per_id"].Value);
                Personel_İslemleri_Load(null, null);
                MessageBox.Show(kayitsay + " Personel Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_Ad.Text.Trim().Length < 2)
                {
                    MessageBox.Show(" Ad En az 2 Karakter Olmalıdır..");
                    return;
                }
                if (tx_Soyad.Text.Trim().Length < 2)
                {
                    MessageBox.Show(" Soyad No En az 2 Karakter Olmalıdır..");
                    return;
                }
                if (tx_Adres.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Adres En az 3 Karakter Olmalıdır..");
                    return;
                }
                if (tx_Gorevi.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Görevi En az 3 Karakter Olmalıdır..");
                    return;
                }
                if (tx_TC.Text.Trim().Length != 11)
                {
                    MessageBox.Show("TC 11 Karakter Olmalıdır..");
                    return;
                }
                if (tx_Telefon.Text.Trim().Length != 11)
                {
                    MessageBox.Show("TElefon 11 Karakter Olmalıdır..");
                    return;
                }


                if (dgv_perTur.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                    return;
                }

                int kayitsay = vt.UpdateDelete(@"update tbl_Personel set ad='"+tx_Ad.Text+"',soyad='"+tx_Soyad.Text+"',TC='"+tx_TC.Text+"',gorevi='"+tx_Gorevi.Text+"',perTur_id='"+cbx_perTur.SelectedValue+"',sube_id='"+cbx_subeAd.SelectedValue+"',Telefon='"+tx_Telefon.Text+"',adres='"+tx_Adres.Text+"' where per_id=" + dgv_perTur.SelectedRows[0].Cells["per_id"].Value);
                if (kayitsay > 0)
                {
                    Personel_İslemleri_Load(null, null);
                    MessageBox.Show("Personel Güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void dgv_perTur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_perTur.SelectedRows.Count == 0)
                return;
            tx_Ad.Text = dgv_perTur.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_Adres.Text = dgv_perTur.SelectedRows[0].Cells["adres"].Value.ToString();
            tx_Soyad.Text = dgv_perTur.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_Gorevi.Text = dgv_perTur.SelectedRows[0].Cells["gorevi"].Value.ToString();
            tx_TC.Text = dgv_perTur.SelectedRows[0].Cells["tc"].Value.ToString();
            tx_Telefon.Text = dgv_perTur.SelectedRows[0].Cells["telefon"].Value.ToString();
            cbx_perTur.Text = dgv_perTur.SelectedRows[0].Cells["perTur"].Value.ToString();
            cbx_subeAd.Text = dgv_perTur.SelectedRows[0].Cells["subeAd"].Value.ToString();
        }

        private void tx_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            if (dgv_perTur.SelectedRows.Count > 0)
                dgv_perTur.SelectedRows[0].Selected = false;
            tx_Ad.Text = tx_Adres.Text = tx_Gorevi.Text = tx_Soyad.Text = tx_TC.Text = tx_Telefon.Text = "";
            cbx_perTur.SelectedValue = -1;
            cbx_subeAd.SelectedValue = -1;
        }
    }
}

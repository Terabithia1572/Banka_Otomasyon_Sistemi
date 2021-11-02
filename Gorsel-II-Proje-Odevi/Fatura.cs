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
    public partial class Fatura : MetroFramework.Forms.MetroForm
    {
        public Fatura()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 1;
        private void Fatura_Load(object sender, EventArgs e)
        {
            dgv_Faturalar.DataSource = vt.Select(@"select tarih, f.fatura_id,f.miktar,f.faturaNo,ft.faturaTur,h.hesap_id,h.hesapNo,ft.faturaTur_id from tbl_Fatura f join tbl_FaturaTur ft on f.faturaTur_id=ft.faturaTur_id
join tbl_Hesap h on f.hesap_id= h.hesap_id");
            dgv_Faturalar.Columns["Fatura_id"].Visible = false;
            dgv_Faturalar.Columns["hesap_id"].Visible = false;
            dgv_Faturalar.Columns["faturaTur_id"].Visible = false;

            cbx_FaturaTur.DataSource = vt.Select(" select faturaTur_id,faturaTur from tbl_faturaTur");
            cbx_FaturaTur.DisplayMember = "faturaTur";
            cbx_FaturaTur.ValueMember = "faturaTur_id";

            cbx_HesapNo.DataSource = vt.Select("select hesap_id ,hesapNo from tbl_Hesap");
            cbx_HesapNo.DisplayMember = "hesapNo";
            cbx_HesapNo.ValueMember = "hesap_id";


           


        }


        private void tx_Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b') { 
                e.Handled = true;
            }
            tx_Miktar.Text = tx_Miktar.Text.ToString().Replace(',', '.');
        }

        private void tx_FaturaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_Miktar.Text.Trim().Length < 2)
            {
                MessageBox.Show("Miktar En az 2 Haneli Olmalıdır..");
                return;
            }
            if (tx_FaturaNo.Text.Trim().Length < 3)
            {
                MessageBox.Show(" Fatura No En Az 3 Haneli Olmalıdır..");
                return;
            }
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Insert(@"insert into tbl_Fatura(miktar,faturaNo,faturaTur_id,tarih,hesap_id)values('" + tx_Miktar.Text + "','" + tx_FaturaNo.Text + "','" + cbx_FaturaTur.SelectedValue + "','" + dtp_tarih.Value + "','"+cbx_HesapNo.SelectedValue+"')");
            Fatura_Load(null, null);
            MessageBox.Show("Fatura Kaydı Eklendi..");
            }
            catch {
                MessageBox.Show("Hata Fatura Numarasını Doğru Giriniz..");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Faturalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Fatura Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@" delete from tbl_Fatura where Fatura_id=" + dgv_Faturalar.SelectedRows[0].Cells["Fatura_id"].Value);
            Fatura_Load(null, null);
            MessageBox.Show(kayitsay + " Fatura Kaydı Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }

        private void dgv_Faturalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Faturalar.SelectedRows.Count == 0)
                return;
            dtp_tarih.Value = Convert.ToDateTime(dgv_Faturalar.SelectedRows[0].Cells["tarih"].Value);
            tx_Miktar.Text = dgv_Faturalar.SelectedRows[0].Cells["miktar"].Value.ToString();
            tx_FaturaNo.Text = dgv_Faturalar.SelectedRows[0].Cells["FaturaNo"].Value.ToString();
            cbx_FaturaTur.Text = dgv_Faturalar.SelectedRows[0].Cells["FaturaTur"].Value.ToString();
            cbx_HesapNo.Text = dgv_Faturalar.SelectedRows[0].Cells["HesapNo"].Value.ToString();
         }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_Miktar.Text = "";
            tx_FaturaNo.Text = "";
            cbx_FaturaTur.SelectedValue = -1;
            cbx_HesapNo.SelectedValue = -1;
            dtp_tarih.Text = "";

            if (dgv_Faturalar.SelectedRows.Count > 0)
                dgv_Faturalar.SelectedRows[0].Selected = false;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_Miktar.Text.Trim().Length < 3)
            {
                MessageBox.Show("Miktar En az 3 Haneli Olmalıdır..");
                return;
            }
            if (tx_FaturaNo.Text.Trim().Length < 3)
            {
                MessageBox.Show(" Fatura No En Az 3 Haneli Olmalıdır..");
                return;
            }
          
        
            int kayitsay = vt.UpdateDelete(@"update tbl_Fatura set miktar = '"+tx_Miktar.Text+"', tarih = '"+dtp_tarih.Text+"', faturaNo = '"+tx_FaturaNo.Text+"', faturaTur_id = '"+cbx_FaturaTur.SelectedValue+"', hesap_id = '"+cbx_HesapNo.SelectedValue+"' where fatura_id = "+ dgv_Faturalar.SelectedRows[0].Cells["Fatura_id"].Value);
            if (kayitsay > 0)
            {
                Fatura_Load(null, null);
                MessageBox.Show("Fatura Bilgileri Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
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
    }
}


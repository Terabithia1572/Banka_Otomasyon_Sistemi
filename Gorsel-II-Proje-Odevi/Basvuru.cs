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
    public partial class Basvuru : MetroFramework.Forms.MetroForm
    {
        public Basvuru()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int KullaniciGiris_id = 2;
        private void Basvuru_Load(object sender, EventArgs e)
        {
            dgv_Basvurular.DataSource = vt.Select(@"select b.basvuru_id,tarih, b.basvuruDurum_id, bd.basvuruDurum, mt.MusteriTur,m.musteri_id,m.ad,m.soyad,m.tc,m.telefon,m.adres,mt.MusteriTur_id,bt.BasvuruTur_id,bt.BasvuruTur,
s.subeAd,s.subeAdres,s.sube_id from tbl_musteri m
 join tbl_basvuru b on m.musteri_id=b.musteri_id 
join tbl_BasvuruTur bt on b.BasvuruTur_id=bt.basvuruTur_id 
join tbl_sube s on s.sube_id=b.sube_id 
join tbl_musteriTur mt on m.MusteriTur_id=mt.MusteriTur_id
join tbl_basvuruDurum bd on bd.basvuruDurum_id=b.basvuruDurum_id");
            dgv_Basvurular.Columns["musteri_id"].Visible = false;
            dgv_Basvurular.Columns["musteriTur_id"].Visible = false;
            dgv_Basvurular.Columns["basvuruTur_id"].Visible = false;
            dgv_Basvurular.Columns["sube_id"].Visible = false;
            dgv_Basvurular.Columns["basvuru_id"].Visible = false;
            dgv_Basvurular.Columns["basvuruDurum_id"].Visible = false;
            
            cbx_BasvuruTur.DataSource = vt.Select(" select basvuruTur_id,basvuruTur from tbl_BasvuruTur");
            cbx_BasvuruTur.DisplayMember = "basvuruTur";
            cbx_BasvuruTur.ValueMember = "basvuruTur_id";

            cbx_Musteri.DataSource = vt.Select("select cast(tc as nvarchar(11))+'- '+ad +' '+ soyad+'- '+Cast(telefon as nvarchar(11)) musteri,musteri_id from tbl_Musteri");
            cbx_Musteri.DisplayMember = "musteri";
            cbx_Musteri.ValueMember = "musteri_id";

         

            cbx_MusteriTur.DataSource = vt.Select("select musteriTur,musteriTur_id from tbl_MusteriTur");
            cbx_MusteriTur.DisplayMember = "MusteriTur";
            cbx_MusteriTur.ValueMember = "musteriTur_id";

            cbx_basvuruDurum.DataSource = vt.Select("select basvuruDurum,BasvuruDurum_id from tbl_BasvuruDurum");
            cbx_basvuruDurum.DisplayMember = "basvuruDurum";
            cbx_basvuruDurum.ValueMember = "BasvuruDurum_id";

          

            cbx_SubeAdresi.DataSource = vt.Select("select  subeAd+' '+subeAdres as subeAdres ,sube_id from tbl_Sube");
            cbx_SubeAdresi.DisplayMember = "subeAdres";
            cbx_SubeAdresi.ValueMember = "sube_id";



            //.Value.ToShortDateString()
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciGiris_id = ((AnaForm)this.MdiParent).KullaniciGiris_id;
                object kayitsay = vt.Select(@"insert into tbl_Basvuru(basvuruTur_id,sube_id,basvuruDurum_id,musteri_id,tarih) values('"+cbx_BasvuruTur.SelectedValue+"','"+cbx_SubeAdresi.SelectedValue+"','"+cbx_basvuruDurum.SelectedValue+"','"+cbx_Musteri.SelectedValue+"','"+dtp_tarih.Value+"')");


          Basvuru_Load(null, null);
                MessageBox.Show("Başvuru Kaydı Eklendi..");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
            }
      

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try { 
            if(dgv_Basvurular.SelectedRows.Count==0)
            {
                MessageBox.Show("Yavaş la Yavaş Silinecek Başvuru Seçiniz..!");
                return;
            }
            int kayitsay = vt.UpdateDelete(@"delete from tbl_Basvuru where basvuru_id=" + dgv_Basvurular.SelectedRows[0].Cells["basvuru_id"].Value);
            Basvuru_Load(null,null);
            MessageBox.Show(kayitsay + " Başvuru Kaydı Silindi...");
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }


        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            if (dgv_Basvurular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Yavaş la Yavaş Güncellenecek Satır Seçiniz..!");
                return;
            }

            int kayitsay = vt.UpdateDelete(@"update tbl_Basvuru set basvuruTur_id='"+cbx_BasvuruTur.SelectedValue+"',sube_id='"+cbx_SubeAdresi.SelectedValue+"',basvuruDurum_id='"+cbx_basvuruDurum.SelectedValue+"',musteri_id='"+cbx_Musteri.SelectedValue+"',tarih='"+dtp_tarih.Value+"' where basvuru_id=" + dgv_Basvurular.SelectedRows[0].Cells["basvuru_id"].Value);
                // int kayitsay = vt.UpdateDelete(@"update tbl_Basvuru set tarih='" + dtp_tarih.Value + "',basvuruTur_id='" + cbx_BasvuruTur.SelectedValue + "',sube_id='" + cbx_SubeAdresi.SelectedValue + "',musteri_id='" + cbx_Musteri.SelectedValue + "',basvuruDurum_id='" + cbx_basvuruDurum.SelectedValue + "' where basvuru_id=" + dgv_Basvurular.SelectedRows[0].Cells["basvuru_id"].Value);

                if (kayitsay > 0)
            {
                Basvuru_Load(null, null);
                MessageBox.Show("Başvuru Türü Güncellendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi Kontrol Ediniz..");
            }
        }
        private void dgv_Basvurular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Basvurular.SelectedRows.Count == 0)
                return;


            cbx_BasvuruTur.Text = dgv_Basvurular.SelectedRows[0].Cells["BasvuruTur"].Value.ToString();
            cbx_basvuruDurum.Text = dgv_Basvurular.SelectedRows[0].Cells["BasvuruDurum"].Value.ToString();
           // cbx_Musteri.Text = dgv_Basvurular.SelectedRows[0].Cells["Musteri"].Value.ToString();
            cbx_MusteriTur.Text = dgv_Basvurular.SelectedRows[0].Cells["MusteriTur"].Value.ToString();
            cbx_SubeAdresi.Text = dgv_Basvurular.SelectedRows[0].Cells["subeAdres"].Value.ToString();
            dtp_tarih.Text= dgv_Basvurular.SelectedRows[0].Cells["tarih"].Value.ToString();

        }
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
      
            cbx_BasvuruTur.SelectedValue = -1;
          cbx_Musteri.SelectedValue = -1;
            cbx_BasvuruTur.SelectedValue = -1;
            cbx_SubeAdresi.SelectedValue = -1;
            cbx_basvuruDurum.SelectedValue = -1;
            cbx_MusteriTur.SelectedValue = -1;

            if (dgv_Basvurular.SelectedRows.Count > 0)
                dgv_Basvurular.SelectedRows[0].Selected = false;
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


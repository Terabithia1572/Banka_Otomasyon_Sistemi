using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel_II_Proje_Odevi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        public int KullaniciGiris_id=1;
        private void tsbtn_Basvuru_Click(object sender, EventArgs e)
        {
            Basvuru bsvr = new Basvuru();
            bsvr.MdiParent = this;
            bsvr.Show();          
        }

        private void tsbtn_Fatura_Click(object sender, EventArgs e)
        {
            Fatura ftr = new Fatura();
            ftr.MdiParent = this;
            ftr.Show();
        }

        private void tsbtn_Musteri_Click(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            mstr.MdiParent = this;
            mstr.Show();
        }

        private void tsbtn_BasvuruTur_Click(object sender, EventArgs e)
        {
            BasvuruTur bsvr = new BasvuruTur();
            bsvr.MdiParent = this;
            bsvr.Show();
        }

        private void tsbtn_BasvuruDurum_Click(object sender, EventArgs e)
        {
            BasvuruDurum a = new BasvuruDurum();
            a.MdiParent = this;
            a.Show();
        }

        private void tsbtn_Personela_Click(object sender, EventArgs e)
        {
            PersonelTur a = new PersonelTur();
            a.MdiParent = this;
            a.Show();
        }

        private void tsbtn_Fatura_islemleri_Click(object sender, EventArgs e)
        {
            FaturaTur b = new FaturaTur();
            b.MdiParent = this;
            b.Show();
        }

        private void tsbtn_kartTur_Click(object sender, EventArgs e)
        {
            KartTur kr = new KartTur();
            kr.MdiParent=this;
            kr.Show();
        }

        private void tsbtn_HesapTur_Click(object sender, EventArgs e)
        {
            hesapTur hp = new hesapTur();
            hp.MdiParent = this;
            hp.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Personel_İslemleri c = new Personel_İslemleri();
            c.MdiParent = this;
            c.Show();
        }

        private void tsbtn_Eft_Click(object sender, EventArgs e)
        {
            Eft eft = new Eft();
            eft.MdiParent = this;
            eft.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Kart kt = new Kart();
            kt.MdiParent = this;
            kt.Show();
        }

        private void tsbtn_Musteri_Click_1(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            mstr.MdiParent = this;
            mstr.Show();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.Exit();
        }

        private void tsbtn_Havale_Click(object sender, EventArgs e)
        {
            Havale hv = new Havale();
            hv.MdiParent = this;
            hv.Show();
        }

        private void tsbtn_musteriTur_Click(object sender, EventArgs e)
        {
            musteriTur mt = new musteriTur();
            mt.MdiParent = this;
            mt.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            transferTur tt = new transferTur();
            tt.MdiParent = this;
            tt.Show();
        }

        private void notifyIconBanka_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void ctnxmenu_Goster_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ctnxmenu_Gizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ctnxmenu_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Sube s = new Sube();
            s.MdiParent = this;
            s.Show();
        }

        private void timerOturum_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        int sure = 1800;
        private void timerSure_Tick(object sender, EventArgs e)
        {
            sure--;
            tslbl_sure.Text = sure / 60 + ":" + sure % 60;
            tspgbr_sure.Value = sure;
            if (sure == 0)
            {
                timerSure.Stop();
                timerOturum.Start();
                DialogResult cevap = MessageBox.Show("Oturum süresi sona erdi. Devam Etmek İstiyor Musunuz?", "Süre Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    timerOturum.Stop();
                    sure = 1801;
                    timerSure.Start();
                }
                else
                    this.Close();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        //    tsbtn_Basvuru_Click(null, null);
            timerSure.Start();
            tslbl_sure.Text = sure / 60 + ":" + sure % 60;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Hesap hh = new Hesap();
            hh.MdiParent=this;
            hh.Show();
        }
    }
}

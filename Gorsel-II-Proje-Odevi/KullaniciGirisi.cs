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
using Microsoft.Win32;

namespace Gorsel_II_Proje_Odevi
{
    public partial class KullaniciGirisi : MetroFramework.Forms.MetroForm
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private object datatable;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_tcNo.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız...");
                return;
            }

            string sifreMD5 = CreateMD5(tx_sifre.Text);

            DataTable dtSonuc = vt.Select(@"select kullaniciTur_id,kullaniciGiris_id,ad,soyad from tbl_kullaniciGiris 
                    where tc='" + tx_tcNo.Text + "' and sifre='" + sifreMD5+ "'");
            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Tc No veya Şifre Hatalı...");
                return;
            }
            if(chbx_beniHatirla.Checked==true)
            {
                Ayarlar.Default.beniHatirla = true;
                Ayarlar.Default.tcNo = tx_tcNo.Text;
                Ayarlar.Default.sifre = tx_sifre.Text;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.Reset();
            }

            this.Hide();
            AnaForm afrm = new AnaForm();
            if (dtSonuc.Rows[0]["kullaniciTur_id"].ToString() != "1")
            {
            //    afrm.tsbtn_Basvuru.Visible = false;
            //    afrm.tsbtn_BasvuruDurum.Visible = false;
            //    afrm.tsbtn_BasvuruTur.Visible = false;
             //   afrm.tsbtn_Eft.Visible = false;

            }
            afrm.KullaniciGiris_id = Convert.ToInt32(dtSonuc.Rows[0]["kullaniciGiris_id"]);
            afrm.Text = "Banka [" + dtSonuc.Rows[0]["ad"].ToString() + " " + dtSonuc.Rows[0]["soyad"].ToString() + "]";
            afrm.Show();
        }
       
            
         

        private void KullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }

        }

        private void chbx_sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreGoster.Checked == true)
                tx_sifre.PasswordChar = '\0';
            else
                tx_sifre.PasswordChar = '*';
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            if (Ayarlar.Default.beniHatirla == true)
            {
                chbx_beniHatirla.Checked = true;
                tx_tcNo.Text = Ayarlar.Default.tcNo;
                tx_sifre.Text = Ayarlar.Default.sifre;
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("KullaniciGirisi").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    chbx_windowsIleBaslama.Checked = true;
                }
            }
            catch
            { }

            tx_sifre.PasswordChar = '●';

        }

        private void chbx_beniHatirla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void chbx_windowsIleBaslama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_windowsIleBaslama.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("KullaniciGirisi", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("KullaniciGirisi");
            }
        }
    }
}

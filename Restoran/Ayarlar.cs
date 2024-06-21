using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._gorevId);

            if (gorev == "Yönetici")
            {
                cp.personelBilgileriGetir(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriGetirlv(lv_Personeller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = true;
                btnEkle.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki : Yönetici / Yetki Sınırsız / Kullanıcı : " + cp.personelinBilgisiniGetirisim(cGenel._personelId);
            }
            else
            {
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    groupBox4.Visible = false;
                    lblBilgi.Text = "Mevki : Personel / Yetki Sınırlı / Kullanıcı : " + cp.personelinBilgisiniGetirisim(cGenel._personelId);
                }
            }
        }

        private void btn_degis1_Click(object sender, EventArgs e)
        {
            if (txtSifreYeni.Text.Trim() != "" || txtSifreYeniTekrar.Text.Trim() != "")
            {
                if (txtSifreYeni.Text == txtSifreYeniTekrar.Text)
                {
                    if (txtPersonelID.Text != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelID.Text), txtSifreYeni.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleştirildi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbirleriyle Eşleşmiyor!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakamazsınız.");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId.Text = Convert.ToString(c.PersonelGorevId);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lv_Personeller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelSil(Convert.ToInt32(lv_Personeller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla Silinmiştir.");
                        c.personelBilgileriGetirlv(lv_Personeller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silinemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" & txtSoyad.Text.Trim() != "" & txtSifre.Text.Trim() != "" & txtSifreTekrar.Text.Trim() != "" & txtGorevId.Text.Trim() != "")
            {
                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifreTekrar.Text;
                    c.personelGorevId = Convert.ToInt32(txtGorevId.Text);
                    bool sonuc = c.personelEkle(c);

                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla Eklenmiştir.");
                        c.personelBilgileriGetirlv(lv_Personeller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbirleriyle Eşleşmiyor!, Şifreniz 5 karakterden uzun olmalıdır.");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız.");
            }
        }


        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.ReadOnly = false;
            txtSifre.ReadOnly = false;
            if (lv_Personeller.SelectedItems.Count > 0)
            {
                if (txtAd.Text != "" || txtSoyad.Text != "" || txtSifre.Text != "" || txtSifreTekrar.Text != "" || txtGorevId.Text != "")
                {
                    if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifreTekrar.Text;
                        c.personelGorevId = Convert.ToInt32(txtGorevId.Text);
                        bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelID2.Text));

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt başarıyla değiştirilmiştir.");
                            c.personelBilgileriGetirlv(lv_Personeller);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt değiştirilemedi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Birbirleriyle Eşleşmiyor!");
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz.");
            }
        }

        private void btn_degis2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Trim() != "" || textBox12.Text.Trim() != "")
            {
                if (textBox11.Text == textBox12.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox11.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleştirildi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbirleriyle Eşleşmiyor!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakamazsınız.");
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnBilgiDegistir.Enabled = false;
            btnEkle.Enabled = true;
            txtSifreTekrar.ReadOnly = false;
            txtSifre.ReadOnly = false;
        }

        private void lv_Personeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Personeller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                txtPersonelID2.Text = lv_Personeller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lv_Personeller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lv_Personeller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lv_Personeller.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnSil.Enabled = false;
            }
        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;
            txtPersonelID.Text = Convert.ToString(c.PersonelId);
        }
    }
}

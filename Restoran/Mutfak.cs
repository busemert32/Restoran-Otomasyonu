using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }

        cUrunCesitleri uc = new cUrunCesitleri();
        cUrunler u = new cUrunler();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (txt_ürünAd.Text.Trim() == "" || txt_ürünfiyat.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ürün adı, fiyatı ve kategori seçilmemiştir.", "Dikkat! Bilgiler eksik.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string urunAdi = txt_ürünAd.Text.Trim();

                    if (u.UrunAdiKontrol(urunAdi))
                    {
                        MessageBox.Show("Bu ürün adı zaten kullanılmıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cUrunler c = new cUrunler();
                        c.Fiyat = Convert.ToDecimal(txt_ürünfiyat.Text);
                        c.Urunad = urunAdi;
                        c.Urunturno = urunturNo;
                        int sonuc = c.urunEkle(c);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün eklenmiştir");
                            yenile();
                            Temizle();
                        }
                    }
                }
            }
            else
            {
                if (txt_KategoriAd.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz", "Dikkat! Bilgiler eksik.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string kategoriAdi = txt_KategoriAd.Text.Trim();

                    if (uc.KategoriAdiKontrol(kategoriAdi))
                    {
                        MessageBox.Show("Bu kategori adı zaten kullanılmıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cUrunCesitleri ürün = new cUrunCesitleri();
                        ürün.KategoriAd = kategoriAdi;
                        int sonuc = ürün.urunKategoriEkle(ürün);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Kategori eklenmiştir");
                            yenile();
                            Temizle();
                        }
                    }
                }
            }
        }

        private void yenile()
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriniGetir1(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            uc.urunCesitleriniGetir2(lvkategoriler);
            cUrunler c = new cUrunler();
            c.urunleriListele(lv_ürünListesi);
        }

        private void Mutfak_Load_1(object sender, EventArgs e)
        {
            cUrunCesitleri Anakategori = new cUrunCesitleri();
            Anakategori.urunCesitleriniGetir1(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;

            label4.Visible = false;
            txtArama.Visible = false;

            cUrunler c = new cUrunler();
            c.urunleriListele(lv_ürünListesi);
        }

        private void Temizle()
        {
            txt_ürünAd.Clear();
            txt_ürünfiyat.Clear();
            txt_ürünfiyat.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnBul_Click_1(object sender, EventArgs e)
        {
            label4.Visible = true;
            txtArama.Visible = true;
        }

        private void btnDegis_Click(object sender, EventArgs e)
        {

            if (rbAltkategori.Checked)
            {
                if (txt_ürünAd.Text.Trim() == "" || txt_ürünfiyat.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ürün adı, fiyatı ve kategori seçilmemiştir.", "Dikkat! Bilgiler eksik.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txt_ürünfiyat.Text);
                    c.Urunad = txt_ürünAd.Text;
                    c.Urunid = Convert.ToInt32(txtUrunId.Text);
                    c.Urunturno = urunturNo;
                    int sonuc = c.urunleriGüncelle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Güncellenmiştir");
                        yenile();
                        Temizle();
                    }

                }

            }
            else
            {
                if (txtKategoriID.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz", "Dikkat! Bilgiler eksik.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri ürün = new cUrunCesitleri();
                    ürün.KategoriAd = txt_KategoriAd.Text;
                    ürün.UrunTurNo = Convert.ToInt32(txtKategoriID.Text);
                    int sonuc = ürün.urunKategoriGüncelle(ürün);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori güncellenmiştir");
                        ürün.urunCesitleriniGetir2(lvkategoriler);
                        Temizle();
                    }
                }
            }
        }

        private void rbAnaKategori_CheckedChanged_1(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnakategori.Visible = true;
            lvkategoriler.Visible = true;
            lv_ürünListesi.Visible = false;
            yenile();
        }

        private void rbAltkategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnakategori.Visible = false;
            lvkategoriler.Visible = false;
            lv_ürünListesi.Visible = true;
            yenile();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                cUrunler u = new cUrunler();
                u.urunleriListeleByUrunAdi(lv_ürünListesi, txtArama.Text);
            }
            else
            {
                cUrunCesitleri uc = new cUrunCesitleri();
                uc.urunCesitleriniGetir3(lvkategoriler, txtArama.Text); ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (lv_ürünListesi.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürün silmekte emin misiniz?", "Dikkat! Bilgiler silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler c = new cUrunler();
                        c.Urunid = Convert.ToInt32(txtUrunId.Text);
                        int sonuc = c.urunSil(c, 1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir");
                            cbKategoriler_SelectedIndexChanged(sender, e);
                            yenile();
                            Temizle();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Silmek için bir ürün seçiniz.", "Dikkat! Ürün seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                if (lvkategoriler.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Kategori silmekte emin misiniz?", "Dikkat! Bilgiler silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunCesitleri uc = new cUrunCesitleri();
                        int sonuc = uc.urunKategoriSil(Convert.ToInt32(txtKategoriID.Text));
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Kategori Silinmiştir");
                            cUrunler c = new cUrunler();
                            c.Urunid = Convert.ToInt32(txtKategoriID.Text);
                            c.urunSil(c, 0);
                            yenile();
                            Temizle();
                        }

                    }

                }
            }
        }

        private void lvkategoriler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvkategoriler.SelectedItems.Count > 0)
            {
                txt_KategoriAd.Text = lvkategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriID.Text = lvkategoriler.SelectedItems[0].SubItems[0].Text;

                //  cbKategoriler.SelectedIndex = Convert.ToInt32(txtUrunId.Text);
            }
        }

        private void lv_ürünListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_ürünListesi.SelectedItems.Count > 0)
{
                txt_ürünAd.Text = lv_ürünListesi.SelectedItems[0].SubItems[3].Text;


                if (decimal.TryParse(lv_ürünListesi.SelectedItems[0].SubItems[4].Text, out decimal fiyat))
                {
                    txt_ürünfiyat.Text = fiyat.ToString();
                }
                else
                {

                    txt_ürünfiyat.Text = "Geçersiz Fiyat";
                }

                txtUrunId.Text = lv_ürünListesi.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void panelUrun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvkategoriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int kategoriId = Convert.ToInt32(lvkategoriler.SelectedItems[0].SubItems[0].Text);
            string kategoriAdi = lvkategoriler.SelectedItems[0].SubItems[1].Text;
            txtKategoriID.Text = kategoriId.ToString();
            txt_KategoriAd.Text = kategoriAdi;
        }

        int urunturNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();

            if (cbKategoriler.SelectedItem is cUrunCesitleri cesit)
            {
                urunturNo = cesit.UrunTurNo;
                u.urunleriListelebyUrunID(lv_ürünListesi, urunturNo);
            }
        }
    }
}


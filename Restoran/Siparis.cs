using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Siparis : Form
    {
        cGenel gnl = new cGenel();
        public Siparis()
        {
            InitializeComponent();
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void islem(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "button1":
                    txt_adet.Text += (1).ToString();
                    break;
                case "button2":
                    txt_adet.Text += (2).ToString();
                    break;
                case "button3":
                    txt_adet.Text += (3).ToString();
                    break;
                case "button4":
                    txt_adet.Text += (4).ToString();
                    break;
                case "button5":
                    txt_adet.Text += (5).ToString();
                    break;
                case "button6":
                    txt_adet.Text += (6).ToString();
                    break;
                case "button7":
                    txt_adet.Text += (7).ToString();
                    break;
                case "button8":
                    txt_adet.Text += (8).ToString();
                    break;
                case "button9":
                    txt_adet.Text += (9).ToString();
                    break;
                case "button0":
                    txt_adet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı gir");
                    break;
            }
        }
        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            if (txt_arama.Text == "")
            {
                txt_arama.Text = "";
            }
            else
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.getByProductSearch(lv_urun_tablosu, Convert.ToInt32(txt_arama.Text));
            }
        }
        int tableId; int AdditionId;
        private void Siparis_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = cGenel._ButtonValue;

            cMasalar ms = new cMasalar();
            tableId = ms.MasaNumarası(cGenel._ButtonName);
            if (ms.MasaNumarasıDurum(tableId, 2) == true)
            {
                cAdisyon Ad = new cAdisyon();
                AdditionId = Ad.AdisyonVer(tableId);
                cSiparis siparisler = new cSiparis();
                siparisler.siparisleriGetir(lv_Siparisler, AdditionId);
            }


            button0.Click += new EventHandler(islem);
            button1.Click += new EventHandler(islem);
            button2.Click += new EventHandler(islem);
            button3.Click += new EventHandler(islem);
            button4.Click += new EventHandler(islem);
            button5.Click += new EventHandler(islem);
            button6.Click += new EventHandler(islem);
            button7.Click += new EventHandler(islem);
            button8.Click += new EventHandler(islem);
            button9.Click += new EventHandler(islem);
        }

        cUrunCesitleri Uc = new cUrunCesitleri();
        private void btn_anayemek1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_anayemek1);
        }

        private void btn_salata2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_salata2);
        }

        private void btn_corba3_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_corba3);
        }

        private void btn_pide4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_pide4);
        }

        private void btn_tatli5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_tatli5);
        }

        private void btn_icicek6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lv_urun_tablosu, btn_icicek6);
        }

        int sayac = 0; int sayac2 = 0;
        private void lv_urun_tablosu_DoubleClick(object sender, EventArgs e)
        {
            if (txt_adet.Text == "")
            {
                txt_adet.Text = "1";
            }

            if (lv_urun_tablosu.Items.Count > 0)
            {
                sayac = lv_Siparisler.Items.Count;
                lv_Siparisler.Items.Add(lv_urun_tablosu.SelectedItems[0].Text);
                lv_Siparisler.Items[sayac].SubItems.Add(txt_adet.Text);
                lv_Siparisler.Items[sayac].SubItems.Add(lv_urun_tablosu.SelectedItems[0].SubItems[2].Text);
                lv_Siparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lv_urun_tablosu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txt_adet.Text)).ToString());
                lv_Siparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lv_yeni.Items.Count;
                lv_Siparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lv_yeni.Items.Add(AdditionId.ToString());
                lv_yeni.Items[sayac2].SubItems.Add(lv_urun_tablosu.SelectedItems[0].SubItems[2].Text);
                lv_yeni.Items[sayac2].SubItems.Add(txt_adet.Text);
                lv_yeni.Items[sayac2].SubItems.Add(tableId.ToString());
                lv_yeni.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;

                txt_adet.Text = "";

            }
        }

        ArrayList silinenler = new ArrayList();

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            cMasalar masa = new cMasalar();
            Masalar ms = new Masalar();
            cAdisyon yeniAdisyonekle = new cAdisyon();
            cSiparis siparisiTut = new cSiparis();
            bool sonuc = false;

            if (masa.MasaNumarasıDurum(tableId, 1) == true)
            {
                yeniAdisyonekle.SERVISTURNO = 1;
                yeniAdisyonekle.PERSONELID1 = 1;
                yeniAdisyonekle.MASAID = tableId;
                yeniAdisyonekle.TARIH = DateTime.Now;
                sonuc = yeniAdisyonekle.YeniAdisyon(yeniAdisyonekle);
                masa.MasaDurumuDegis(cGenel._ButtonName, 2);

                if (lv_Siparisler.Items.Count > 0)
                {
                    foreach (ListViewItem item in lv_Siparisler.Items)
                    {
                        int urunID = Convert.ToInt32(item.SubItems[2].Text);
                        int adet = Convert.ToInt32(item.SubItems[1].Text);

                        // Sipariş daha önce eklenmiş mi kontrol et
                        bool urunVarMi = siparisiTut.UrunVarMi(yeniAdisyonekle.AdisyonVer(tableId), urunID);

                        if (!urunVarMi)
                        {
                            siparisiTut.MASAID = tableId;
                            siparisiTut.URUNID = urunID;
                            siparisiTut.ADİSYONID = yeniAdisyonekle.AdisyonVer(tableId);
                            siparisiTut.ADET = adet;
                            siparisiTut.siparisleriTut(siparisiTut);
                        }
                    }

                    this.Close();
                    ms.Show();
                }
            }
            else if (masa.MasaNumarasıDurum(tableId, 2) == true)
            {
                if (lv_yeni.Items.Count > 0)
                {
                    foreach (ListViewItem item in lv_yeni.Items)
                    {
                        int urunID = Convert.ToInt32(item.SubItems[1].Text);
                        int adet = Convert.ToInt32(item.SubItems[2].Text);

                        // Sipariş daha önce eklenmiş mi kontrol et
                        bool urunVarMi = siparisiTut.UrunVarMi(yeniAdisyonekle.AdisyonVer(tableId), urunID);

                        if (!urunVarMi)
                        {
                            siparisiTut.MASAID = tableId;
                            siparisiTut.URUNID = urunID;
                            siparisiTut.ADİSYONID = yeniAdisyonekle.AdisyonVer(tableId);
                            siparisiTut.ADET = adet;
                            siparisiTut.siparisleriTut(siparisiTut);
                        }
                    }
                }
                cGenel._AdisyonId = Convert.ToString(yeniAdisyonekle.AdisyonVer(tableId));

                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        siparisiTut.siparisiSil(Convert.ToInt32(item));
                    }
                }

                this.Close();
                ms.Show();
            }
        }

        private void btn_öde_Click(object sender, EventArgs e)
        {
            cGenel._ServisTurNo = 1;
            cGenel._AdisyonId = AdditionId.ToString();
            Fatura frm = new Fatura();
            this.Close();
            frm.Show();
        }

        private void lv_Siparisler_DoubleClick(object sender, EventArgs e)
        {

            if (lv_Siparisler.SelectedItems.Count > 0)
            {
                int satisId = Convert.ToInt32(lv_Siparisler.SelectedItems[0].SubItems[4].Text);

                cSiparis saveOrder = new cSiparis();
                saveOrder.siparisiSil(satisId);

                lv_Siparisler.Items.RemoveAt(lv_Siparisler.SelectedItems[0].Index);
            }
        }
    }
}
 


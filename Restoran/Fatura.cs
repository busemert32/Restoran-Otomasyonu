using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Fatura : Form
    {
        private ArrayList silinenler = new ArrayList();

        public Fatura()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        cSiparis cs = new cSiparis();
        private void Fatura_Load(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                lb_adisyonID.Text = cGenel._AdisyonId;
                txt_indirim.TextChanged += new EventHandler(txt_indirim_TextChanged);
                cs.siparisleriGetir(lvUrunler, Convert.ToInt32(lb_adisyonID.Text));

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    foreach (ListViewItem item in lvUrunler.Items)
                    {
                        toplam += Convert.ToDecimal(item.SubItems[3].Text);
                    }
                    lb_toplam.Text = string.Format("{0:0.000}", toplam);
                    lb_odenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lb_odenecek.Text) * 18 / 100;
                    lb_kdv.Text = string.Format("{0:0.000}", kdv);
                }

                gb_indirim.Visible = !checkBox_indirim.Checked;
                txt_indirim.Clear();
            }
        }

        private void txt_indirim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal indirimTutari = Convert.ToDecimal(txt_indirim.Text);
                if (indirimTutari < Convert.ToDecimal(lb_toplam.Text))
                {
                    lb_indirim.Text = string.Format("{0:0.000}", indirimTutari);
                }
                else
                {
                    MessageBox.Show("İndirim tutarı toplam tutardan fazla olamaz");
                }
            }
            catch (Exception)
            {
                lb_indirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void checkBox_indirim_CheckedChanged(object sender, EventArgs e)
        {
            gb_indirim.Visible = !checkBox_indirim.Checked;
            txt_indirim.Clear();
        }

        private void lb_indirim_TextChanged(object sender, EventArgs e)
        {
            decimal indirim = Convert.ToDecimal(lb_indirim.Text);
            if (indirim > 0)
            {
                decimal odenecek = Convert.ToDecimal(lb_toplam.Text) - indirim;
                lb_odenecek.Text = string.Format("{0:0.000}", odenecek);
            }

            decimal kdv = Convert.ToDecimal(lb_odenecek.Text) * 18 / 100;
            lb_kdv.Text = string.Format("{0:0.000}", kdv);
        }
        cMasalar masalar = new cMasalar();
        cSiparis siparisTut = new cSiparis();
        private void btn_öde_Click(object sender, EventArgs e)
        {
            masalar.MasaDurumuDegis(cGenel._ButtonName, 1);

            if (cGenel._ServisTurNo == 1)
            {
                int masaId = masalar.MasaNumarası(cGenel._ButtonName);

                int odemeTurId = 0;
                if (rbNakit.Checked) odemeTurId = 1;
                if (rbKrediKart.Checked) odemeTurId = 2;
                if (rbTicket.Checked) odemeTurId = 3;

                cOdeme odeme = new cOdeme
                {
                    AdisyonID = Convert.ToInt32(lb_adisyonID.Text),
                    OdemeTurId = odemeTurId,
                    AraToplam = Convert.ToDecimal(lb_odenecek.Text),
                    Kdvtutari = Convert.ToDecimal(lb_kdv.Text),
                    GenelToplam = Convert.ToDecimal(lb_toplam.Text),
                    Indirim = Convert.ToDecimal(lb_indirim.Text)
                };

                try
                {
                    bool result = odeme.billClose(odeme);

                    if (result)
                    {
                        MessageBox.Show("Hesap kapatıldı");

                        masalar.MasaDurumuDegis(masaId.ToString(), 1);

                        cAdisyon a = new cAdisyon();
                        a.adisyonKapat(Convert.ToInt32(lb_adisyonID.Text), 0);

                        foreach (ListViewItem item in lvUrunler.Items)
                        {
                            int satisId = Convert.ToInt32(item.SubItems[4].Text);
                            silinenler.Add(satisId.ToString());
                        }

                        foreach (string item in silinenler)
                        {
                            int satisId = Convert.ToInt32(item);
                            siparisTut.siparisiSil(satisId);
                        }

                        this.Close();
                        Masalar frm = new Masalar();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hesap kapatılırken hata oluştu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void btn_hesapÖzet_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font İcerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;

            int startX = 150;
            int startY = 280;
            int lineHeight = 30;

            e.Graphics.DrawString("--------------------", Baslik, sb, 350, 100, st);
            e.Graphics.DrawString("RESTORAN OTOMASYONU", altBaslik, sb, 350, 120, st);

            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                Font icerikFont = new Font("Verdana", 12);
                e.Graphics.DrawString("Ürün Adı            Adet          Fiyat", altBaslik, sb, 200, 200, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerikFont, sb, startX, startY + i * lineHeight, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerikFont, sb, startX + 200, startY + i * lineHeight, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerikFont, sb, startX + 300, startY + i * lineHeight, st);
            }

            startY += (lvUrunler.Items.Count + 1) * lineHeight;

            e.Graphics.DrawString("----------------------------------------------------------", altBaslik, sb, startX, startY, st);
            e.Graphics.DrawString("İndirim Tutarı     :----------- " + lb_indirim.Text + " TL", altBaslik, sb, startX + 100, startY + lineHeight, st);
            e.Graphics.DrawString("KDV Tutarı         :----------- " + lb_kdv.Text + " TL", altBaslik, sb, startX + 100, startY + 2 * lineHeight, st);
            e.Graphics.DrawString("Toplam Tutar      :----------- " + lb_toplam.Text + " TL", altBaslik, sb, startX + 100, startY + 3 * lineHeight, st);
            e.Graphics.DrawString("Ödediğiniz Tutar :----------- " + lb_odenecek.Text + " TL", altBaslik, sb, startX + 100, startY + 4 * lineHeight, st);
        }
    }
}

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
    public partial class GİRİS_EKRANI : Form
    {
        public GİRİS_EKRANI()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool sonuc = p.personelGirisKontrolu(cGenel._personelId, txt_sifre.Text);
            if (sonuc)
            {
                cPersonelHareketleri ph = new cPersonelHareketleri();
                ph.PersonelId = cGenel._personelId;
                ph.Islem = "Giriş Yaptı";
                ph.Tarih = DateTime.Now;
                ph.PersonelHareketleriniKaydet(ph);


                Ana_Sayfa anasayfa = new Ana_Sayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı parola!");
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_Kullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cb_Kullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.personelGorevId;
        }

        private void GİRİS_EKRANI_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelBilgileriGetir(cb_Kullanici);
        }
    }
}

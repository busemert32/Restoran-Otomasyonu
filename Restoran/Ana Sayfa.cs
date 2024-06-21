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
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;// form içinde form açılabilir
        }

        private void FormGetir(Form frm)//method
        {
            panel_form.Controls.Clear();//paneli temizle
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel_form.Controls.Add(frm);//frm deki formu anasayfadaki panele ekle
            frm.Show();// formu göster
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        cUrunCesitleri Uc = new cUrunCesitleri();
        private void btn_anaS_Click_1(object sender, EventArgs e)
        {

        }

        private void AyarlaButonGorunurluk()
        {
            if (cGenel._personelId == 3) 
            {
                btn_mutfak.Visible = false;
                btn_rapor.Visible = false;
            }
            else if (cGenel._personelId == 4) 
            {
                btn_mutfak.Visible = true;
                btn_rapor.Visible = true;
            }
        }

        private void btn_masa_Click(object sender, EventArgs e)
        {
            Masalar ms = new Masalar();
            FormGetir(ms);
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            FormGetir(ayar);
        }

        private void btn_mutfak_Click(object sender, EventArgs e)
        {
            Mutfak mt = new Mutfak();
            FormGetir(mt);
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            HesapOdemeleriForm rapor = new HesapOdemeleriForm();
            FormGetir(rapor);
        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {
            AyarlaButonGorunurluk();
        }
    }
}

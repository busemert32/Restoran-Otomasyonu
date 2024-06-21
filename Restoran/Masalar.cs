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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void masaGetir()
        {
            Siparis siparis = new Siparis();
            siparis.Show();
        }

        private void btn_masa1_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa1.Text.Length;
            cGenel._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa1.Name;
            masaGetir();
        }

        private void btn_masa2_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa2.Text.Length;
            cGenel._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa2.Name;
            masaGetir();
        }

        private void btn_masa3_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa3.Text.Length;
            cGenel._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa3.Name;
            masaGetir();
        }

        private void btn_masa4_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa4.Text.Length;
            cGenel._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa4.Name;
            masaGetir();
        }

        private void btn_masa5_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa5.Text.Length;
            cGenel._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa5.Name;

            masaGetir();
        }

        private void btn_masa6_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa6.Text.Length;
            cGenel._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa6.Name;
            masaGetir();
        }

        private void btn_masa7_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa7.Text.Length;
            cGenel._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa7.Name;
            masaGetir();
        }

        private void btn_masa8_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa8.Text.Length;
            cGenel._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa8.Name;
            masaGetir();
        }

        private void btn_masa9_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa9.Text.Length;
            cGenel._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa9.Name;
            masaGetir();
        }

        private void btn_masa10_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa10.Text.Length;
            cGenel._ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa10.Name;
            masaGetir();
        }

        private void btn_masa11_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa11.Text.Length;
            cGenel._ButtonValue = btnMasa11.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa11.Name;
            masaGetir();
        }

        private void btn_masa12_Click(object sender, EventArgs e)
        {
            int uzunluk = btnMasa12.Text.Length;
            cGenel._ButtonValue = btnMasa12.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa12.Name;
            masaGetir();
        }
        cGenel gnl = new cGenel();
        private void Masalar_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select DURUM,ID from masalar", connection);
            SqlDataReader dr = null;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "1")
                        {
                            item.BackColor = Color.LightGreen;

                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    


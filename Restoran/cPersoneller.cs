using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran
{
    internal class cPersoneller
    {

        cGenel gnl = new cGenel();

        private int _PersonelId;
        private int _personelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int personelGorevId { get => _personelGorevId; set => _personelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }

        public bool personelGirisKontrolu(int kullaniciId, string sifre)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select * from personeller where ID=@Id and PAROLA=@sifre ", connection);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = kullaniciId;
            cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
            return sonuc;
        }

        public void personelBilgileriGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select * from personeller", connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._personelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                cb.Items.Add(p);
            }
            dr.Close();
            connection.Close();
        }

        public override string ToString()
        {
            return PersonelKullaniciAdi;
        }

        public void personelBilgileriGetirlv(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select personeller.*, personelGorevleri.GOREV from personeller Inner join personelGorevleri on personelGorevleri.ID=personeller.GOREVID  where personeller.Durum=0", connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                i++;
            }
            dr.Close();
            connection.Close();
        }

        public string personelinBilgisiniGetirisim(int perId)
        {
            string sonuc = "";

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select AD + SOYAD from personeller  where personeller.Durum=0 and personeller.ID=@perID", connection);

            cmd.Parameters.Add("@perID", SqlDbType.Int).Value = perId;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }

        public bool personelSifreDegistir(int personelID, string sifre)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("update personeller set PAROLA=@sifre where ID=@perId", connection);

            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = personelID;
            cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }

        public bool personelEkle(cPersoneller cp)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert into personeller(AD,SOYAD,PAROLA,GOREVID) values(@AD,@SOYAD,@PAROLA,@GOREVID)", connection);

            cmd.Parameters.Add("@AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GOREVID", SqlDbType.Int).Value = _personelGorevId;


            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }

        public bool personelGuncelle(cPersoneller cp,int perId)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("update personeller set AD=@AD,SOYAD=@SOYAD,PAROLA=@PAROLA,GOREVID=@GOREVID where ID=@perID", connection);

            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perId;
            cmd.Parameters.Add("AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("GOREVID", SqlDbType.Int).Value = _personelGorevId;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }

        public bool personelSil(int perId)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("update personeller set Durum=1 where ID=@perID", connection);

            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perId;


            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }
    }
}


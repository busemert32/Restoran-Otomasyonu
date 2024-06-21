using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class cUrunCesitleri
    {
        cGenel gnl = new cGenel();

        private int _UrunTurNo;
        private string _KategoriAd;

        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }

        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT,urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KATEGORIID=@KATEGORIID", connection);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
               Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            connection.Dispose();
            connection.Close();
        }

        public void getByProductSearch(ListView Cesitler, int txt)
        {
            Cesitler.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select * from urunler where ID=@ID", connection);

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = txt;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            connection.Dispose();
            connection.Close();
        }

        public void urunCesitleriniGetir1(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where Durum=0", connection);
            SqlDataReader dr = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cUrunCesitleri uc = new cUrunCesitleri();
                    uc._UrunTurNo = Convert.ToInt32(dr["ID"]);
                    uc._KategoriAd = dr["KATEGORIADI"].ToString();

                    cb.Items.Add(uc);
                }
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
        }

        public void urunCesitleriniGetir2(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where Durum=0", connection);
            SqlDataReader dr = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    sayac++;
                }
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
        }

        public void urunCesitleriniGetir3(ListView lv, string source)
        {
            lv.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where Durum=0 and KATEGORIADI like '%' + @source + '%'", connection);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@source", SqlDbType.VarChar).Value = source;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    sayac++;
                }
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
        }

        public int urunKategoriEkle(cUrunCesitleri u)
        {
            int sonuc = 0;
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into kategoriler(KATEGORIADI) values (@KATEGORIADI)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public int urunKategoriGüncelle(cUrunCesitleri uc)
        {
            int sonuc = 0;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Update kategoriler set KATEGORIADI=@KATEGORIADI where ID=@KATID", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = uc._KategoriAd;
                cmd.Parameters.Add("@KATID", SqlDbType.Int).Value = uc.UrunTurNo;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        public int urunKategoriSil(int id)
        {
            int sonuc = 0;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Update kategoriler set Durum=1 where ID=@KATID", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@KATID", SqlDbType.Int).Value = id;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        public override string ToString()
        {
            return KategoriAd;
        }

        public bool KategoriAdiKontrol(string kategoriAdi)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM kategoriler WHERE KATEGORIADI = @kategoriAdi", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@kategoriAdi", SqlDbType.VarChar).Value = kategoriAdi;

                int kategoriAdiSayisi = (int)cmd.ExecuteScalar();

                return kategoriAdiSayisi > 0; // Eğer 0'dan büyükse, aynı kategori adı kullanılmış demektir.
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                return false; // Hata durumunu ele almak için gerekli işlemleri yapabilirsiniz.
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
        }


    }
}

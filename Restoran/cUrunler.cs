using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restoran
{
    internal class cUrunler
    {
        cGenel gnl = new cGenel();

        private int _urunid;
        private int _urunturno;
        private string _urunad;
        private decimal _fiyat;

        public int Urunid { get => _urunid; set => _urunid = value; }
        public int Urunturno { get => _urunturno; set => _urunturno = value; }
        public string Urunad { get => _urunad; set => _urunad = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }

        public void urunleriListeleByUrunAdi(ListView lv, string urunAdi)
        {
            lv.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("SELECT urunler.*, KATEGORIID FROM urunler INNER JOIN kategoriler ON kategoriler.ID = urunler.KATEGORIID WHERE urunler.Durum = 0 AND URUNAD LIKE '%' + @urunAdi + '%'", connection);

            cmd.Parameters.Add("@urunAdi", SqlDbType.VarChar).Value = urunAdi;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    int sayac = 0;
                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ID"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());
                        sayac++;
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public int urunEkle(cUrunler u)
        {
            int sonuc = 0;
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into urunler(KATEGORIID,URUNAD,FIYAT) values (@katId,@urunAd,@fiyat)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@fiyat", SqlDbType.Int).Value = u.Fiyat;

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

        public void urunleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select urunler.*,KATEGORIADI  from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID Where urunler.Durum=0", connection);
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());
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

        public int urunleriGüncelle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Update urunler set URUNAD=@urunad,KATEGORIID=@katID,FIYAT=@fiyat where ID=@urunID", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@fiyat", SqlDbType.Int).Value = u.Fiyat;
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;
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

        public int urunSil(cUrunler u, int kat)
        {
            int sonuc = 0;

            SqlConnection connection = new SqlConnection(gnl.connection);

            string sql = "Update urunler set Durum=1 where ";
            if (kat == 0)
            {
                sql += "KATEGORIID=@urunID";
            }
            else
            {
                sql += "ID=@urunID";
            }

            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;
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

        public void urunleriListelebyUrunID(ListView lv, int urunId)
        {
            lv.Items.Clear();
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select urunler.* ,KATEGORIADI from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID Where urunler.Durum=0 and urunler.KATEGORIID=@urunID", connection);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = urunId;
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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());
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
       
        public bool UrunAdiKontrol(string urunAdi)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM urunler WHERE URUNAD = @urunAdi AND Durum = 0", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@urunAdi", SqlDbType.VarChar).Value = urunAdi;

                int urunAdiSayisi = (int)cmd.ExecuteScalar();

                return urunAdiSayisi > 0; 
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                return false; 
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
        }
    }

}

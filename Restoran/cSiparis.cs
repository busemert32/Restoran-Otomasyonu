using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Restoran
{
    internal class cSiparis
    {

        cGenel gnl = new cGenel();

        private int _ID;
        private int _ADİSYONID;
        private int _URUNID;
        private int _ADET;
        private int _MASAID;

        public int ID { get => _ID; set => _ID = value; }
        public int ADİSYONID { get => _ADİSYONID; set => _ADİSYONID = value; }
        public int URUNID { get => _URUNID; set => _URUNID = value; }
        public int ADET { get => _ADET; set => _ADET = value; }
        public int MASAID { get => _MASAID; set => _MASAID = value; }

        public void siparisleriGetir(ListView lv, int AdisyonId)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT,satislar.ID,URUNID,satislar.ADET From satislar Inner Join urunler on satislar.URUNID=urunler.ID where satislar.ADISYONID=@AdisyonId", connection);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
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
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }

        }

        public bool siparisleriTut(cSiparis Bilgiler)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into satislar(ADISYONID,URUNID,MASAID,ADET) values(@AdisyonNo,@UrunId,@masaId,@Adet)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler.ADİSYONID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler.URUNID;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Bilgiler.MASAID;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler.ADET;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
            return sonuc;

        }

        public bool UrunVarMi(int adisyonID, int urunID)
        {
            bool varMi = false;

            using (SqlConnection connection = new SqlConnection(gnl.connection))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM satislar WHERE ADISYONID = @AdisyonID AND URUNID = @UrunID", connection);
                    cmd.Parameters.AddWithValue("@AdisyonID", adisyonID);
                    cmd.Parameters.AddWithValue("@UrunID", urunID);

                    int count = (int)cmd.ExecuteScalar();

                    varMi = (count > 0);
                }
                catch (SqlException ex)
                {
                    // Hata yönetimi
                    string hata = ex.Message;
                }

                return varMi;
            }
        }

        public void siparisiSil(int SatisId)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM satislar WHERE ID = @SatisId", connection);
                cmd.Parameters.Add("@SatisId", SqlDbType.Int).Value = SatisId;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Dispose();
                connection.Close();
            }
        }


    }
}

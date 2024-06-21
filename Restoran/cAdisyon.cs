using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class cAdisyon
    {
        cGenel gnl = new cGenel();

        private int _ID;
        private int _SERVISTURNO;
        private int PERSONELID;
        private int _MASAID;
        private DateTime _TARIH;
        private int _DURUM;
        private decimal _Tutar;

        public int ID { get => _ID; set => _ID = value; }
        public int SERVISTURNO { get => _SERVISTURNO; set => _SERVISTURNO = value; }
        public int PERSONELID1 { get => PERSONELID; set => PERSONELID = value; }
        public int MASAID { get => _MASAID; set => _MASAID = value; }
        public DateTime TARIH { get => _TARIH; set => _TARIH = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }

        public int AdisyonVer(int MasaId)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From adisyonlar Where MASAID=@MasaId Order by ID desc", connection);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return MasaId;
        }

        public bool YeniAdisyon(cAdisyon Bilgiler)
        {
            bool sonuc = false;

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into adisyonlar(SERVISTURNO,MASAID,Durum) values(@ServisTurNo,@MasaId,@Durum)", connection);


            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.SERVISTURNO;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MASAID;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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

        public void adisyonKapat(int adisyonID, int durum)
        {


            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("UPDATE adisyonlar SET Durum = @durum WHERE ID = @adisyonId", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonID;
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
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

    }


}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class cMasalar
    {
        cGenel gnl = new cGenel();
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;

        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVISTURU { get => _SERVISTURU; set => _SERVISTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }

        public int MasaNumarası(string MasaValue)
        {
            string aa = MasaValue;
            int length = aa.Length;

            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }

        }

        public bool MasaNumarasıDurum(int ButtonName, int durum)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select durum From masalar Where ID=@tableId and DURUM=@durum", connection);

            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
            return result;
        }

        public void MasaDurumuDegis(string ButtonName, int state)
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo", connection);
            string masaNo = "";

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string aa = ButtonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;

             if (uzunluk > 8)
             {
                 masaNo = aa.Substring(uzunluk - 2, 2);
             }
             else
             {
                 masaNo = aa.Substring(uzunluk - 1, 1);
             }

            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = masaNo;

            cmd.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
        }

    }
}

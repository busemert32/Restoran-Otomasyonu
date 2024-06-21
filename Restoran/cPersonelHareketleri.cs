using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class cPersonelHareketleri
    {

        cGenel gnl = new cGenel();
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;

        public int ID { get => _ID; set => _ID = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }

        public bool PersonelHareketleriniKaydet(cPersonelHareketleri ph)
        {
            bool sonuc = false;


            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into personelHareketleri(PERSONELID, ISLEM, TARIH) values (@personelId,@islem,@tarih)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = ph.PersonelId;
                cmd.Parameters.Add("@islem", SqlDbType.VarChar).Value = ph.Islem;
                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = ph.Tarih;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
    }
}


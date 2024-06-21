using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Restoran
{
    internal class cOdeme
    {
        cGenel gnl = new cGenel();


        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _Kdvtutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;


        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal Kdvtutari { get => _Kdvtutari; set => _Kdvtutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }



        //musterinin masa hesabını kapatıyoruz
        public bool billClose(cOdeme fatura)
        {
            
            bool result = false;
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURID,ARATOPLAM,KDVTUTARI,INDIRIM,TOPLAMTUTAR) values (@ADISYONID,@ODEMETURID,@ARATOPLAM,@KDVTUTARI,@İNDİRİM,@TOPLAMTUTAR)", connection);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = fatura.AdisyonID;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = fatura.OdemeTurId;
                cmd.Parameters.Add("@ARATOPLAM", SqlDbType.Money).Value = fatura.AraToplam;
                cmd.Parameters.Add("@KDVTUTARI", SqlDbType.Money).Value = fatura.Kdvtutari;
                cmd.Parameters.Add("@İNDİRİM", SqlDbType.Money).Value = fatura.Indirim;
                cmd.Parameters.Add("@TOPLAMTUTAR", SqlDbType.Money).Value = fatura.GenelToplam;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return result;
        }


    }
}

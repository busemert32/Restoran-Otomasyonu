using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restoran
{
    internal class cPersonelGorev
    {
        cGenel gnl = new cGenel();

        private int _personelGorevId;
        public int personelGorevId;
        private string _tanim;
        public string tanim;

        public string Tanim { get => _tanim; set => _tanim = value; }
        public int PersonelGorevId { get => _personelGorevId; set => _personelGorevId = value; }

        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select * from personelGorevleri ", connection);

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
                    cPersonelGorev c = new cPersonelGorev();
                    c._personelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["GOREV"].ToString();
                    cb.Items.Add(c);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            dr.Close();
            connection.Close();
        }

        public string PersonelGorevTanim(int per)
        {
            string sonuc = "";

            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("Select GOREV from personelGorevleri where ID=@perId", connection);

            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = per;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            connection.Close();
            return sonuc;
        }

        public override string ToString()
        {
            return _tanim;
        }
    }
}

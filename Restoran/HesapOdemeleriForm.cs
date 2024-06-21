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
    public partial class HesapOdemeleriForm : Form
    {
        public HesapOdemeleriForm()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();
        private void HesapOdemeleriForm_Load(object sender, EventArgs e)
        {
            HesapOdemeleriniGetir();
        }

        private void HesapOdemeleriniGetir()
        {
            SqlConnection connection = new SqlConnection(gnl.connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM HesapOdemeleri WHERE MONTH(TARIH) = MONTH(GETDATE()) AND YEAR(TARIH) = YEAR(GETDATE())", connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Satırı oluştururken hücre sayısını doğru belirtelim
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);

                        row.Cells[0].Value = reader["ID"];
                        row.Cells[1].Value = reader["ADISYONID"];
                        row.Cells[2].Value = reader["ODEMETURID"];
                        row.Cells[3].Value = reader["ARATOPLAM"];
                        row.Cells[4].Value = reader["KDVTUTARI"];
                        row.Cells[5].Value = reader["INDIRIM"];
                        row.Cells[6].Value = reader["TOPLAMTUTAR"];
                        row.Cells[7].Value = reader["TARIH"];

                        // Satırı DataGridView'a ekleyelim
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Hesap ödemeleri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

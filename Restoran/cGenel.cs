using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran
{
    internal class cGenel
    {
        public string connection = ("Server=buse\\SQLEXPRESS;Database=restoran;Trusted_Connection=True");

        public static int _personelId;
        public static int _gorevId;

        public static string _ButtonValue;
        public static string _ButtonName;

        public static int _ServisTurNo;
        public static string _AdisyonId;

    }
}

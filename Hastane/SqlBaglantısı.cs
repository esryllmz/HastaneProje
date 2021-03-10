using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Hastane
{
    class SqlBaglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QJJE4O8\\SQLEXPRESS01;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}

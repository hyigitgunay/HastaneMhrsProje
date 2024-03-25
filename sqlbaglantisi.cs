using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project_Hospital
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = hyigitgunay; Initial Catalog = Hospital_Project; Integrated Security = True");
            baglan.Open();
            return baglan;
            
        }
    }
}

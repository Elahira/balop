using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLconnect
    {   
           protected SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AT03SVL\SQLEXPRESS;Initial Catalog=balop;Integrated Security=True");
             
    }
}

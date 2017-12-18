using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace GocmenOtomasyon
{
    class DaoClass
    {
       
      public static MySqlConnection GetMySqlConnection()
        {
            MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=gocmenotomasyon");
            return con;
        }

      public static MySqlDataAdapter GetMySqlDataAdapter()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
         return adapter;
        }
      
    }
   
}

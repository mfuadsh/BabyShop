using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using MySql.Data.MySqlClient;
namespace BabyShop
{
    class MySqlClass
    {
        string database = "server=localhost;database=babyshop;uid=root;password=;SslMode=none;";
        

        public DataTable GetData(string query, params MySqlParameter[] myParams) {
            DataTable dt = new DataTable();
            MySqlConnection koneksi = new MySqlConnection(database);
            koneksi.Open();

            MySqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddRange(myParams);
            dt.Load(cmd.ExecuteReader());
            koneksi.Close();
            return dt;
        }
        public void Execute(string query, params MySqlParameter[] myParams) {
            MySqlConnection koneksi = new MySqlConnection(database);
            koneksi.Open();

            MySqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddRange(myParams);
            cmd.ExecuteNonQuery();
            koneksi.Close();
        
        }
      
    }
}

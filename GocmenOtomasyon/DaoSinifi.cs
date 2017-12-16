using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
namespace GocmenOtomasyon
{
    class DaoSinifi
    {

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable table;

        private string server = "localhost";        // database hostname
        private string database = "gocmenotomasyon";   // database name
        private string user = "root";               // database username
        private string password = "";               // database password 

        private string sql = "";
        private string field = "";
        private string value = "";
        private int t = 0;

        private bool conn;

        public void Db_connect()
        {

            this.conn = true;
            this.connection = new MySqlConnection("server=" + this.server + ";database=" + this.database + ";user=" + this.user + ";password=" + this.password + ";charset=utf8");

            try
            {
                this.connection.Open();
            }

            catch (Exception e)
            {
                this.conn = false;

                MessageBox.Show("MysqlServer'ın çalıştığından emin olun. " + e.Message);
            }
        }
        public string Sql_select_extra(string sql)
        {

            this.sql = this.sql + " WHERE " + sql;

            return this.sql;

        }
        public string Sql_select(string tableName, string field)
        {

            this.sql = "SELECT " + field + " FROM " + tableName;

            return sql;

        }
        public void Insert_values(string field, string value)
        {

            if (t == 0)
            {

                this.field = field;
                this.value = "'" + value + "'";

            }
            else
            {

                this.field = field + "," + this.field;
                this.value = "'" + value + "'" + "," + this.value;
            }
            t++;

        }
        public MySqlDataReader Sql_query_select(string sql)
        {

            if (this.conn)
            {
                try
                {
                    command = new MySqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                }

                catch (Exception e)
                {
                    MessageBox.Show("Sorgunuzu kontrol Ediniz." + e.Message);
                }
            }

            return reader;

        }

        public int Sql_query(string sql)
        {

            command = new MySqlCommand(sql, connection);

            try
            {
                return command.ExecuteNonQuery();
            }

            catch (Exception e)
            {

                MessageBox.Show("Veritabanındaki alan ismini kontrol ediniz." + e.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }


        }
        public void Update_values(string field, string value)
        {

            if (this.field == "")
            {
                this.field = this.field + field + "='" + value + "'";
            }
            else
            {
                this.field = this.field + "," + field + "='" + value + "'";
            }

        }
        public string Sql_update(string tableName, string condition)
        {

            sql = "UPDATE " + tableName + " SET " + this.field + " WHERE " + condition;

            this.value = "";
            this.field = "";

            return sql;
        }
        public void Sql_adapter(string sql, DataGridView name)
        {

            adapter = new MySqlDataAdapter(sql, connection);
            table = new DataTable();

            try
            {
                adapter.Fill(table);
            }

            catch
            {

                MessageBox.Show("Mysql Sunucunuzun çalışıp çalışmadıgını kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            name.DataSource = table;
        }
        public void Close()
        {

            connection.Close();
        }


    }
}

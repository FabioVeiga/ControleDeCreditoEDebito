using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MyFinance.Util
{
    public class DAL //Data Acess Layer
    {
        /*Criar metodo de conexao*/
        private static string server = "localhost";
        private static string database = "financeiro";
        private static string user = "root";
        private static string password = "12345678";
        private string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";

        private MySqlConnection connection;

        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        //metodo para executar selects
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql,connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;
        }

        //Metodo para executar updates, deletes and inserts
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql,connection);
            command.ExecuteNonQuery();
        }

    }
}

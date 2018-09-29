using System;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace ControlYourFridge.Api.Database
{
    public class DbBaseFacade
    {
        public string ConnectionString { get; set; }

        // строки запросов
        public ISqlStrings SqlStrings { get; } = new SqlStrings();

        public DbBaseFacade()
        {
            ConnectionString = "Server=alexandr-solodchenko.ru;Port=3333;Database=controlyourhome;Uid=ServiceUser;Pwd=serviceuserpassword;SslMode=none;";
        }

        /// <summary>
        /// Получить connection к БД. Использовать через using
        /// </summary>
        /// <returns></returns>
        protected DbConnection GetDbConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            return conn;
        }       
    }
}

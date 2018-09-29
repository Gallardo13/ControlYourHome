using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ControlYourFridge.Tests.Database
{
    [TestClass]
    public class DatabaseCommonTests
    {
        [TestMethod]
        public void TestDatabaseConnection() 
        {
            try
            {
                var connetionString = "Server=alexandr-solodchenko.ru;Port=3333;Database=controlyourhome;Uid=ServiceUser;Pwd=serviceuserpassword;SslMode=none;";
                var connection = new MySqlConnection(connetionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }

    }
}

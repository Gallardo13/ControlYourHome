using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class UsersFacade : DbBaseFacade
    {
        public IEnumerable<User> GetAllUsers()
        {
            var retVal = new List<User>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllUsers;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var user = new User();
                    retVal.Add(user);
                }
            }

            return retVal;
        }
    }
}

using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class UserRecipesFacade : DbBaseFacade
    {
        public IEnumerable<UserRecipe> GetAllUserRecipes()
        {
            var retVal = new List<UserRecipe>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllUserRecipes;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var userRecipe = new UserRecipe();
                    retVal.Add(userRecipe);
                }
            }

            return retVal;
        }
    }
}

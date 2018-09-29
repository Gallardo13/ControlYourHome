using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class RecipesFacade : DbBaseFacade
    {
        public IEnumerable<Recipe> GetAllRecipes()
        {
            var retVal = new List<Recipe>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllRecipes;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var recipe = new Recipe();
                    retVal.Add(recipe);
                }
            }

            return retVal;
        }
    }
}

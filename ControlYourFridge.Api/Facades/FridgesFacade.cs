using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class FridgesFacade : DbBaseFacade
    {
        public IEnumerable<Fridge> GetAllFridges()
        {
            var retVal = new List<Fridge>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllFridges;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var fridge = new Fridge();
                    retVal.Add(fridge);
                }
            }

            return retVal;
        }
    }
}

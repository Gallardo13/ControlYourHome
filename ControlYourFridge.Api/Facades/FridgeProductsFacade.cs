using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class FridgeProductsFacade : DbBaseFacade
    {
        public IEnumerable<FridgeProduct> GetAllFridgeProducts()
        {
            var retVal = new List<FridgeProduct>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllFridgeProducts;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var FridgeProduct = new FridgeProduct();
                    retVal.Add(FridgeProduct);
                }
            }

            return retVal;
        }
    }
}

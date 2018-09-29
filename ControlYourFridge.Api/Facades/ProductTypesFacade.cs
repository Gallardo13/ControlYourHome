using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class ProductTypesFacade : DbBaseFacade
    {
        public IEnumerable<ProductType> GetAllProductTypes()
        {
            var retVal = new List<ProductType>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllProductTypes;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var productType = new ProductType();
                    retVal.Add(productType);
                }
            }

            return retVal;
        }
    }
}

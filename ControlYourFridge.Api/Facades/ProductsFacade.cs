using System;
using System.Collections.Generic;
using ControlYourFridge.Api.Database;
using ControlYourFridge.Api.Models;

namespace ControlYourFridge.Api.Facades
{
    public class ProductsFacade : DbBaseFacade
    {
        public IEnumerable<Product> GetAllProducts() 
        {
            var retVal = new List<Product>();

            using (var connection = GetDbConnection())
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = SqlStrings.GetAllProducts;

                var dataReader = cmd.ExecuteReader();

                int index = 0;

                while (dataReader.Read())
                {
                    index++;

                    // TODO real database object parsing 
                    var Product = new Product();
                    Product.Id = index.ToString();
                    Product.Name = String.Format("Продукт {0}", index);
                    Product.Type = String.Format("Тип {0}", index);
                    Product.StoredDaysCount = index.ToString();
                    retVal.Add(Product);
                }
            }

            return retVal;
        }
    }
}

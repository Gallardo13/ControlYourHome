using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlYourFridge.Api.Models;
using ControlYourFridge.Api.Facades;

namespace ControlYourFridge.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            try
            {
                var facade = new ProductsFacade();
                return facade.GetAllProducts();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

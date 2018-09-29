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
    public class FridgeProductsController : Controller
    {
        // GET: api/fridgeproducts
        [HttpGet]
        public IEnumerable<FridgeProduct> Get()
        {
            try
            {
                var facade = new FridgeProductsFacade();
                return facade.GetAllFridgeProducts();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

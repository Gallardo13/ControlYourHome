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
    public class ProductTypesController : Controller
    {
        // GET: api/producttypes
        [HttpGet]
        public IEnumerable<ProductType> Get()
        {
            try
            {
                var facade = new ProductTypesFacade();
                return facade.GetAllProductTypes();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

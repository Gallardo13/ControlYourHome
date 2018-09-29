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
    public class FridgesController : Controller
    {
        // GET: api/fridges
        [HttpGet]
        public IEnumerable<Fridge> Get()
        {
            try
            {
                var facade = new FridgesFacade();
                return facade.GetAllFridges();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

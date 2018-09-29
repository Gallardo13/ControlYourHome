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
    public class UserRecipesController : Controller
    {
        // GET: api/products
        [HttpGet]
        public IEnumerable<UserRecipe> Get()
        {
            try
            {
                var facade = new UserRecipesFacade();
                return facade.GetAllUserRecipes();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

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
    public class RecipesController : Controller
    {
        // GET: api/recipes
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            try
            {
                var facade = new RecipesFacade();
                return facade.GetAllRecipes();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

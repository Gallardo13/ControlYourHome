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
    public class UsersController : Controller
    {
        // GET: api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            try
            {
                var facade = new UsersFacade();
                return facade.GetAllUsers();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

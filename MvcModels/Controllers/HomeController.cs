using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<User> _userCollection = new List<User> 
        {
            new User {UserId = 1, FirstName = "Иван", LastName = "Иванов", Role = Role.Admin},
            new User {UserId = 2, FirstName = "Петр", LastName = "Петров", Role = Role.User},
            new User {UserId = 3, FirstName = "Сидор", LastName = "Сидоров", Role = Role.User},
            new User {UserId = 4, FirstName = "Вася", LastName = "Васильев", Role = Role.Guest}
        };

        public ActionResult Index(int id = 1)
        {
            User user = _userCollection.Single(u => u.UserId == id);
            return View(user);
        }        
    }
}
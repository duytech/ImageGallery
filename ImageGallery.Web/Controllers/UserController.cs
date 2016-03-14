using ImageGallery.Web.DataAccessLayer;
using ImageGallery.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageGallery.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(User user)
        {
            if (user == null)
                return null;

            if (String.IsNullOrEmpty(user.Name) || String.IsNullOrEmpty(user.Password))
                return null;

            UserDbContext userDbContext = new UserDbContext();

            User userDb = userDbContext.Users.Where(u => u.Name == user.Name).FirstOrDefault();

            if(userDb == null)
                return View("Error");
            else
                return View("Successful");
        }
    }
}
using ImageGallery.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageGallery.Web.Controllers
{
    public class LoginController : Controller
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

            return View("Successful");
        }
    }
}
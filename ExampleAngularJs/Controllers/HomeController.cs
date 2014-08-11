using ExampleAngularJs.Models.Registrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleAngularJs.Controllers
{
    public class HomeController : Controller
    {
        private RegistrationFactory registrationFactory = new RegistrationFactory();
        public ActionResult Index()
        {
            return View("Index", "", registrationFactory.BuildRegistration());
        }
	}
}
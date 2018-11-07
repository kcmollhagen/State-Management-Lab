using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logout()
        {
            ViewBag.name = Session["Name"];
            Session["Name"] = null;
            

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Result(Registration r)
        {
            ViewBag.Message = "Your contact page.";
            Session["Name"] = r.userName;
            Session["email"] = r.email;
            Session["password"] = r.password;
            Session["age"] = r.age;
            
            return View();
        }
    }
}
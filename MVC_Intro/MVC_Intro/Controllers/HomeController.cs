using MVC_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Matthew Pendleton\Documents\Tech Academy Files\ExerciseLogs\MVC_log.txt",text);

            //Random rand = new Random(10);
            //int num = rand.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //ViewBag.RandomNumber = num;

            //List<string> names = new List<string>
            //{
            //    "Matt",
            //    "Jesse",
            //    "Genna"
            //};

            User user = new User();
            user.Id = 1;
            user.FirstName = "matt";
            user.LastName = "pendleton";
            user.Age = 27;
            return View(user);
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
    }
}
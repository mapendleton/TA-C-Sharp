using CodeFirst.Models;
using CodeFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(string firstName, string lastName, string emailAddress)
        {
            using (Model1 db = new Model1())
            {
                Customer customer = new Customer()
                {
                    First_Name = firstName,
                    Last_Name = lastName,
                    EmailAddress = emailAddress
                };

                db.Customers.Add(customer);
                db.SaveChanges();

                return View("VisitDetail",customer);
            }
        }

        public ActionResult OldCustomer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCustomer(string firstName, string lastName, string emailAddress)
        {
            using (Model1 db = new Model1())
            {
                Customer customer = db.Customers.First(x => x.First_Name.ToLower() == firstName.ToLower() && x.Last_Name.ToLower() == lastName.ToLower() && x.EmailAddress.ToLower() == emailAddress);
                if (customer == null)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                else
                {
                    return View("VisitDetail", customer);
                }
            }
        }

        public ActionResult VisitDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VisitDetail(int id, int hours, Models.Type? massageType)
        {
            using (Model1 db = new Model1())
            {
                Visit visit = new Visit()
                {
                    MassageType = massageType,
                    Hours = hours,
                    CustomerId = id
                };
                Customer customer = db.Customers.First(x => x.Id == visit.CustomerId);
                if (customer != null)
                {
                    customer.Number_Of_Visits += 1;
                }

                db.Visits.Add(visit);
                db.SaveChanges();

                RecieptView reciept = new RecieptView()
                {
                    FirstName = customer.First_Name,
                    LastName = customer.Last_Name,
                    MassageType = massageType,
                    Hours = hours,
                    NumberVisits = customer.Number_Of_Visits
                };

                return View("Reciept", reciept);
            }
        }


    }
}
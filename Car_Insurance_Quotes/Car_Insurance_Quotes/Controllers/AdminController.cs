using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Insurance_Quotes.Models;
using Car_Insurance_Quotes.ViewModels;

namespace Car_Insurance_Quotes.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities1 db = new InsuranceEntities1())
            {
                List<tbl_car> cars = db.tbl_car.ToList();
                List<CustomerQuote> customerQuotes = new List<CustomerQuote>();
                foreach (var entry in cars)
                {
                    CustomerQuote customerQuote = new CustomerQuote();
                    customerQuote.Id = entry.tbl_customer.Customer_Id;
                    customerQuote.FirstName = entry.tbl_customer.First_Name;
                    customerQuote.LastName = entry.tbl_customer.Last_Name;
                    customerQuote.EmailAddress = entry.tbl_customer.Email_Address;
                    customerQuote.Quote = entry.Car_Quote;
                    customerQuotes.Add(customerQuote);
                }
                return View(customerQuotes);
            }
        }
    }
}
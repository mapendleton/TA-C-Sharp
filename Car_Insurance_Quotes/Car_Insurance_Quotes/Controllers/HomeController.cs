using Car_Insurance_Quotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Quotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || dateOfBirth == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities1 db = new InsuranceEntities1())
                {
                    var customer = new tbl_customer();
                    customer.First_Name = firstName;
                    customer.Last_Name = lastName;
                    customer.Email_Address = emailAddress;
                    customer.Date_Of_Birth = dateOfBirth;

                    db.tbl_customer.Add(customer);
                    db.SaveChanges();

                    return View("CarInfo", customer);
                }
            }
        }

        public ActionResult CarInfo(tbl_customer customer)
        {
            return View(customer);
        }

        [HttpPost]
        public ActionResult CarInfo(int id, int carYear, string carMake, string carModel, string carDUI, string carCoverage, int carSpeedingTickets = 0)
        {
            if (carYear <= 0 || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(carDUI) || carSpeedingTickets < 0 || string.IsNullOrEmpty(carCoverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities1 db = new InsuranceEntities1())
                {
                    
                    //get customer that matches the car info 
                    tbl_customer customer = db.tbl_customer.First(x => x.Customer_Id == id);
                    //base total

                    decimal total = 50m;
                    int age = DateTime.Now.Year - customer.Date_Of_Birth.Value.Year;

                    //add to monthly payment based on age
                    if (age < 18)
                    {
                        total += 100m;
                    }
                    else if (age < 25)
                    {
                        total += 25m;
                    }
                    else if (age > 100)
                    {
                        total += 25m;
                    }

                    //add to monthly payment based on car year
                    if (carYear < 2000 || carYear > 2015)
                    {
                        total += 25m;
                    }

                    //add based on car make and model note*not checking if user makes a spelling mistake etc
                    if (carMake.ToLower() == "porsche")
                    {
                        total += 25m;
                        if (carModel.ToLower() == "911 Carrera")
                        {
                            total += 25m;
                        }
                    }

                    //add based on speeding tickets
                    if (carSpeedingTickets > 0)
                    {
                        total += carSpeedingTickets * 10;
                    }

                    //add if user has had a DUI
                    if (carDUI.ToLower() == "yes")
                    {
                        total += total * .25m;
                    }

                    //add if coverage is full
                    if (carCoverage.ToLower() == "full")
                    {
                        total += total * .50m;
                    }

                    //update tbl_car table in dB
                    var carInfo = new tbl_car();
                    carInfo.Car_Customer = id;
                    carInfo.Car_Year = carYear;
                    carInfo.Car_Make = carMake;
                    carInfo.Car_Model = carModel;
                    carInfo.Car_DUI = carDUI;
                    carInfo.Car_Num_Speed_Tickets = carSpeedingTickets;
                    carInfo.Car_Coverage_Type = carCoverage;
                    carInfo.Car_Quote = total;

                    db.tbl_car.Add(carInfo);
                    db.SaveChanges();

                    return View("QuotePage", carInfo);
                }
            }

        }

        public ActionResult QuotePage(int id)
        {
            return View();
        }
        
    }
}
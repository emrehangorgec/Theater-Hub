using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheaterReservationPage.Models;

namespace TheaterReservationPage.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }



        public ActionResult Theater()
        {


            return View();
        }

        public ActionResult Reservation()
        {


            return View();
        }

        public ActionResult Event()
        {


            return View();
        }


        //Form kısmı 

        public ActionResult Contact()
        {


            return View();
        }

        public ActionResult Result(ContactModel contact_form)
        {
            if (ModelState.IsValid)
            {
                ViewBag.firstname = contact_form.FirstName;
                ViewBag.lastname = contact_form.LastName;
                ViewBag.email = contact_form.Email;
                ViewBag.gender = contact_form.Gender;

                return View("Result", contact_form);
            }


            else

                return View();


        }




    }
}
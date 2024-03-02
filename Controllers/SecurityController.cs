﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TheaterReservationPage.Models;
namespace Authentication.Controllers
{
    public class SecurityController : Controller
    {
        DBuser db = new DBuser();
        [HttpGet]
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userInDb = db.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password); //Is it available in the incoming user db?
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(userInDb.Username, false); //The user is now authenticated, so the pages can be browsed.
                return RedirectToAction("Reservation", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password";
                return View();
            }
        }
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
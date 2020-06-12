using StaffInformationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace StaffInformationManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        DBSIMSEntities context = new DBSIMSEntities();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            using (var context = new DBSIMSEntities())
            {

                bool isValid = false;
                var query = context.User.FirstOrDefault(u => u.UserName == model.UserName && u.Password == model.Password);
                if (model != null)
                {
                    isValid = true;
                }



              //  String.Compare(u.Password, model.Password, false) == 0
              //  bool isValid = context.User.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index","Staff");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username and password");
                    return View();

                }

            }

        }





        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (var context = new DBSIMSEntities())
            {
                context.User.Add(model);
                context.SaveChanges();

            }
            return RedirectToAction("login");
        }



        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            //return RedirectToAction("Index", "Home");
            return RedirectToAction("login");
        }

      





    }
}
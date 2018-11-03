using HireABook.Entity;
using HireABook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireABook.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        UserInfoRepo userInfoRepoOb = new UserInfoRepo();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(FormCollection RegistrationForm)
        {
            UserInfo userInfoOb = new UserInfo();

            userInfoOb.UserName = RegistrationForm["userName"];
            userInfoOb.FirstName = RegistrationForm["firstName"];
            userInfoOb.LastName = RegistrationForm["lastName"];
            userInfoOb.Email = RegistrationForm["email"];
            userInfoOb.Password = RegistrationForm["password"];
            userInfoOb.PhoneNo = Convert.ToInt32(RegistrationForm["phone"]);
            userInfoOb.City = RegistrationForm["city"];
            userInfoOb.Thana = RegistrationForm["thana"];
            userInfoOb.Area = RegistrationForm["area"];

            userInfoOb.UserRole = 1;
            userInfoOb.CreatedDate = DateTime.Now;
            userInfoOb.LastSeen = DateTime.Now;
            userInfoOb.IsActive = true;

            int ret = userInfoRepoOb.InsertUserInfo(userInfoOb);

            if (ret > 0)
                TempData["Message"] = "Registration Successful.";
            else
                TempData["Message"] = "Registration Failed.";

            return RedirectToAction("Register");

        }

        [HttpPost]
        public ActionResult Login(FormCollection LoginInfo)
        {
            UserInfo userInfoOb = userInfoRepoOb.GetByUserName(LoginInfo["userName"]);
            if(userInfoOb != null)
            {
                if(LoginInfo["password"] == userInfoOb.Password)
                {
                    return RedirectToAction("Index");
                }
            }

            TempData["Message"] = "Login Failed.";

            return RedirectToAction("Register");
        }

    }

}
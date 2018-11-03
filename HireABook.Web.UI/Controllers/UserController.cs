using HireABook.Entity;
using HireABook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireABook.Web.UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserInfoRepo userInfoRepoOb = new UserInfoRepo();
        public ActionResult Index()
        {
            return View(userInfoRepoOb.GetAll());
        }

        public ActionResult AddBooks()
        {
            return View();
        }

        public ActionResult ShowMyUploads()
        {
            return View();
        }

    }
}
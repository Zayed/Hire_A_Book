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
        GenreInfoRepo GenreInfoRepoOb = new GenreInfoRepo();
        BookInfoRepo BookInfoRepoOb = new BookInfoRepo();

        public ActionResult Index()
        {
            return View(userInfoRepoOb.GetAll());
        }

        [HttpGet]
        public ActionResult AddBooks()
        {
            List<SelectListItem> GenreList = new List<SelectListItem>();
            GenreList.AddRange(GenreInfoRepoOb.GetAll().Select(x => new SelectListItem() {
                Text = x.GenreName,
                Value = x.GenreId.ToString(),
                
            }));

            ViewBag.GenreList = GenreList;
            return View();
        }

        [HttpPost]
        public ActionResult AddBooks(BookInfo BookInfoForm)
        {
            if(ModelState.IsValid)
            {
                BookInfoForm.SearchCount = 0;
                BookInfoForm.AddedBy = "Zayed";
                BookInfoForm.IsApproved = false;
                BookInfoForm.IsAvailable = true;
                BookInfoForm.UploadDate = DateTime.Now;
                BookInfoForm.UserId = 1;

                BookInfoRepoOb.InsertBookInfo(BookInfoForm);
                return RedirectToAction("ShowMyUploads");
            }
            
            return RedirectToAction("AddBooks");
        }

        public ActionResult ShowMyUploads()
        {
            if (Session["userName"]==null)
            {
                return Redirect("/Home/Register");
            }

            UserInfo userInfoOb = userInfoRepoOb.GetByUserName(Session["userName"].ToString());

            List<BookInfo> bookInfoList = BookInfoRepoOb.GetAllById(userInfoOb.UserId);

            foreach (var item in bookInfoList)
            {
                item.GenreName = GenreInfoRepoOb.GetById(item.GenreId).GenreName;
            }
            return View(bookInfoList);
        }

        public ActionResult ShowMyProfile()
        {
            return View();
        }

    }
}
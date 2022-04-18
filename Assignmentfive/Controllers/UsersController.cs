using Assignmentfive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignmentfive.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        private Assignment5Entities db = new Assignment5Entities();
        public JsonResult IsUserNameAvailable(string username)
        {

            return Json(!db.Users.Any(u => u.UserName == username), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
using BigSchool27.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BigSchool27.Controllers
{
    public class CoursesController : Controller
    {

        // GET: Courses
        public ActionResult Create()

        {
            BigSchoolContext2 context = new BigSchoolContext2();
            Course objCourse = new Course();
            objCourse.ListCategory = context.Category.ToList();
            return View(objCourse);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Course objCourse)
        {
            BigSchoolContext2 context = new BigSchoolContext2();
            ModelState.Remove("LecturerId");
            if (!ModelState.IsValid)
            {
                objCourse.ListCategory = context.Category.ToList();
                return View("Create", objCourse);
            }
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            objCourse.LecturerId = user.Id;
            context.Course.Add(objCourse);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
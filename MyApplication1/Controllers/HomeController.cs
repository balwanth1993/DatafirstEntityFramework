using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApplication1.Models;

namespace MyApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index(int Id)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            List<Student> students= studentDBContext.Students.Where(stu => stu.DepartmentId == Id).ToList();
            return View(students);

        }
        public ActionResult Details(int Id)
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            Student students = studentDBContext.Students.Single(x =>x.ID == Id);
            return View(students);

        }
        public ActionResult About()
        {
            return RedirectToAction("Index", "Department",null);
        }


    }
}
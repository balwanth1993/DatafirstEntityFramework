using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApplication1.Models;

namespace MyApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        
        public ActionResult Index()
        {
            StudentDBContext studentDBContext = new StudentDBContext();
            List<Department> departments = studentDBContext.Departments.ToList();
            return View(departments);
        }
    }
}
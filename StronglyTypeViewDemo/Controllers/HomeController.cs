using StronglyTypeViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypeViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.id = 12;
            emp1.Name = "Amit";
            emp1.Age = 23;

            ViewData["Var1"] = emp1;
            ViewBag.Var2 = emp1;
            return View();
        }
    }
}
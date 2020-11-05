using DemoMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Details()
        {
            
            StudentModel student = new StudentModel();
            student.Country = "Bangladesh";
            student.Name = "Jafor";
            student.University = "BUET";
            student.Dept = "CSE";
            student.Roll = 133083;
            student.Age = 45;
            student.District = "Dhaka";

            return View(student);
        }
        public ActionResult CSEStudentsList()
        {
            return View();
        }
    }
}
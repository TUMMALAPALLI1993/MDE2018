using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDE2018.Models;

namespace MDE2018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            Student student = new Student();
            student.Firstname = "Tummalapalli";
            student.Lastname = "Kiran Kumar";
            student.DOB = new DateTime(1993, 11, 23);

            //student.PictureURL = @"~\Home\Kiran(1).jpg";
            //student.PictureURL = "Views/Home/Kiran(1).jpg";
            student.PictureURL = "/images/Kiran(1).jpg";


            return View(student);
        }

        public IActionResult AllStudents()
        {
            List<string> name = new List<string>();

            name.Add("Kiran");
            name.Add("Xander");
            name.Add("Vishnu");
            name.Add("Roy");
            name.Add("Paulina");
            name.Add("Kristen");


            return View(name);
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

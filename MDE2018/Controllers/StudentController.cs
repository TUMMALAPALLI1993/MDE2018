using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MDE2018.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MDE2018.Controllers
{
    public class StudentController : Controller
    {

        public StudentController(MyDbContext _context)
        {
            ctx = _context;
        }

        MyDbContext ctx = null;

        // GET: /<controller>/
        public IActionResult Index()
        {

            //Student stu = new Student();

            //stu.Firstname = "kiran";

            ctx.Database.EnsureCreated();

            var query = from s in ctx.students select s;

            List<Student> result = query.ToList();

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                ctx.students.Add(newStudent);
                ctx.SaveChanges();

                return RedirectToAction("Index");

            }

            else
            {
                return View();

            }

            
        }
    }
}

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

            ctx.Database.EnsureCreated();

            var query = from s in ctx.students select s;

            List<Student> result = query.ToList();

            return View(result);
        }
    }
}

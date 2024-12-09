using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private dbStudent _db;
        public StudentController(dbStudent db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ss = _db.GetStudents();
            return View(ss);
        }
    }
}
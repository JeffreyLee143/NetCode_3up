using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private string _strcon;
        public StudentController(IConfiguration configuration)
        {
            _strcon = configuration.GetConnectionString("imConnectionString");
        }
        public IActionResult Index()
        {
            dbStudent db = new dbStudent(_strcon);
            var stdata = db.GetStudents();
            return View(stdata);
        }
    }
}
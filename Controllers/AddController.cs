using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult aaa(int num1,int num2){
            int sum = num1 + num2;
            ViewBag.Result = sum;
            ViewBag.fn1 = num1;
            ViewBag.fn2 = num2;
            return View("Index");
        }
    }
}
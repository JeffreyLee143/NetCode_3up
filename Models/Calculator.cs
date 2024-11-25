using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Add()
        {
            return num1 + num2;
        }
    }
}

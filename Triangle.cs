using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Triangle :Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override string ShapeType()
        {
            return "Triangle";
            throw new NotImplementedException();
            
        }
        public override double Area()
        {
            return Base * Height / 2;
            throw new NotImplementedException();
        }
    }
}
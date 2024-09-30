using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Circle
    {
        
        public double Radius{get;set;}
        public Circle(double r)
        {
            Radius = r;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
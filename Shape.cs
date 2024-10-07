using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public abstract class Shape
    {
        public string Developer()
        {
            return "King of C#";
        }
        public abstract string ShapeType();
        public abstract double Area();
    }
}
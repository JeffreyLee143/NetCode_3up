using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Test<T>
    {
        public T a { get; set; }
        public Test(T a)
        {
            this.a = a;
        }
        public Test()
        {

        }
        public string show()
        {
            return a.GetType().ToString();
        }
    }
}
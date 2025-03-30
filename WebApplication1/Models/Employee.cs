using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public List<string> Skills { get; set; }
        
        public string get_Info()
        {
            string r = "";
            if (this.Gender == true)
            {
                r = r + "Mr.";
            }
            else
            {
                r = r + "Miss";
            }
            r = r + this.Name + "<br> Skills <br>";
            foreach(string s in Skills)
            {
                r = r + s + "<br>";
            }
            return r;
        }
    }
}
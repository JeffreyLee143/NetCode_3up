using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Item
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string FullName()
        {
            return ID+"_"+Name;
        }
    }
}
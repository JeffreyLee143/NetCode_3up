using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Item
    {
        public Item() { }
        public string Name { get; set; }
        public string ID { get; set; }
        public string getFullName()
        {
            return ID + "_" + Name;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ID = TextBox3.Text;
            p.Name = TextBox4.Text;
            p.Price = Double.Parse(TextBox1.Text);
            Label1.Text = p.TotalSales(Int32.Parse(TextBox2.Text)).ToString();
        }
    }
}
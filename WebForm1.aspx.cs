﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            Label1.Text = number.ToString();
            List<String> s = new List<string>();
            if (number > 5)
            {
                Label2.Text="克拉拉";
            }
            else
            {
                Label2.Text = "瓦爾特";
            }
        }
    }
}
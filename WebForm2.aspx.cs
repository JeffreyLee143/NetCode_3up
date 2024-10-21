﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["content"].ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["content"] = TextBox1.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ViewState["content"] == null)
            {
                TextBox1.Text = "";
            }
            else
            {
                TextBox1.Text = ViewState["content"].ToString();
            }
        }

        
    }
}
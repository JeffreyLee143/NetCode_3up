using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double r = Double.Parse(TextBox1.Text);
            Circle a = new Circle(r);
            Label1.Text = a.Area().ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double r = Double.Parse(TextBox1.Text);
            Circle a = new Circle(r);
            Label1.Text = a.Circumference().ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double r = Double.Parse(TextBox1.Text);
            Circle a = new Circle(r);
            a.Radius = 5;
            Label1.Text = a.Radius.ToString();
        }
    }
}
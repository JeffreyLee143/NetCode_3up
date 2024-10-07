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
            Triangle t = new Triangle();
            t.Base = Double.Parse(TextBox1.Text);
            t.Height = Double.Parse(TextBox2.Text);
            Label1.Text = t.Area().ToString();
            Label2.Text = t.Developer();
        }
    }
}
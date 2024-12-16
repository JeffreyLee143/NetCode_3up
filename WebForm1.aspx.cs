using System;
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
            string n = TextBox1.Text;
            string a = TextBox2.Text;
            // Response.Redirect("WebForm2.aspx?n1=" + Server.UrlEncode(n) + "&n2=" + Server.UrlEncode(a));
            Server.Transfer("WebForm2.aspx?n1=" + Server.UrlEncode(n) + "&n2=" + Server.UrlEncode(a));
        }
    }
}
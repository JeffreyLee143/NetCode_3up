using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cc = new HttpCookie("Hello");
            cc["name"] = TextBox1.Text;
            cc.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cc);
            Response.Redirect("Webform4.aspx");
        }
    }
}
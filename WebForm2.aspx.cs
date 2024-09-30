using System;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox2.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = TextBox1.Text;
            r = r.Replace("\r\n", "<br>");
            r = "<hr>" + DateTime.Now + "<br>" + TextBox2.Text + "<br>"+r;
            Label1.Text = r + Label1.Text;
        }
    }
}
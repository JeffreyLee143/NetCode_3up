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
            try
            {
                double n1, n2, r;
                n1 = Double.Parse(num1.Text);
                n2 = Double.Parse(num2.Text);
                r = n1*n2/2;
                n4.Text = r.ToString();
            }
            catch (Exception err)
            {
                num1.Text = "";
                num2.Text = "";
                n4.Text = err.ToString();
            }
        }
    }
}
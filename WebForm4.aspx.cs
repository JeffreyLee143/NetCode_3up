using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string itemID;
            double[] b = new double[5];
            for(int i = 1; i <= 5; i++)
            {
                TextBox a;
                itemID = "TextBox" + i;
                a = (TextBox)Page.FindControl(itemID);
                b[i - 1] = Double.Parse(itemID);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPP_BMI.Models;

namespace WebAPP_BMI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            BMI bMI = new BMI(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text));
            Label1.Text=bMI.Caculate_BMI();

        }
    }
}
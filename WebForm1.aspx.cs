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
            string r = "";
            List<Double> a = new List<double>();
            a.Add(10.3);
            a.Add(2.3);
            a.Add(13.3);
            a.Add(10);
            Label1.Text = a.Count.ToString();
            a.Sort();
            foreach(double b in a){
                r = r + b + "<br>";
            }
            Label2.Text = r;
        }
    }
}
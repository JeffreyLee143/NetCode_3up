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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = "";
            string a = TextBox1.Text;
            string[] b = a.Split(',');
            double[] c = new double[b.Length];
            for(int i = 1; i <= b.Length; i++)
            {
                c[i - 1] = Double.Parse(b[i - 1]);
            }
            Array.Sort(c);
            foreach(double t in c)
            {
                r = r + t.ToString() + "<br>";
            }
            Label1.Text = r;
        }
    }
}
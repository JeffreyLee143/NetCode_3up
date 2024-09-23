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
            int[,] table = new int[int.Parse(TextBox1.Text), int.Parse(TextBox1.Text)];
            for (int i = 1; i <int.Parse(TextBox1.Text)+1 ; i++){
                for (int j = 0; j < int.Parse(TextBox1.Text)+1; j++)
                {
                    r +=i.ToString()+"*"+j.ToString()+"="+ (i) * (j) + "\t";
                }
                r += "<br/>";
            }
            Label1.Text = r;
        }
        
    }
}
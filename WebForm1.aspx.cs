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
            int sum = 0;
            string temp;
            int qty;
            foreach (GridViewRow i in GridView1.Rows)
            {
                temp = ((TextBox)i.Cells[4].FindControl("Textbox2")).Text;
                if (temp == "")
                {
                    qty = 0;
                }
                else
                {
                    qty = Int32.Parse(temp);
                }
                sum = sum + qty * Int32.Parse(i.Cells[3].Text);
            }
            Label1.Text = sum.ToString();
        }
    }
}
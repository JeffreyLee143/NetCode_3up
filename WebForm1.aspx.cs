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
            if (!this.IsPostBack)
            {
                ListItem a = new ListItem();
                ListItem b = new ListItem();
                a.Text = "PC1";
                a.Value = "10000";
                b.Text = "PC2";
                b.Value = "20000";
                DropDownList1.Items.Add(a);
                DropDownList1.Items.Add(b);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count;
            if (ViewState["counter"] == null)
            {
                count = 1;
            }
            else
            {
                count = (int)ViewState["counter"] + 1;

            }
            ViewState["counter"] = count;
            Label1.Text = count.ToString();
        }
    }
}
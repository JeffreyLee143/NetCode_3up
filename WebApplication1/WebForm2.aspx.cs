using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> ss = new List<string>();
            Employee emp = new Employee();
            emp.Name = TextBox1.Text;
            if (RadioButtonList1.SelectedItem.Value == "M")
            {
                emp.Gender = true;
            }
            else
            {
                emp.Gender = false;
            }
            foreach(ListItem t in CheckBoxList1.Items)
            {
                if (t.Selected)
                {
                    ss.Add(t.Text);
                }
            }
            emp.Skills = ss;
            Label1.Text = emp.get_Info();
        }
    }
}
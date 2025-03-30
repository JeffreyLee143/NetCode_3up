using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> ss = new List<string>();
            Employee emp = new Employee();
            emp.Name = TextBox1.Text;
            if (RadioButton1.Checked)
            {
                emp.Gender = true;
            }
            else
            {
                emp.Gender = false;
            }
            if (CheckBox1.Checked)
            {
                ss.Add(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                ss.Add(CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                ss.Add(CheckBox3.Text);
            }
            emp.Skills = ss;
            Label1.Text = emp.get_Info().ToString();
        }
    }
}
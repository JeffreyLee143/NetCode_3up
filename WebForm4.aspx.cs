using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = WebConfigurationManager.ConnectionStrings["imConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "insert into product(Pid,Pname,Ptype,Price) values (@id,@panme,@ptype,@price)";
            sqlcmd.Parameters.AddWithValue("@pid",TextBox1.Text);
            sqlcmd.Parameters.AddWithValue("@ptype", TextBox2.Text);
            sqlcmd.Parameters.AddWithValue("@pname",TextBox3.Text);
            sqlcmd.Parameters.AddWithValue("@price",TextBox4.Text);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            Response.Redirect("WebForm2.aspx");
        }
    }
}
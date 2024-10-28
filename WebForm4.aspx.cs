using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            string constr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=im;Integrated Security=True;Pooling=False";
            SqlConnection sqlcon = new SqlConnection(constr);
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select [Account], [Password] from [UserAccount] where [Account]='"+TextBox1.Text+"' and [Password]='"+TextBox2.Text+"'";
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                Response.Redirect("WebForm5.aspx");
            }
            }catch(SqlException err)
            {

            }
        }

    }
}
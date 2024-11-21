using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                SqlConnection sqlcon = new SqlConnection();
                string query = "select Id,name from student";
                string strcon = WebConfigurationManager.ConnectionStrings["imConnectionString"].ConnectionString;
                {
                    sqlcon.Open();
                    /*
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select Id,name from student";
                    */
                    // SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    SqlDataAdapter adapter = new SqlDataAdapter(query,sqlcon);
                    adapter.Fill(ds, "students");
                    DataTable dt = ds.Tables["students"];
                    //GridView1.DataSource = dt;
                    //GridView1.DataBind();
                    foreach(DataRow rr in dt.Rows)
                    {
                        Response.Write(rr["name"].ToString()+"<bt>");
                    }
                    DataRow newrow = dt.NewRow();
                    newrow["Id"] = 5;
                    newrow["name"] = "AAA";
                    dt.Rows.Add(newrow);
                    adapter.Update(dt);
                }
            }
        }
    }
}
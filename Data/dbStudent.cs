using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WebApplication1.Models;
using Microsoft.Extensions.Configuration;
namespace WebApplication1.Data
{
    public class dbStudent
    {
        private string strcon;
        public dbStudent(IConfiguration configuration)
        {
            strcon = configuration.GetConnectionString("imCS");
        }
        public List<student> getStudent()
        {
            List<student> result = new List<student>();
            using(SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using(SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select id,name from student";
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(new student() {id=reader.GetInt32(0) ,Name=reader.GetString(1)});
                    }
                }
            }
            return result;
        }
    }
}

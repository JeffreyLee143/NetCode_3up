using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class dbStudent
    {
        private string _strcon;
        public dbStudent(IConfiguration configuration)
        {
            _strcon = configuration.GetConnectionString("imConnectionString");
        }
        public List<student> GetStudents()
        {
            List<student> result = new List<student>();
            using (SqlConnection sqlcon = new SqlConnection(_strcon))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd=new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select id,name from student";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while(sqldr.Read()){
                        result.Add(new student() { Id = sqldr.GetInt32(0), Name = sqldr.GetString(1)});
                    }
                    
                };
            }
            return result;
;        }
    }
}

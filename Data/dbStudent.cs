using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WebApplication1.Models;
namespace WebApplication1.Data
{
    public class dbStudent
    {
        private string _strcon;
        public dbStudent(string strcon)
        {
            _strcon = strcon;
        }
        public List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>();
            using(SqlConnection sqlcon = new SqlConnection(_strcon))
            {
                sqlcon.Open();
                using(SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select id,name from student";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        Students.Add(new Student() { Id = sqldr.GetInt32(0), Name = sqldr.GetString(1) });
                    }
                }
            }
            return Students;
        }
    }
}

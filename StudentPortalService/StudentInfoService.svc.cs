using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.IO;


namespace StudentPortalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentInfoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentInfoService.svc or StudentInfoService.svc.cs at the Solution Explorer and start debugging.
    public class StudentInfoService : IStudentInfoService
    {
        [WebMethod]
        public Student getStudentInfo(string id)
        {
            Student objStudent = new Student();

            SqlConnection con = new SqlConnection(@"Data Source=MT-VAIO\SQLEXPRESS;Initial Catalog=projDB;Integrated Security=True");
            string sql = "select * from student_info where id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                objStudent.StudentId = dr["id"].ToString();
                objStudent.FirstName = dr["FirstName"].ToString();
                objStudent.LastName = dr["LastName"].ToString();
                objStudent.Contact = dr["contact"].ToString();
                objStudent.Address = dr["stud_add"].ToString();
                objStudent.Email = dr["email"].ToString();
                objStudent.Gender = dr["gender"].ToString();

                if (dr["img"] != null)
                {
                    objStudent.Image = (byte[])(dr["img"]);
                }
            }

            return objStudent;
        }
    }
}

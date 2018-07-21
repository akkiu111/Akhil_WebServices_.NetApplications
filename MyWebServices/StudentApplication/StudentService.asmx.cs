using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
namespace StudentApplication
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public Student GetStudentByCode(string code)
        {
            string cs = ConfigurationManager.ConnectionStrings["studentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetStudentByCode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@code", code);
                cmd.Parameters.Add(parameter);
                Student student = new Student();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.code = reader["code"].ToString();
                    student.name = reader["name"].ToString();
                    student.gender = reader["gender"].ToString();
                    student.dateOfBirth = reader["dateOfBirth"].ToString();

                }
                return student;



            }
        }
    }
}

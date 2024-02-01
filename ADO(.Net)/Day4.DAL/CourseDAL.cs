using Microsoft.Data.SqlClient;
using System.Data;

namespace Day4.DAL
{

    public class CourseDAL
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Nada_Assem;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();

        public CourseDAL()
        {
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
        }
        public DataTable GetAllCourse()
        {
            cmd.CommandText = "Select * From Course";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public int InsertIntoCourse(int Crs_Id , string Crs_Name ,int Crs_Duration , int Topic_Id )
        {
            cmd.CommandText = "insert into Course (Crs_Id , Crs_Name , Crs_Duration , Top_Id)" +
                $"Values ( {Crs_Id}, '{Crs_Name}' ,{Crs_Duration} ,{Topic_Id} )";
            int Rows = cmd.ExecuteNonQuery();
            return Rows;
        }
        public int UpdateCourse(int Crs_Id, string Crs_Name, int Crs_Duration, int Topic_Id)
        {
            cmd.CommandText = "update Course set " +
                $"Crs_Name = '{Crs_Name}' , Crs_Duration = {Crs_Duration} , Top_Id = {Topic_Id} where Crs_Id = {Crs_Id} ";
            int Rows = cmd.ExecuteNonQuery();
            return Rows;
        }
        public void DeleteCourse(int Crs_Id)
        {
            cmd.CommandText = $"Delete From Course Where Crs_Id = {Crs_Id}";
            int Rows = cmd.ExecuteNonQuery();
        }

        public DataTable GetCourseByID(int Crs_Id)
        {
            cmd.CommandText = $"Select * From Course Where Crs_Id = {Crs_Id}";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}

using Day4.BLL.DTOs;
using Day4.DAL;
using System.Data;

namespace Day4.BLL
{
    
    public class CourseBLL
    {
        CourseDAL courseDAL = new CourseDAL();
        public List<Course> GetAllCourse()
        {
            List<Course> list = new List<Course>(); 
            DataTable dataTable = courseDAL.GetAllCourse();
            foreach (DataRow dr in dataTable.Rows)
            {
                Course course = new Course();
                course.ID = (int)dr["Crs_Id"];
                course.Name = dr["Crs_Name"].ToString() ?? "";
                course.Duration = (int)dr["Crs_Duration"];
                course.TopicId = (int)dr["Top_Id"];
                list.Add(course);
            }
            return list;
        }
        public void InsertCourse(int Crs_Id, string Crs_Name, int Crs_Duration, int Topic_Id)
        {
            courseDAL.InsertIntoCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id);
            
        }

        public bool UpdateCourse(int Crs_Id, string Crs_Name, int Crs_Duration, int Topic_Id)
        {   
            courseDAL.UpdateCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id);
            if (courseDAL.UpdateCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id) > 0)
                     return true;
            return false;
        }
        public void DeleteCourse(int Crs_Id)
        {
            courseDAL.DeleteCourse(Crs_Id);
        }
        public Course GetCourse(int Crs_Id)
        {
            DataTable dataTable = courseDAL.GetCourseByID(Crs_Id);
            Course course = new Course();
            DataRow dr = dataTable.Rows[0];
            course.ID = (int)dr["Crs_Id"];
            course.Name = dr["Crs_Name"].ToString() ?? "";
            course.Duration = (int)dr["Crs_Duration"];
            course.TopicId = (int)dr["Top_Id"];
            return course;
        }
    }
}

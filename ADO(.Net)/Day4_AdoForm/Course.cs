using Day4.BLL;
using Day4.BLL.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Day4_AdoForm
{
    public partial class Course : Form
    {
        CourseBLL courseBLL = new CourseBLL();
        TopicBLL topicBLL = new TopicBLL();
        bool isClick = false;
        public Course()
        {
            InitializeComponent();
            LoadGrid();
            //LoadTopic();
        }

        public void LoadGrid()
        {

            dataGridView1.DataSource = courseBLL.GetAllCourse();
        }
        //public void LoadTopic()
        //{
        //    List<Topic> topicList = topicBLL.GetAllTopic();
        //    comboBox1.DataSource = topicList;
        //    for (int i = 0; i < topicList.Count; i++)
        //    {
        //        comboBox1.DisplayMember = topicList[i].Top_Name;
        //        comboBox1.ValueMember = topicList[i].Top_Id.ToString();
        //    }

        //}


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            int Topic_Id = (int)NTop_ID.Value;
            string Crs_Name = string.IsNullOrEmpty(txtName.Text) ? " " : txtName.Text; ;
            int Crs_Id = (int)NCrsId.Value;
            int Crs_Duration = (int)NCrsDuration.Value;
            courseBLL.InsertCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id);
            LoadGrid();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Topic_Id = (int)NTop_ID.Value;
            string Crs_Name = string.IsNullOrEmpty(txtName.Text) ? " " : txtName.Text; ;
            int Crs_Id = (int)NCrsId.Value;
            int Crs_Duration = (int)NCrsDuration.Value;
            bool res = courseBLL.UpdateCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id);
            if (res)
            {
                courseBLL.UpdateCourse(Crs_Id, Crs_Name, Crs_Duration, Topic_Id);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("This Course Not Found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Crs_Id = (int)NCrsId.Value;
            courseBLL.DeleteCourse(Crs_Id);
            LoadGrid();
        }

        private void btnGetOne_Click(object sender, EventArgs e)
        {
            int Crs_Id = (int)NCrsId.Value;
            Day4.BLL.DTOs.Course crs = courseBLL.GetCourse(Crs_Id);
            //dataGridView1.DataSource = crs;
            NTop_ID.Value = crs.TopicId;
            txtName.Text = crs.Name;
            NCrsDuration.Value = crs.Duration;

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = courseBLL.GetAllCourse();

        }
    }
}

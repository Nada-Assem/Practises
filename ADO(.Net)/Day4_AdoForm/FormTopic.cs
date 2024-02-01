using Day4.BLL;
using Day4.BLL.DTOs;
using Day4.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4_AdoForm
{

    public partial class FormTopic : Form
    {
        TopicBLL topicBLL = new TopicBLL();
        public FormTopic()
        {
            InitializeComponent();
            //LoadGrid();
        }
        public void LoadGrid()
        {

            dataGridView1.DataSource = topicBLL.GetAllTopic();
        }
        private void btnGetone_Click(object sender, EventArgs e)
        {
            int Top_Id = (int)numericUpDown1.Value;
            Topic topic = topicBLL.GetTopicById(Top_Id);
            numericUpDown1.Value = topic.Top_Id;
            textBox1.Text = topic.Top_Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            string Name = textBox1.Text;
            topicBLL.AddTopic(id, Name);
            LoadGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            topicBLL.DeleteTopic(id);
            LoadGrid();

        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            string Name = textBox1.Text;
            topicBLL.UpdateTopic(id, Name);
            LoadGrid();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = topicBLL.GetAllTopic();
        }
    }
}

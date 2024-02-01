using Day4.BLL.DTOs;
using Day4.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.BLL
{
    public class TopicBLL
    {
        TopicDAL topicDAL = new TopicDAL();

        public List<Topic> GetAllTopic()
        {
            List<Topic> list = new List<Topic>();
            DataTable dataTable = topicDAL.GetAllTopic();
            foreach (DataRow row in dataTable.Rows)
            {
                Topic topic = new Topic();
                topic.Top_Id = (int)row["Top_Id"];
                topic.Top_Name = (string)row["Top_Name"];
                list.Add(topic);
            }
            return list;
        }
        public void UpdateTopic(int Top_Id , string Top_Name)
        {
            topicDAL.UpdateTopicByID(Top_Id , Top_Name);
        }
        public void DeleteTopic(int Top_Id)
        {
            topicDAL.DeleteTopic(Top_Id);
        }
        public void AddTopic(int Top_Id, string Top_Name)
        {
            topicDAL.AddTopic(Top_Id , Top_Name);
        }

        public Topic GetTopicById(int Top_Id)
        {
            DataTable dataTable = topicDAL.GetTopicByID(Top_Id);
            DataRow Row = dataTable.Rows[0];
            Topic topic = new Topic();
            topic.Top_Id = (int)Row["Top_Id"];
            topic.Top_Name = (string)Row["Top_Name"];
            return topic;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.DAL
{
    public class TopicDAL
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Nada_Assem;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();

        public TopicDAL()
        {
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
        }

        public DataTable GetAllTopic()
        {
            cmd.CommandText = "Select * From Topic";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetTopicByID(int Top_Id)
        {
            cmd.CommandText = $"Select * From Topic Where Top_Id ={Top_Id}";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public int AddTopic(int Top_Id , string Top_Name )
        {
            cmd.CommandText = "insert into Topic( Top_Id ,Top_Name )" +
                $"values ({Top_Id} , '{Top_Name}') ";
            int Rows = cmd.ExecuteNonQuery();
            return Rows;

        }

        public int DeleteTopic(int Top_Id)
        {
            cmd.CommandText = $"Delete from Topic where Top_Id ={Top_Id}";
            int Rows = cmd.ExecuteNonQuery() ;
            return Rows;
        }

        public int UpdateTopicByID(int Top_Id, string Top_Name) 
        {
            cmd.CommandText = "Update Topic " +
                $"SET Top_Name = '{Top_Name}'" +
                $"Where Top_Id = {Top_Id} ";
            int Rows = cmd.ExecuteNonQuery();
            return Rows;
        }

    }
}

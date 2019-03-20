using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class TaskService : ITaskService
    {
        SqlConnection con;
        SqlCommand cmd;
        public TaskService()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user1\Desktop\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public bool AddTask(User user, Task task)
        {
            if(!user.ValidateUser())
            {
                return false;
            }

            cmd.CommandText = "INSERT INTO Task VALUES(@title, @description, @isCompleted)";
            cmd.Parameters.AddWithValue("@title", task.title);
            cmd.Parameters.AddWithValue("@description", task.description);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted ? 1 : 0);

            con.Open();

            int addedRows = cmd.ExecuteNonQuery();

            con.Close();

            return addedRows == 1 ? true : false;
        }

        public bool DeleteTask(User user, string taskTitle)
        {
            if (!user.ValidateUser())
            {
                return false;
            }

            cmd.CommandText = "DELETE FROM Task WHERE title=@title";
            cmd.Parameters.AddWithValue("@title", taskTitle);
            
            con.Open();

            int addedRows = cmd.ExecuteNonQuery();

            con.Close();

            return addedRows == 1 ? true : false;
        }

        public IEnumerable<Task> GetAllTasks(User user)
        {
            throw new NotImplementedException();
        }

        public bool MarkTaskCompleted(User user, string taskTitle)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTask(User user, string taskTitle, Task task)
        {
            throw new NotImplementedException();
        }
    }
}

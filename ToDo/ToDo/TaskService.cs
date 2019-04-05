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
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\Desktop\ToDo\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public bool AddTask(User user, Task task)
        {
            if (!user.ValidateUser())
            {
                return false;
            }
            //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\Desktop\ToDo\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            //cmd = new SqlCommand();
            //cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Task VALUES(@title, @description, @isCompleted, @username)";
            cmd.Parameters.AddWithValue("@title", task.title);
            cmd.Parameters.AddWithValue("@description", task.description);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted ? 1 : 0);
            cmd.Parameters.AddWithValue("@username", user.userName);

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

            cmd.CommandText = "DELETE FROM [Task] WHERE title=@title and username=@username";
            cmd.Parameters.AddWithValue("@title", taskTitle);
            cmd.Parameters.AddWithValue("@username", user.userName);
            
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
            if (!user.ValidateUser())
            {
                return false;
            }

            cmd.CommandText = "UPDATE Task SET isCompleted=@isCompleted WHERE title=@title and username=@username";
            cmd.Parameters.AddWithValue("@title", taskTitle);
            cmd.Parameters.AddWithValue("@isCompleted", 1);
            cmd.Parameters.AddWithValue("@username", user.userName);

            con.Open();

            int addedRows = cmd.ExecuteNonQuery();

            con.Close();

            return addedRows == 1 ? true : false;

        }

        public bool UpdateTask(User user, string taskTitle, Task task)
        {
            if (!user.ValidateUser())
            {
                return false;
            }

            cmd.CommandText = "UPDATE Task SET title=@newTitle, description=@description, isCompleted=@isCompleted WHERE title=@title and username=@username";
            cmd.Parameters.AddWithValue("@title", taskTitle);
            cmd.Parameters.AddWithValue("@newTitle", task.title);
            cmd.Parameters.AddWithValue("@description", task.description);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted);
            cmd.Parameters.AddWithValue("@username", user.userName);

            con.Open();

            int addedRows = cmd.ExecuteNonQuery();

            con.Close();

            return addedRows == 1 ? true : false;
        }
    }
}

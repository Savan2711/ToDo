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
        SqlDataReader reader;

        public TaskService()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WebProjects\ToDo\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public bool AddTask(User user, Task task)
        {
            if (user==null || !user.ValidateUser())
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

            int addedRows;
            try
            {
                addedRows = cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                con.Close();
                return false;
            }

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

        public List<Task> GetAllTasks(User user)
        {
            //string allTask = "Invalid User";

            if (!user.ValidateUser())
            {
                return null;
            }

            cmd.CommandText = "SELECT * FROM Task WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", user.userName);

            con.Open();
            reader = cmd.ExecuteReader();

            List<Task> taskList = new List<Task>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Task thisTask = new Task();
                    thisTask.title = reader.GetString(0);
                    thisTask.description = reader.GetString(1);
                    thisTask.isCompleted = reader.GetInt32(2) == 1 ? true : false;
                    taskList.Add(thisTask);
                }
            }
            else
            {
                Task emptyTask = new Task();

                emptyTask.title = "No Task Added!";
                emptyTask.description = "No Task Added";
                emptyTask.isCompleted = true;

                taskList.Add(emptyTask);
            }

            //Console.WriteLine(taskList.ToString());
            reader.Close();
            con.Close();
            return taskList;
        }

        public Task SearchTaskByTitle(User user, string taskTitle)
        {
            Task thisTask = null;
            if (!user.ValidateUser())
            {
                return null;
            }

            cmd.CommandText = "SELECT * FROM Task WHERE username=@username AND title=@taskTitle";
            cmd.Parameters.AddWithValue("@username", user.userName);
            cmd.Parameters.AddWithValue("@taskTitle", taskTitle);
            con.Open();
            reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    thisTask = new Task();
                    thisTask.title = reader.GetString(0);
                    thisTask.description = reader.GetString(1);
                    thisTask.isCompleted = reader.GetInt32(2) == 1 ? true : false;
                }
            }

            reader.Close();
            con.Close();
            return thisTask;
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

            int addedRows;

            try
            {
                addedRows = cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                con.Close();
                return false;
            }

            return addedRows == 1 ? true : false;
        }
    }
}
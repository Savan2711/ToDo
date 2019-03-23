using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class UserService : IUserService
    {
        SqlConnection con; 
        SqlCommand cmd;
               
        public UserService()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\Desktop\ToDo\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public bool AddUser(User user)
        {
            cmd.CommandText = "INSERT INTO [User] VALUES(@userName, @password)";
            cmd.Parameters.AddWithValue("@userName", user.userName);
            cmd.Parameters.AddWithValue("@password", user.password);

            con.Open();

            int addedRows = cmd.ExecuteNonQuery();

            con.Close();

            return addedRows == 1 ? true : false;
        }
    }
}

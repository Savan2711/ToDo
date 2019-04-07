using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ToDo
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public bool ValidateUser()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\Desktop\ToDo\ToDo\ToDo\ToDoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from [User] WHERE userName=@userName and password=@password";
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            bool isValidated = reader.HasRows;
            reader.Close();

            con.Close();

            return isValidated;
        }
    }
}

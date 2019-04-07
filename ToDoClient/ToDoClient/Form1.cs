using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoClient
{
    public partial class Form1 : Form
    {
        public static string userName = "";
        public static string passWord = "";

        public Form1()
        {
            InitializeComponent();
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine(comboBox1.SelectedIndex.ToString());
        //    switch(comboBox1.SelectedIndex.ToString())
        //    {
        //        case "0":
        //            username.Visible = true;
        //            usernameBox.Visible = true;
        //            password.Visible = true;
        //            passwordBox.Visible = true;
        //            break;

        //        case "1":
        //            username.Visible = true;
        //            usernameBox.Visible = true;
        //            password.Visible = true;
        //            passwordBox.Visible = true;
        //            break;

        //        case "2":
        //            username.Visible = true;
        //            usernameBox.Visible = true;
        //            password.Visible = true;
        //            passwordBox.Visible = true;
        //            break;

        //        case "3":
        //            username.Visible = true;
        //            usernameBox.Visible = true;
        //            password.Visible = true;
        //            passwordBox.Visible = true;
        //            break;

        //        case "4":
        //            username.Visible = true;
        //            usernameBox.Visible = true;
        //            password.Visible = true;
        //            passwordBox.Visible = true;
        //            break;
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //username.Visible = false;
            //usernameBox.Visible = false;
            //password.Visible = false;
            //passwordBox.Visible = false;
        }

        private void getAllTask_Click(object sender, EventArgs e)
        {
            userName = usernameBox.Text;
            passWord = passwordBox.Text;

            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

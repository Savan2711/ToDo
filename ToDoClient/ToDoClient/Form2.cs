﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ToDoClient.TaskServiceReference;

namespace ToDoClient
{
    public partial class Form2 : Form
    {
        TaskServiceReference.User user = new TaskServiceReference.User();
        TaskServiceReference.Task task = new TaskServiceReference.Task();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TaskServiceClient taskClient = new TaskServiceClient();
            taskTitle.Visible = false;
            taskTitleBox.Visible = false;
            description.Visible = false;
            descriptionBox.Visible = false;
            confirm.Visible = false;
            label1.Visible = false;
        
            user.userName = Form1.userName;
            user.password = Form1.passWord;

            //Console.WriteLine(taskClient.GetAllTasks(user).ToString());

            TaskServiceReference.Task[] allTask = taskClient.GetAllTasks(user);

            List<Task> lst = new List<Task>(allTask);
            List<String> titleList = new List<string>();
            foreach (var i in lst)
            {
                titleList.Add(i.title);// + " " + i.description + " " + i.isCompleted);
            }
            listBox1.DataSource = titleList;

            taskClient.Close();
            //List<TaskServiceReference.Task> allTask = taskClient.GetAllTasks(user); 
            //(List<TaskServiceReference.Task>)JsonConvert.DeserializeObject(taskClient.GetAllTasks(user));

            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //var taskObject = new JavaScriptSerializer().DeserializeObject(taskClient.GetAllTasks(user));

            //var taskObject = JObject.Parse(taskClient.GetAllTasks(user));
            //Console.WriteLine(taskObject.ToString());
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            taskTitle.Visible = true;
            taskTitleBox.Visible = true;
            description.Visible = true;
            descriptionBox.Visible = true;
            confirm.Text = "Confirm Add";
            confirm.Visible = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            TaskServiceClient taskClient = new TaskServiceClient();
            task.title = taskTitleBox.Text;
            task.description = descriptionBox.Text;
            if(confirm.Text == "Confirm Add")
            {
                Console.WriteLine(taskClient.AddTask(user, task));
                taskClient.Close();
                label1.Text = task.title + " is added successfully.";
                label1.Visible = true;
                TaskServiceClient taskClient1 = new TaskServiceClient();
                TaskServiceReference.Task[] allTask = taskClient1.GetAllTasks(user);
                List<Task> lst = new List<Task>(allTask);
                List<String> titleList = new List<string>();
                foreach (var i in lst)
                {
                    titleList.Add(i.title);// + " " + i.description + " " + i.isCompleted);
                }
                listBox1.DataSource = titleList;
                taskClient1.Close();
            }
            else if(confirm.Text == "Confirm Update")
            {
                String taskString = listBox1.SelectedItem.ToString();
                taskClient.UpdateTask(user, taskString, task);
                label1.Text = listBox1.SelectedItem + " is updated successfully.";
                label1.Visible = true;
                TaskServiceClient taskClient1 = new TaskServiceClient();
                TaskServiceReference.Task[] allTask = taskClient1.GetAllTasks(user);
                List<Task> lst = new List<Task>(allTask);
                List<String> titleList = new List<string>();
                foreach (var i in lst)
                {
                    titleList.Add(i.title);// + " " + i.description + " " + i.isCompleted);
                }
                listBox1.DataSource = titleList;
                taskClient1.Close();
            }
            taskClient.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            taskTitle.Visible = true;
            taskTitleBox.Visible = true;
            description.Visible = true;
            descriptionBox.Visible = true;
            confirm.Text = "Confirm Update";
            confirm.Visible = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TaskServiceClient taskClient = new TaskServiceClient();
            taskClient.DeleteTask(user, listBox1.SelectedItem.ToString());
            label1.Text = listBox1.SelectedItem + " is deleted.";
            label1.Visible = true;
            taskClient.Close();
            TaskServiceClient taskClient1 = new TaskServiceClient();
            TaskServiceReference.Task[] allTask = taskClient1.GetAllTasks(user);
            List<Task> lst = new List<Task>(allTask);
            List<String> titleList = new List<string>();
            foreach (var i in lst)
            {
                titleList.Add(i.title);// + " " + i.description + " " + i.isCompleted);
            }
            listBox1.DataSource = titleList;
            taskClient1.Close();
        }

        private void completeTask_Click(object sender, EventArgs e)
        {
            TaskServiceClient taskClient = new TaskServiceClient();
            taskClient.MarkTaskCompleted(user, listBox1.SelectedItem.ToString());
            label1.Text = listBox1.SelectedItem + " is completed.";
            label1.Visible = true;
            taskClient.Close();
        }

        private void getDescription_Click(object sender, EventArgs e)
        {
            TaskServiceClient taskClient = new TaskServiceClient();
            TaskServiceReference.Task task = taskClient.SearchTaskByTitle(user, listBox1.SelectedItem.ToString());
            description.Visible = true;
            descriptionBox.Visible = true;
            descriptionBox.Text = task.description;
            descriptionBox.Enabled = false;
            taskClient.Close();

        }
    } 
}

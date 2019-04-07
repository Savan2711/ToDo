using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ToDo;

namespace ToDoHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type userService = typeof(UserService);
            Type taskService = typeof(TaskService);

            Uri taskTcp = new Uri("net.tcp://localhost:8010/TaskService");

            Uri userTcp = new Uri("net.tcp://localhost:8010/UserService");

            using (ServiceHost userHost = new ServiceHost(userService, userTcp))
            using (ServiceHost taskHost = new ServiceHost(taskService, taskTcp))
            {
                userHost.Open();
                Console.WriteLine("UserService Published");

                taskHost.Open();
                Console.WriteLine("TaskService Published");
                Console.ReadLine();
                userHost.Close();
                taskHost.Close();
            }
        }
    }
}

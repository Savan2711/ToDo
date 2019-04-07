using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ToDo
{
    [ServiceContract]
    public interface ITaskService
    {
        [OperationContract]
        bool AddTask(User user, Task task);
        [OperationContract]
        bool MarkTaskCompleted(User user, string taskTitle);
        [OperationContract]
        bool UpdateTask(User user, string taskTitle, Task task);
        [OperationContract]
        bool DeleteTask(User user, string taskTitle);
        [OperationContract]
        List<Task> GetAllTasks(User user);
        [OperationContract]
        string SearchTaskByTitle(User user,string taskTitle);
    }
}

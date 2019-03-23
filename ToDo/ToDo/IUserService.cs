using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        bool AddUser(User user);
    }
}

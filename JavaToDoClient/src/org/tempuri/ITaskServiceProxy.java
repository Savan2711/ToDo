package org.tempuri;

public class ITaskServiceProxy implements org.tempuri.ITaskService {
  private String _endpoint = null;
  private org.tempuri.ITaskService iTaskService = null;
  
  public ITaskServiceProxy() {
    _initITaskServiceProxy();
  }
  
  public ITaskServiceProxy(String endpoint) {
    _endpoint = endpoint;
    _initITaskServiceProxy();
  }
  
  private void _initITaskServiceProxy() {
    try {
      iTaskService = (new org.tempuri.TaskServiceLocator()).getBasicHttpBinding_ITaskService();
      if (iTaskService != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iTaskService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iTaskService)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iTaskService != null)
      ((javax.xml.rpc.Stub)iTaskService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.ITaskService getITaskService() {
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService;
  }
  
  public java.lang.Boolean addTask(org.datacontract.schemas._2004._07.ToDo.User user, org.datacontract.schemas._2004._07.ToDo.Task task) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.addTask(user, task);
  }
  
  public java.lang.Boolean markTaskCompleted(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.markTaskCompleted(user, taskTitle);
  }
  
  public java.lang.Boolean updateTask(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle, org.datacontract.schemas._2004._07.ToDo.Task task) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.updateTask(user, taskTitle, task);
  }
  
  public java.lang.Boolean deleteTask(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.deleteTask(user, taskTitle);
  }
  
  public org.datacontract.schemas._2004._07.ToDo.Task[] getAllTasks(org.datacontract.schemas._2004._07.ToDo.User user) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.getAllTasks(user);
  }
  
  public org.datacontract.schemas._2004._07.ToDo.Task searchTaskByTitle(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException{
    if (iTaskService == null)
      _initITaskServiceProxy();
    return iTaskService.searchTaskByTitle(user, taskTitle);
  }
  
  
}
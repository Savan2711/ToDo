/**
 * ITaskService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface ITaskService extends java.rmi.Remote {
    public java.lang.Boolean addTask(org.datacontract.schemas._2004._07.ToDo.User user, org.datacontract.schemas._2004._07.ToDo.Task task) throws java.rmi.RemoteException;
    public java.lang.Boolean markTaskCompleted(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException;
    public java.lang.Boolean updateTask(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle, org.datacontract.schemas._2004._07.ToDo.Task task) throws java.rmi.RemoteException;
    public java.lang.Boolean deleteTask(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.ToDo.Task[] getAllTasks(org.datacontract.schemas._2004._07.ToDo.User user) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.ToDo.Task searchTaskByTitle(org.datacontract.schemas._2004._07.ToDo.User user, java.lang.String taskTitle) throws java.rmi.RemoteException;
}

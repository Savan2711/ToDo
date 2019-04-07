package ToDoClient;

import java.io.IOException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.datacontract.schemas._2004._07.ToDo.Task;
import org.datacontract.schemas._2004._07.ToDo.User;
import org.tempuri.ITaskServiceProxy;


/**
 * Servlet implementation class AddTask
 */
@WebServlet("/ReloadAfterAction")
public class ReloadAfterAction extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ReloadAfterAction() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String title=null,description=null,action=null;
		User user = null;
		
		try
		{
			user = (User)request.getSession(false).getAttribute("user");
			title = request.getParameter("title");
			action = request.getParameter("doAction");
			
			if(action.equals("AddTask") || action.equals("UpdateTask"))
			{
				description = request.getParameter("description");
			}
		}
		catch(NullPointerException e)
		{
			response.sendRedirect("login.html");
		}
		
		Task task = new Task();
		ITaskServiceProxy proxy = new ITaskServiceProxy();
		
		if(action.equals("AddTask"))
		{
			task.setTitle(title);
			task.setDescription(description);
			task.setIsCompleted(false);
			proxy.addTask(user, task);
		}
		else if(action.equals("UpdateTask"))
		{
			task.setTitle(title);
			task.setDescription(description);
			task.setIsCompleted(proxy.searchTaskByTitle(user,title).getIsCompleted());
			proxy.updateTask(user,title,task);
		}
		else 
		{
			if(action.equals("MarkTaskCompleted"))
			{
				proxy.markTaskCompleted(user,title);
			}
			else if(action.equals("DeleteTask"))
			{
				proxy.deleteTask(user,title);
			}
			else 
			{
				response.sendRedirect("login.html");
			}
		}
		
		Task[] tasks = proxy.getAllTasks(user);
			
		HttpSession session = request.getSession();
		session.setAttribute("tasks",tasks);
		
		RequestDispatcher rd = request.getRequestDispatcher("/AllTasks.jsp");
		rd.forward(request,response);
	}
}

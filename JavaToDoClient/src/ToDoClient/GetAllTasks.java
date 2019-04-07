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
 * Servlet implementation class GetAllTasks
 */
@WebServlet("/GetAllTasks")
public class GetAllTasks extends HttpServlet {
	private static final long serialVersionUID = 1L;

    /**
     * Default constructor. 
     */
    public GetAllTasks() {
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
		String userName=null,password=null;
	
		try
		{
			userName = request.getParameter("userName");
			password = request.getParameter("password");
		}
		catch(NullPointerException ex)
		{
			response.sendRedirect("login.html");
		}
		
		User user = new User();
		user.setUserName(userName);
		user.setPassword(password);
		
		ITaskServiceProxy proxy = new ITaskServiceProxy();
		Task[] tasks = proxy.getAllTasks(user);
		
		if(tasks==null)
		{
			response.sendRedirect("login.html");
		}
		else
		{
			HttpSession session = request.getSession();
			session.setAttribute("user",user);
			session.setAttribute("tasks",tasks);
			
			RequestDispatcher rd = request.getRequestDispatcher("/AllTasks.jsp");
			rd.forward(request,response);
		}
	}

}

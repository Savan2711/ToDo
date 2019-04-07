<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>My To-Do</title>
</head>
<body>
		<Table border="1">
			<c:forEach items="${sessionScope.tasks}" var="task">
				<tr style="text-align:center" height="50">
					<td>${task.getTitle()}</td>
					<td style="text-align:center" width="50">
						<c:choose>
							<c:when test="${task.getIsCompleted() eq true}">
								<button type="submit" class="material-icons" style="font-size:18px;">thumb_up</button>
							</c:when>
							<c:otherwise>
								<form method="post" action="ReloadAfterAction">
								<input type="hidden" name="doAction" value="MarkTaskCompleted">
								<input type="hidden" name="title" value="${task.getTitle()}"> 
								<button type="submit" class="material-icons" style="font-size:18px;">thumb_down</button>
								</form>
							</c:otherwise>
						</c:choose>
					</td>
					<td style="text-align:center" width="50"><button onclick="alert('You have to: ${task.getDescription()}')" type="submit" class="material-icons" style="font-size:18px;">description</button></td>
					<td style="text-align:center" width="50"><button onclick="displayUpdateForm(event)" title="${task.getTitle()}" description="${task.getDescription()}" type="submit" class="material-icons" style="font-size:18px;">mode_edit</button></td>
					<td style="text-align:center" width="50">
						<form method="post" action="ReloadAfterAction">
							<input type="hidden" name="doAction" value="DeleteTask">
							<input type="hidden" name="title" value="${task.getTitle()}"> 
							<button type="submit" class="material-icons" style="font-size:18px;">delete_forever</button>
						</form>
					</td>
				</tr>
			</c:forEach> 
		</Table>
		<br><br>
		
		<table>
		<tr><td id="hideColumn">
		Got Something New To-Do?:<br> 
		<form method="post" action="ReloadAfterAction">
			<input type="hidden" name="doAction" value="AddTask" >							
			<table border="2">
				<tr><td>Title:<input type="text" name="title" placeholder="title" required></td></tr>
				<tr><td>Description:<textarea rows="3" cols="20" name="description" required>What To-Do?</textarea></td></tr>
		    	<tr><td><button type="submit">Add To-Do!</button></td></tr>
			</table>
		</form>
		</td>
		<td style="display:none" id="hiddenColumn">
		ToDo Got Some Updates?:<br> 
		<form method="post" action="ReloadAfterAction">
			<input type="hidden" name="doAction" value="UpdateTask" >							
			<table border="2">
				<tr><td>Title:<input id="updateFormTitle" type="text" name="title" placeholder="title" readonly></td></tr>
				<tr><td>Description:<textarea  id="updateFormDescription" rows="3" cols="20" name="description" required>What To-Do?</textarea></td></tr>
		    	<tr><td><button type="submit">Update To-Do!</button></td></tr>
			</table>
		</form>	
		</td></tr>
		</table>
		
		<script>
			function displayUpdateForm(event)
			{
				//alert(document.getElementById("hiddenRow").style.display);
				document.getElementById("hiddenColumn").style.display = "block";
				document.getElementById("hideColumn").style.display = "none";
				document.getElementById("updateFormTitle").value = event.target.getAttribute('title');
				document.getElementById("updateFormDescription").value = event.target.getAttribute('description');
			}
		</script>
</body>
</html>
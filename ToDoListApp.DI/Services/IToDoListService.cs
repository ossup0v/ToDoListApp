using System;
using System.Collections.Generic;
using ToDoListApp.DI.Data;

namespace ToDoListApp.DI.Services
{
	public interface IToDoListService
	{
		ToDoList CreateList(string userId, List<ToDoCheckPoint> checkPoints, string Description, DateTime? dedline = null);
		ToDoCheckPoint CreateCheckPoint(string userId, string decription, DateTime? dedline = null);
	}
}

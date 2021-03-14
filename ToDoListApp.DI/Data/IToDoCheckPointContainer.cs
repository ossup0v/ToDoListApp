using System.Collections.Generic;

namespace ToDoListApp.DI.Data
{
	public interface IToDoCheckPointContainer
	{
		IEnumerable<ToDoCheckPoint> GetAll { get; set; }
		IEnumerable<ToDoCheckPoint> SortBy(EToDoCheckPointSortBy sortBy, bool invert = false);
		void Add(ToDoCheckPoint checkPoint);
		bool Remove(string UId);
		bool TryGet(string UId, out ToDoCheckPoint value);
		bool IsConstains(string UId);
	}
}

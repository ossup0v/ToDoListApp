using System;

namespace ToDoListApp.DI.Data
{
	public sealed class ToDoList
	{
		public string UserId { get; set; } 
		public ulong UId { get; set; }
		public int SerialNumber { get; set; }
		public string Decrition { get; set; }
		public IToDoCheckPointContainer CheckPointsContainer {get;set;}
		public DateTime CreatedAt { get; set; } = DateTime.MinValue;
	}
}

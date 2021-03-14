using System;

namespace ToDoListApp.DI.Data
{
	public sealed class ToDoCheckPoint
	{
		public string UserId { get; set; }
		public uint UId { get; set; }
		public int SerialNumber { get; set; }
		public string Description { get; set; }
		public bool IsComplited { get; set; }
		public EToDoCheckPointPriority Priority { get; set; }
		public DateTime Dedline { get; set; } = DateTime.MinValue;
		public DateTime CreatedAt { get; set; }
	}
}

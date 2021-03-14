using System.Runtime.CompilerServices;

namespace ToDoListApp.Web.Extensions
{
	public static class LogLevelEx
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToUpperString(this Microsoft.Extensions.Logging.LogLevel level)
		{
			switch (level)
			{
				case Microsoft.Extensions.Logging.LogLevel.Trace:
					return "TRACE";
				case Microsoft.Extensions.Logging.LogLevel.Debug:
					return "DEBUG";
				case Microsoft.Extensions.Logging.LogLevel.Information:
					return "INFO";
				case Microsoft.Extensions.Logging.LogLevel.Warning:
					return "WARNING";
				case Microsoft.Extensions.Logging.LogLevel.Error:
					return "ERROR";
				case Microsoft.Extensions.Logging.LogLevel.Critical:
					return "CRITICAL";
				case Microsoft.Extensions.Logging.LogLevel.None:
					return "NONE";
				default:
					throw new System.Exception();
			}
		}
	}
}

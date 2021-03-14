using Cysharp.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ZLogger;
using ToDoListApp.Web.Extensions;
using Microsoft.Extensions.Configuration;
using ToDoListApp.Web.Settings;

namespace ToDoListApp.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
				Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
						{
							webBuilder.UseStartup<Startup>()
							.UseUrls("http://*:8081");
						})
				.ConfigureLogging((context, builder) =>
						{
							builder.ClearProviders();

							if (context.HostingEnvironment.IsProduction())
							{
								//TODO..
							}

							builder.AddZLoggerConsole(options => 
							{
								options.PrefixFormatter = (writer, info) => ZString.Utf8Format(writer, "[{0}] [{1}] ", info.LogLevel.ToUpperString(), info.Timestamp.ToLocalTime().DateTime);
							});


							builder.AddZLoggerRollingFile((dt, x) => $"logs/{dt.ToLocalTime():yyyy-MM-dd}_{x:000}.log", x => x.ToLocalTime().Date, 1024 * 10,
							options =>
							{
								options.PrefixFormatter = (writer, info) => ZString.Utf8Format(writer, "[{0}] [{1}] ", info.LogLevel.ToUpperString(), info.Timestamp.ToLocalTime().DateTime);
							});

						})
				.ConfigureServices((context,
					collection) => collection
						.Configure<MongoSettings>((settings) => 
								{
									settings = context.Configuration.GetSection("MongoSettings").Get<MongoSettings>();
								}));
	}
}

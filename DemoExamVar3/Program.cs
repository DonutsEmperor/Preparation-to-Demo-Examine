using Azure.Core;
using DemoExam.Database;
using DemoExam.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace DemoExam
{
	internal static class Program
	{
		private static IServiceProvider _provider = null!;

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			var services = new ServiceCollection();
			services.AddDbContext<AppDbContext>();
			services.AddTransient<Auth>();
			services.AddTransient<DataGridForm>();
			services.AddScoped<IDbWorker, DbWorker>();

			_provider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_provider.GetRequiredService<Auth>());
		}
	}
}
using Azure.Core;
using MainApplication.Database;
using MainApplication.Forms;
using MainApplication.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MainApplication
{
	internal static class Program
	{
		private static IServiceProvider _provider = null!;

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			var services = new ServiceCollection();

			//adding the dbContext
			services.AddDbContext<AppDbContext>();

			//adding the forms
			services.AddTransient<Authorization>();
			services.AddTransient<Registration>();
			services.AddTransient<DataGridForm>();

			//addong the services
			services.AddScoped<IDbWorker, DbWorker>();

			_provider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_provider.GetRequiredService<Authorization>());
		}
	}
}
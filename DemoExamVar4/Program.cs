using DemoExamVar4.Database;
using DemoExamVar4.Services.Implementations;
using DemoExamVar4.Services.Interfaces;
using DemoExamVar4.Windows;
using Microsoft.Extensions.DependencyInjection;


namespace DemoExamVar4
{
    internal static class Program
    {
        public static ServiceProvider _provider = null!;

        [STAThread]
        static void Main()
        {
            var collection = new ServiceCollection();

            collection.AddTransient<MainForm>();
            collection.AddScoped<IDbWorker, DbWorker>();
            collection.AddDbContext<AppDbContext>();

			_provider = collection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(_provider.GetService<MainForm>()!);
        }
    }
}
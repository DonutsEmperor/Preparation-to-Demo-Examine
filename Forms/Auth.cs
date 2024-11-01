using DemoExam.Database;
using DemoExam.Database.Models;
using DemoExam.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DemoExam
{
	public partial class Auth : Form
	{
		private readonly IServiceProvider _provider;
		private readonly IDbWorker _db;

		public Auth(IServiceProvider provider, IDbWorker db)
		{
			_provider = provider;
			_db = db;
			InitializeComponent();
		}

		private void BtnEnter_Click(object sender, EventArgs e)
		{
			if ((tbLogin.Text is not null) && (tbPassword.Text is not null))
			{
				Client? client = _db.Clients.Where(c => c.Login == tbLogin.Text && c.Password == tbPassword.Text).
					FirstOrDefault();

				if (client is null)
				{
					LblStatus.Text = "Login or Password was incorrect or both";
					return;				
				}

				var next = _provider.GetService<DataGridForm>()!;
				next.ShowDialog();
			}
		}
	}
}

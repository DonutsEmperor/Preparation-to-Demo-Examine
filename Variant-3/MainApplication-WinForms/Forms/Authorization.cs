using MainApplication.Database.Models;
using MainApplication.Forms;
using MainApplication.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace MainApplication
{
	public partial class Authorization : Form
	{
		private readonly IServiceProvider _provider;

		public Authorization(IServiceProvider provider)
		{
			_provider = provider;
			InitializeComponent();
		}

		private void BtnEnter_Click(object sender, EventArgs e)
		{
			if ((tbLogin.Text is not null) && (tbPassword.Text is not null))
			{
				bool result = MyFunctions.MyRealFunctions
					.Authorization(tbLogin.Text, tbPassword.Text);

				if (result is false)
				{
					lblStatus.Text = "Login or Password was incorrect or both";
					return;
				}

				var next = _provider.GetService<DataGridForm>()!;
				next.ShowDialog();
			}
		}

		private void btnRegistration_Click(object sender, EventArgs e)
		{
			var next = _provider.GetService<Registration>()!;
			next.ShowDialog();
		}
	}
}
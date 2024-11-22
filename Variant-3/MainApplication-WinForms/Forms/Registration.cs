using MainApplication.Database.Models;
using MainApplication.MyFunctions;
using MainApplication.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace MainApplication.Forms
{
	public partial class Registration : Form
	{
		private readonly IServiceProvider _provider;

		public Registration(IServiceProvider provider)
		{
			_provider = provider;
			InitializeComponent();
		}

		private void BtnEnter_Click(object sender, EventArgs e)
		{
			if ((!tbLogin.Text.RegistrationValidation()) && (!tbAddress.Text.RegistrationValidation())
				&& (!tbName.Text.RegistrationValidation()) && (!tbPhone.Text.RegistrationValidation())
					&& (!tbPassword.Text.RegistrationValidation()))
			{
				var clientInfo = new
				{
					Login = tbLogin.Text,
					Name = tbName.Text,
					Address = tbAddress.Text,
					Phone = tbPhone.Text,
					Password = tbPassword.Text
				};

				bool code = MyRealFunctions.AddClient(clientInfo);
				if(code is not true)
				{
					lblStatus.Text = "Anything has gone wrong!";
					return;
				}

				var next = _provider.GetService<DataGridForm>()!;
				next.ShowDialog();
				this.Close();
			}
			else
			{
				lblStatus.Text = "Any field was not filled or had more than 50 symbols";
				return;
			}
		}
	}
}

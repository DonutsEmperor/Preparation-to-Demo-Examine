using MainApplication.Database.Models;
using MainApplication.MyFunctions;
using MainApplication.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace MainApplication.Forms
{
	public partial class Options : Form
	{
		private readonly IServiceProvider _provider;
		private readonly IDbWorker _db;

		public Options(IServiceProvider provider, IDbWorker db)
		{
			_provider = provider;
			_db = db;

			InitializeComponent();

			var list = _db.Orders.
				Where(o => o.Client.ClientId.
					Equals(GlobalStorage.CurrentUser.ClientId)).ToList();

			dgvOrders.DataSource = list;
			dgvOrders.ReadOnly = true;
			PasteTheInfo();

		}

		private void PasteTheInfo()
		{
			var user = GlobalStorage.CurrentUser;
			tbLogin.Text = user.Login;
			tbName.Text = user.Name;
			tbPhone.Text = user.Phone;
			tbAddress.Text = user.Address;
			tbPassword.Text = "Enter new password";
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

				bool code = MyRealFunctions.UpdateClient(clientInfo);
				if (code is not true)
				{
					lblStatus.Text = "Anything has gone wrong!";
					return;
				}

				GlobalStorage.CurrentUser = MyFunctions.MyRealFunctions.FindClient(tbLogin.Text!)!;
				var next = _provider.GetService<MainWindow>()!;
				next.ChangeVisibility();

				this.Hide(); this.Close();
			}
			else
			{
				lblStatus.Text = "Any field was not filled or had more than 50 symbols";
				return;
			}
		}
	}
}

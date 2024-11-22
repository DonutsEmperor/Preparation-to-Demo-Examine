using MainApplication.Database;
using MainApplication.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.MyFunctions
{
	public static class MyRealFunctions
	{
		public static bool RegistrationValidation(this string text)
			=> (string.IsNullOrWhiteSpace(text) || (text.Length > 50));

		public static bool Authorization(string login, string password)
        {
            Client? client;
			using (var db = new AppDbContext())
			{
				client = db.Clients
					.Where(c => c.Login == login && c.Password == password)
						.FirstOrDefault();

				if (client is null) return false;
			}
			return true;
		}

		public static Client? FindClient(string field)
		{
			using (var db = new AppDbContext())
			{
				Client? client = db.Clients.Where(c => c.Login == field ||
					c.Phone == field).FirstOrDefault();

				return client;
			}
		}


		public static bool AddClient(dynamic info)
		{
			try
			{
				using (var db = new AppDbContext())
				{
					string login = info.Login;
					string phone = info.Phone;

					if (FindClient(login) is not null || FindClient(phone) is not null)
						return false;

					Client client = new Client()
					{
						ClientId = (byte)db.Clients.Count(),
						Login = info.Login,
						Name = info.Name,
						Address = info.Address,
						Phone = info.Phone,
						Password = info.Password,
						FavoriteId = ((byte) new Random().Next(0, 10)),
					};

					db.Clients.Add(client);
					db.SaveChanges();
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}

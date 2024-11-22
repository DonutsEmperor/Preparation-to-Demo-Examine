using MainApplication.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Services.Interface
{
	public interface IDbWorker
	{
		IEnumerable<Animal> Animals { get; }
		IEnumerable<Brand> Brands { get; }
		IEnumerable<Category> Categories { get; }
		IEnumerable<Client> Clients { get; }
		IEnumerable<Compound> Compounds { get; }
		IEnumerable<Favorite> Favorites { get; }
		IEnumerable<Order> Orders { get; }
		IEnumerable<Product> Products{ get; }
		public void SaveChanges();
	}
}

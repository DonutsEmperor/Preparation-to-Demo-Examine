using DemoExam.Database;
using DemoExam.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.Services.Interface
{
	public class DbWorker : IDbWorker
	{
		private AppDbContext _context;

		public DbWorker(AppDbContext context)
		{
			_context = context;
			LoadEntities();
		}

		private void LoadEntities()
		{
			_context.Animals.Load();
			_context.Brands.Load();
			_context.Categories.Load();
			_context.Clients.Load();
			_context.Compounds.Load();
			_context.Favorites.Load();
			_context.Orders.Load();
			_context.Products.Load();
		}

		public IEnumerable<Animal> Animals => _context.Animals.ToList();
		public IEnumerable<Brand> Brands => _context.Brands.ToList();
		public IEnumerable<Category> Categories => _context.Categories.ToList();
		public IEnumerable<Client> Clients => _context.Clients.ToList();
		public IEnumerable<Compound> Compounds => _context.Compounds.ToList();
		public IEnumerable<Favorite> Favorites => _context.Favorites.ToList();
		public IEnumerable<Order> Orders => _context.Orders.ToList();
		public IEnumerable<Product> Products => _context.Products.ToList();

		public void SaveChanges() => _context.SaveChanges();
	}
}

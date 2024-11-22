using DemoExamVar4.Database;
using DemoExamVar4.Database.Models;
using DemoExamVar4.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamVar4.Services.Interfaces
{
	internal class DbWorker : IDbWorker
	{
		private AppDbContext _context;

		public DbWorker(AppDbContext context)
		{
			_context = context;
			LoadEntities();
		}

		private void LoadEntities()
		{
			_context.Categories.Load();
			_context.Dishes.Load();
			_context.DishIngredients.Load();
			_context.DishOrders.Load();
			_context.Employees.Load();
			_context.Ingredients.Load();
			_context.Orders.Load();
			_context.Roles.Load();
			_context.Statuses.Load();
			_context.Users.Load();
			_context.Tables.Load();
		}

		public IEnumerable<Category> Categories => _context.Categories.ToList();
		public IEnumerable<Dish> Dishes => _context.Dishes.ToList();
		public IEnumerable<DishIngredient> DishIngredients => _context.DishIngredients.ToList();
		public IEnumerable<DishOrder> DishOrders => _context.DishOrders.ToList();
		public IEnumerable<Employee> Employees => _context.Employees.ToList();
		public IEnumerable<Ingredient> Ingredients => _context.Ingredients.ToList();
		public IEnumerable<Order> Orders => _context.Orders.ToList();
		public IEnumerable<Role> Roles => _context.Roles.ToList();
		public IEnumerable<Status> Statuses => _context.Statuses.ToList();
		public IEnumerable<User> Users => _context.Users.ToList();
		public IEnumerable<Table> Tables => _context.Tables.ToList();

		public void SaveChanges() => _context.SaveChanges();
	}
}

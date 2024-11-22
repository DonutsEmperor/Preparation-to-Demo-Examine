using DemoExamVar4.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamVar4.Services.Implementations
{
	internal interface IDbWorker
	{
		IEnumerable<Category> Categories { get; }
		IEnumerable<Dish> Dishes { get; }
		IEnumerable<DishIngredient> DishIngredients { get; }
		IEnumerable<DishOrder> DishOrders { get; }
		IEnumerable<Employee> Employees { get; }
		IEnumerable<Ingredient> Ingredients { get; }
		IEnumerable<Order> Orders { get; }
		IEnumerable<Role> Roles { get; }
		IEnumerable<Status> Statuses { get; }
		IEnumerable<User> Users { get; }
		IEnumerable<Table> Tables { get; }
		public void SaveChanges();
	}
}

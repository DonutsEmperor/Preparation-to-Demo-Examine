using MainApplication.Database.Models;
using MainApplication.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using MainApplication.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication.Forms
{
	public partial class Cart : Form
	{
		private readonly IDbWorker _db;

		public Cart(IDbWorker db)
		{
			_db = db;

			InitializeComponent();
			FillTheLayout();
		}

		private void FillTheLayout()
		{
			panelProducts.Controls.Clear();
			foreach (var item in GlobalStorage.Cart)
			{
				panelProducts.Controls.Add(new ProductControl(item));
			}
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			Order order = new Order 
			{ 
				ClientId = GlobalStorage.CurrentUser.ClientId, 
				OrderId = (byte)_db.Orders.Count(),
				StartDate = DateOnly.FromDateTime(DateTime.Now),
				EndDate = DateOnly.MaxValue
			};

			MyFunctions.MyRealFunctions.AddOrder(order, GlobalStorage.Cart);
		}
	}
}

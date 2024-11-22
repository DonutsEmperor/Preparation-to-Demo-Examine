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
	public partial class MainWindow : Form
	{
		private readonly IServiceProvider _provider;
		private readonly IDbWorker _db;
		private Category filter = null!;
		private int offset = 0;

		private readonly Dictionary<string, Category> _dict
			= new Dictionary<string, Category>();

		private bool IsUserLoggedIn => GlobalStorage.CurrentUser is not null;

		public MainWindow(IServiceProvider provider, IDbWorker db)
		{
			_provider = provider;
			_db = db;

			InitializeComponent();
			FillTheComboBox();
			FillTheLayout();
			ChangeVisibility();
		}

		public void ChangeVisibility()
		{
			btnFavorite.Visible = IsUserLoggedIn;
			btnOptions.Visible = IsUserLoggedIn;
		}

		private void FillTheLayout()
		{
			panelProducts.Controls.Clear();

			if (filter is null)
			{
				foreach (var item in _db.Products.Skip(offset * 25).Take(25))
				{
					panelProducts.Controls.Add(new ProductControl(item));
				}
			}
			else
			{
				var list = _db.Products.Where(p => p.Category.Equals(filter)).ToList();
				foreach (var item in list.Skip(offset * 25).Take(25))
				{
					panelProducts.Controls.Add(new ProductControl(item));
				}
			}
		}

		private void FillTheComboBox()
		{
			cmbBoxCategories.Items.Clear();

			cmbBoxCategories.Items.Add("No filter");
			foreach (var item in _db.Categories)
			{
				cmbBoxCategories.Items.Add(item.Name);
				_dict.Add(item.Name, item);
			}
		}

		private void btnAuth_Click(object sender, EventArgs e)
		{
			var next = _provider.GetService<Authorization>()!;
			next.ShowDialog();
		}

		private void btnRegis_Click(object sender, EventArgs e)
		{
			var next = _provider.GetService<Registration>()!;
			next.ShowDialog();
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			var next = _provider.GetService<Options>()!;
			next.ShowDialog();
		}

		private void btnCart_Click(object sender, EventArgs e)
		{
			var next = _provider.GetService<Cart>()!;
			next.ShowDialog();
		}

		private void cmbBoxCategories_SelectedValueChanged(object sender, EventArgs e)
		{
			string category = cmbBoxCategories.SelectedItem!.ToString()!;

			if (category is "No filter") filter = null!;
			else filter = _dict[category];

			FillTheLayout();
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (offset > 0)
			{
				offset--;
				FillTheLayout();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			List<Product> list;
			if (filter is not null)
			{
				list = _db.Products.Where(p => p.Category.Equals(filter)).
				Skip((offset + 1) * 25).ToList();
			}
			else
			{
				list = _db.Products.Skip((offset + 1) * 25).ToList();
			}

			if (list.Count() > 0)
			{
				offset++;
				FillTheLayout();
			}
		}
	}
}

using DemoExam.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
	public partial class DataGridForm : Form
	{
		private readonly IServiceProvider _provider;
		private readonly IDbWorker _db;

		private Dictionary<string, IEnumerable<object>> dictionary
			= new Dictionary<string, IEnumerable<object>>();

		public DataGridForm(IServiceProvider provider, IDbWorker db)
		{
			_provider = provider;
			_db = db;

			InitializeComponent();
			InitComboBox();
		}

		private void InitComboBox()
		{
			dictionary.Add("Animals", _db.Animals);
			dictionary.Add("Brands", _db.Brands);
			dictionary.Add("Categories", _db.Categories);
			dictionary.Add("Clients", _db.Clients);
			dictionary.Add("Compounds", _db.Compounds);
			dictionary.Add("Favorites", _db.Favorites);
			dictionary.Add("Orders", _db.Orders);
			dictionary.Add("Products", _db.Products);

			foreach (var keyValue in dictionary)
			{
				cbTables.Items.Add(keyValue.Key);
			}
		}

		private void cbTables_SelectedValueChanged(object sender, EventArgs e)
		{
			generalDataGrid.DataSource = dictionary[cbTables.Text];
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{
				_db.SaveChanges();
				MessageBox.Show("Changes saved successfully!",
					"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex) 
			{
				MessageBox.Show("The data was modified by another user. Please refresh and try again.",
					"Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}

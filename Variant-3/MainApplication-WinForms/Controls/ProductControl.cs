using MainApplication.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication.Controls
{
	public partial class ProductControl : UserControl
	{
		private Product _product;

		public ProductControl(Product product)
		{
			InitializeComponent();
			_product = product;
			LoadProductFields();
		}

		private void LoadProductFields()
		{
			tbId.Text = _product.ProductId.ToString();
			tbName.Text = _product.Name;
			tbCategory.Text = _product.Category.Name;
			tbDesc.Text = _product.Description;
			tbBrand.Text = _product.Brand.Name;
			tbPrice.Text = _product.Price.ToString();
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			GlobalStorage.Cart.Push(_product);
		}
	}
}

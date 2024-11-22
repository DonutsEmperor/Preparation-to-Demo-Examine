namespace MainApplication.Controls
{
	partial class ProductControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbName = new TextBox();
			tbCategory = new TextBox();
			tbBrand = new TextBox();
			tbPrice = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			tbDesc = new TextBox();
			label5 = new Label();
			tbId = new TextBox();
			label6 = new Label();
			btnChoose = new Button();
			SuspendLayout();
			// 
			// tbName
			// 
			tbName.Location = new Point(92, 45);
			tbName.Name = "tbName";
			tbName.ReadOnly = true;
			tbName.Size = new Size(100, 23);
			tbName.TabIndex = 0;
			// 
			// tbCategory
			// 
			tbCategory.Location = new Point(208, 45);
			tbCategory.Name = "tbCategory";
			tbCategory.ReadOnly = true;
			tbCategory.Size = new Size(100, 23);
			tbCategory.TabIndex = 1;
			// 
			// tbBrand
			// 
			tbBrand.Location = new Point(314, 45);
			tbBrand.Name = "tbBrand";
			tbBrand.ReadOnly = true;
			tbBrand.Size = new Size(100, 23);
			tbBrand.TabIndex = 2;
			// 
			// tbPrice
			// 
			tbPrice.Location = new Point(420, 45);
			tbPrice.Name = "tbPrice";
			tbPrice.ReadOnly = true;
			tbPrice.Size = new Size(100, 23);
			tbPrice.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 9F);
			label1.Location = new Point(128, 24);
			label1.Name = "label1";
			label1.Size = new Size(35, 14);
			label1.TabIndex = 4;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Consolas", 9F);
			label2.Location = new Point(227, 24);
			label2.Name = "label2";
			label2.Size = new Size(63, 14);
			label2.TabIndex = 5;
			label2.Text = "Category";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Consolas", 9F);
			label3.Location = new Point(339, 24);
			label3.Name = "label3";
			label3.Size = new Size(42, 14);
			label3.TabIndex = 6;
			label3.Text = "Brand";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Consolas", 9F);
			label4.Location = new Point(451, 24);
			label4.Name = "label4";
			label4.Size = new Size(42, 14);
			label4.TabIndex = 7;
			label4.Text = "Price";
			// 
			// tbDesc
			// 
			tbDesc.Location = new Point(92, 106);
			tbDesc.Multiline = true;
			tbDesc.Name = "tbDesc";
			tbDesc.ReadOnly = true;
			tbDesc.ScrollBars = ScrollBars.Vertical;
			tbDesc.Size = new Size(428, 60);
			tbDesc.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Consolas", 9F);
			label5.Location = new Point(26, 28);
			label5.Name = "label5";
			label5.Size = new Size(21, 14);
			label5.TabIndex = 10;
			label5.Text = "Id";
			// 
			// tbId
			// 
			tbId.Location = new Point(15, 45);
			tbId.Name = "tbId";
			tbId.ReadOnly = true;
			tbId.Size = new Size(44, 23);
			tbId.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Consolas", 9F);
			label6.Location = new Point(108, 89);
			label6.Name = "label6";
			label6.Size = new Size(84, 14);
			label6.TabIndex = 11;
			label6.Text = "Description";
			// 
			// btnChoose
			// 
			btnChoose.Font = new Font("Consolas", 18F);
			btnChoose.Location = new Point(15, 112);
			btnChoose.Name = "btnChoose";
			btnChoose.Size = new Size(69, 54);
			btnChoose.TabIndex = 12;
			btnChoose.Text = "+";
			btnChoose.UseVisualStyleBackColor = true;
			btnChoose.Click += btnChoose_Click;
			// 
			// ProductControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnChoose);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(tbId);
			Controls.Add(tbDesc);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPrice);
			Controls.Add(tbBrand);
			Controls.Add(tbCategory);
			Controls.Add(tbName);
			Name = "ProductControl";
			Size = new Size(543, 182);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbName;
		private TextBox tbCategory;
		private TextBox tbBrand;
		private TextBox tbPrice;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox tbDesc;
		private Label label5;
		private TextBox tbId;
		private Label label6;
		private Button btnChoose;
	}
}

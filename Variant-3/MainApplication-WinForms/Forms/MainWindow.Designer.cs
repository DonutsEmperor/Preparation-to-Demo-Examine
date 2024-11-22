namespace MainApplication.Forms
{
	partial class MainWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelProducts = new FlowLayoutPanel();
			btnAuth = new Button();
			btnRegis = new Button();
			btnFavorite = new Button();
			btnOptions = new Button();
			cmbBoxCategories = new ComboBox();
			label1 = new Label();
			label5 = new Label();
			btnPrev = new Button();
			btnNext = new Button();
			SuspendLayout();
			// 
			// panelProducts
			// 
			panelProducts.AutoScroll = true;
			panelProducts.Location = new Point(35, 65);
			panelProducts.Name = "panelProducts";
			panelProducts.Size = new Size(717, 395);
			panelProducts.TabIndex = 0;
			// 
			// btnAuth
			// 
			btnAuth.Font = new Font("Consolas", 12F);
			btnAuth.Location = new Point(568, 34);
			btnAuth.Name = "btnAuth";
			btnAuth.Size = new Size(91, 25);
			btnAuth.TabIndex = 1;
			btnAuth.Text = "Auth";
			btnAuth.UseVisualStyleBackColor = true;
			btnAuth.Click += btnAuth_Click;
			// 
			// btnRegis
			// 
			btnRegis.Font = new Font("Consolas", 12F);
			btnRegis.Location = new Point(665, 34);
			btnRegis.Name = "btnRegis";
			btnRegis.Size = new Size(87, 25);
			btnRegis.TabIndex = 2;
			btnRegis.Text = "Regis";
			btnRegis.UseVisualStyleBackColor = true;
			btnRegis.Click += btnRegis_Click;
			// 
			// btnFavorite
			// 
			btnFavorite.Font = new Font("Consolas", 12F);
			btnFavorite.Location = new Point(35, 34);
			btnFavorite.Name = "btnFavorite";
			btnFavorite.Size = new Size(100, 25);
			btnFavorite.TabIndex = 4;
			btnFavorite.Text = "Cart";
			btnFavorite.UseVisualStyleBackColor = true;
			btnFavorite.Click += btnCart_Click;
			// 
			// btnOptions
			// 
			btnOptions.Font = new Font("Consolas", 12F);
			btnOptions.Location = new Point(141, 34);
			btnOptions.Name = "btnOptions";
			btnOptions.Size = new Size(91, 25);
			btnOptions.TabIndex = 3;
			btnOptions.Text = "Options";
			btnOptions.UseVisualStyleBackColor = true;
			btnOptions.Click += btnOptions_Click;
			// 
			// cmbBoxCategories
			// 
			cmbBoxCategories.FormattingEnabled = true;
			cmbBoxCategories.Location = new Point(421, 36);
			cmbBoxCategories.Name = "cmbBoxCategories";
			cmbBoxCategories.Size = new Size(121, 23);
			cmbBoxCategories.TabIndex = 5;
			cmbBoxCategories.SelectedValueChanged += cmbBoxCategories_SelectedValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 12F);
			label1.Location = new Point(316, 36);
			label1.Name = "label1";
			label1.Size = new Size(99, 19);
			label1.TabIndex = 6;
			label1.Text = "Categories";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Consolas", 12F);
			label5.Location = new Point(12, 9);
			label5.Name = "label5";
			label5.Size = new Size(162, 19);
			label5.TabIndex = 25;
			label5.Text = "OOO \"ЛАПКА\" Store";
			// 
			// btnPrev
			// 
			btnPrev.Font = new Font("Consolas", 12F);
			btnPrev.Location = new Point(35, 466);
			btnPrev.Name = "btnPrev";
			btnPrev.Size = new Size(61, 25);
			btnPrev.TabIndex = 26;
			btnPrev.Text = "Prev";
			btnPrev.UseVisualStyleBackColor = true;
			btnPrev.Click += btnPrev_Click;
			// 
			// btnNext
			// 
			btnNext.Font = new Font("Consolas", 12F);
			btnNext.Location = new Point(102, 466);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(61, 25);
			btnNext.TabIndex = 27;
			btnNext.Text = "Next";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(795, 499);
			Controls.Add(btnNext);
			Controls.Add(btnPrev);
			Controls.Add(label5);
			Controls.Add(label1);
			Controls.Add(cmbBoxCategories);
			Controls.Add(btnFavorite);
			Controls.Add(btnOptions);
			Controls.Add(btnRegis);
			Controls.Add(btnAuth);
			Controls.Add(panelProducts);
			Name = "MainWindow";
			Text = "MainWindow";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel panelProducts;
		private Button btnAuth;
		private Button btnRegis;
		private Button btnFavorite;
		private Button btnOptions;
		private ComboBox cmbBoxCategories;
		private Label label1;
		private Label label5;
		private Button btnPrev;
		private Button btnNext;
	}
}
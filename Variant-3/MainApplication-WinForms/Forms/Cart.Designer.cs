namespace MainApplication.Forms
{
	partial class Cart
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
			label5 = new Label();
			label1 = new Label();
			btnOrder = new Button();
			SuspendLayout();
			// 
			// panelProducts
			// 
			panelProducts.AutoScroll = true;
			panelProducts.Location = new Point(35, 44);
			panelProducts.Name = "panelProducts";
			panelProducts.Size = new Size(717, 388);
			panelProducts.TabIndex = 0;
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 12F);
			label1.Location = new Point(330, 22);
			label1.Name = "label1";
			label1.Size = new Size(90, 19);
			label1.TabIndex = 26;
			label1.Text = "Your cart";
			// 
			// btnOrder
			// 
			btnOrder.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnOrder.Location = new Point(304, 451);
			btnOrder.Name = "btnOrder";
			btnOrder.Size = new Size(172, 36);
			btnOrder.TabIndex = 27;
			btnOrder.Text = "Make Order";
			btnOrder.UseVisualStyleBackColor = true;
			btnOrder.Click += btnOrder_Click;
			// 
			// Cart
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(795, 499);
			Controls.Add(btnOrder);
			Controls.Add(label1);
			Controls.Add(label5);
			Controls.Add(panelProducts);
			Name = "Cart";
			Text = "MainWindow";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel panelProducts;
		private Label label5;
		private Label label1;
		private Button btnOrder;
	}
}
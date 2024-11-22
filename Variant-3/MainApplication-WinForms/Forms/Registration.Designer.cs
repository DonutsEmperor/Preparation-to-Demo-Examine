namespace MainApplication.Forms
{
	partial class Registration
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
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tbPhone = new TextBox();
			tbName = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			tbLogin = new TextBox();
			tbAddress = new TextBox();
			label7 = new Label();
			label8 = new Label();
			lblStatus = new Label();
			BtnEnter = new Button();
			label9 = new Label();
			tbPassword = new TextBox();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Consolas", 12F);
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(162, 19);
			label3.TabIndex = 13;
			label3.Text = "OOO \"ЛАПКА\" Store";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Consolas", 12F);
			label2.Location = new Point(518, 172);
			label2.Name = "label2";
			label2.Size = new Size(117, 19);
			label2.TabIndex = 12;
			label2.Text = "Phone number";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 12F);
			label1.Location = new Point(12, 422);
			label1.Name = "label1";
			label1.Size = new Size(135, 19);
			label1.TabIndex = 11;
			label1.Text = "Fill your data";
			// 
			// tbPhone
			// 
			tbPhone.Font = new Font("Consolas", 12F);
			tbPhone.Location = new Point(424, 194);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(306, 26);
			tbPhone.TabIndex = 10;
			// 
			// tbName
			// 
			tbName.Font = new Font("Consolas", 12F);
			tbName.Location = new Point(51, 142);
			tbName.Name = "tbName";
			tbName.Size = new Size(306, 26);
			tbName.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Consolas", 20F);
			label4.Location = new Point(304, 73);
			label4.Name = "label4";
			label4.Size = new Size(194, 32);
			label4.TabIndex = 14;
			label4.Text = "Registration";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Consolas", 12F);
			label5.Location = new Point(173, 172);
			label5.Name = "label5";
			label5.Size = new Size(54, 19);
			label5.TabIndex = 18;
			label5.Text = "Login";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Consolas", 12F);
			label6.Location = new Point(544, 110);
			label6.Name = "label6";
			label6.Size = new Size(0, 19);
			label6.TabIndex = 17;
			// 
			// tbLogin
			// 
			tbLogin.Font = new Font("Consolas", 12F);
			tbLogin.Location = new Point(53, 194);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(306, 26);
			tbLogin.TabIndex = 16;
			// 
			// tbAddress
			// 
			tbAddress.Font = new Font("Consolas", 12F);
			tbAddress.Location = new Point(424, 142);
			tbAddress.Name = "tbAddress";
			tbAddress.Size = new Size(306, 26);
			tbAddress.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Consolas", 12F);
			label7.Location = new Point(173, 120);
			label7.Name = "label7";
			label7.Size = new Size(45, 19);
			label7.TabIndex = 19;
			label7.Text = "Name";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Consolas", 12F);
			label8.Location = new Point(544, 120);
			label8.Name = "label8";
			label8.Size = new Size(72, 19);
			label8.TabIndex = 20;
			label8.Text = "Address";
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Consolas", 12F);
			lblStatus.Location = new Point(365, 364);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(63, 19);
			lblStatus.TabIndex = 22;
			lblStatus.Text = "Status";
			// 
			// BtnEnter
			// 
			BtnEnter.Font = new Font("Consolas", 12F);
			BtnEnter.Location = new Point(324, 386);
			BtnEnter.Name = "BtnEnter";
			BtnEnter.Size = new Size(139, 44);
			BtnEnter.TabIndex = 21;
			BtnEnter.Text = "Enter";
			BtnEnter.UseVisualStyleBackColor = true;
			BtnEnter.Click += BtnEnter_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Consolas", 12F);
			label9.Location = new Point(159, 232);
			label9.Name = "label9";
			label9.Size = new Size(81, 19);
			label9.TabIndex = 25;
			label9.Text = "Password";
			// 
			// tbPassword
			// 
			tbPassword.Font = new Font("Consolas", 12F);
			tbPassword.Location = new Point(51, 254);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(306, 26);
			tbPassword.TabIndex = 24;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label9);
			Controls.Add(tbPassword);
			Controls.Add(lblStatus);
			Controls.Add(BtnEnter);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(tbLogin);
			Controls.Add(tbAddress);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPhone);
			Controls.Add(tbName);
			Name = "Registration";
			Text = "Registration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox tbPhone;
		private TextBox tbName;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox tbLogin;
		private TextBox tbAddress;
		private Label label7;
		private Label label8;
		private Label lblStatus;
		private Button BtnEnter;
		private Label label9;
		private TextBox tbPassword;
	}
}
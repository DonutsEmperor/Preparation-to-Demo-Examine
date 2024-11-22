namespace MainApplication
{
	partial class Authorization
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tbPassword = new TextBox();
			tbLogin = new TextBox();
			lblStatus = new Label();
			BtnEnter = new Button();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Consolas", 20F);
			label4.Location = new Point(298, 115);
			label4.Name = "label4";
			label4.Size = new Size(209, 32);
			label4.TabIndex = 22;
			label4.Text = "Authorization";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Consolas", 12F);
			label3.Location = new Point(6, 8);
			label3.Name = "label3";
			label3.Size = new Size(162, 19);
			label3.TabIndex = 21;
			label3.Text = "OOO \"ЛАПКА\" Store";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Consolas", 12F);
			label2.Location = new Point(352, 236);
			label2.Name = "label2";
			label2.Size = new Size(81, 19);
			label2.TabIndex = 20;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Consolas", 12F);
			label1.Location = new Point(363, 173);
			label1.Name = "label1";
			label1.Size = new Size(54, 19);
			label1.TabIndex = 19;
			label1.Text = "Login";
			// 
			// tbPassword
			// 
			tbPassword.Font = new Font("Consolas", 12F);
			tbPassword.Location = new Point(241, 258);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(306, 26);
			tbPassword.TabIndex = 18;
			// 
			// tbLogin
			// 
			tbLogin.Font = new Font("Consolas", 12F);
			tbLogin.Location = new Point(241, 195);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(306, 26);
			tbLogin.TabIndex = 17;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Consolas", 12F);
			lblStatus.Location = new Point(6, 422);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(63, 19);
			lblStatus.TabIndex = 16;
			lblStatus.Text = "Status";
			lblStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BtnEnter
			// 
			BtnEnter.Font = new Font("Consolas", 12F);
			BtnEnter.Location = new Point(328, 334);
			BtnEnter.Name = "BtnEnter";
			BtnEnter.Size = new Size(139, 44);
			BtnEnter.TabIndex = 15;
			BtnEnter.Text = "Enter";
			BtnEnter.UseVisualStyleBackColor = true;
			BtnEnter.Click += BtnEnter_Click;
			// 
			// Authorization
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPassword);
			Controls.Add(tbLogin);
			Controls.Add(lblStatus);
			Controls.Add(BtnEnter);
			Name = "Authorization";
			Text = "Authorization";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox tbPassword;
		private TextBox tbLogin;
		private Label lblStatus;
		private Button BtnEnter;
	}
}

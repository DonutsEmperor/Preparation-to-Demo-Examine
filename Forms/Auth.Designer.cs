namespace DemoExam
{
	partial class Auth
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
			BtnEnter = new Button();
			LblStatus = new Label();
			tbLogin = new TextBox();
			tbPassword = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// BtnEnter
			// 
			BtnEnter.Location = new Point(264, 319);
			BtnEnter.Name = "BtnEnter";
			BtnEnter.Size = new Size(139, 44);
			BtnEnter.TabIndex = 0;
			BtnEnter.Text = "Enter";
			BtnEnter.UseVisualStyleBackColor = true;
			BtnEnter.Click += BtnEnter_Click;
			// 
			// LblStatus
			// 
			LblStatus.AutoSize = true;
			LblStatus.Location = new Point(307, 301);
			LblStatus.Name = "LblStatus";
			LblStatus.Size = new Size(39, 15);
			LblStatus.TabIndex = 1;
			LblStatus.Text = "Status";
			// 
			// tbLogin
			// 
			tbLogin.Font = new Font("Segoe UI", 11.25F);
			tbLogin.Location = new Point(175, 195);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(306, 27);
			tbLogin.TabIndex = 2;
			// 
			// tbPassword
			// 
			tbPassword.Font = new Font("Segoe UI", 11.25F);
			tbPassword.Location = new Point(175, 258);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(306, 27);
			tbPassword.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(309, 177);
			label1.Name = "label1";
			label1.Size = new Size(37, 15);
			label1.TabIndex = 4;
			label1.Text = "Login";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(307, 230);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 5;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(198, 86);
			label3.Name = "label3";
			label3.Size = new Size(261, 37);
			label3.TabIndex = 6;
			label3.Text = "OOO \"ЛАПКА\" Store";
			// 
			// Auth
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPassword);
			Controls.Add(tbLogin);
			Controls.Add(LblStatus);
			Controls.Add(BtnEnter);
			Name = "Auth";
			Text = "AuthWindow";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button BtnEnter;
		private Label LblStatus;
		private TextBox tbLogin;
		private TextBox tbPassword;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}

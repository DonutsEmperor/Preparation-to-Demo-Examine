namespace DemoExam
{
	partial class DataGridForm
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
			generalDataGrid = new DataGridView();
			BtnSave = new Button();
			cbTables = new ComboBox();
			((System.ComponentModel.ISupportInitialize)generalDataGrid).BeginInit();
			SuspendLayout();
			// 
			// generalDataGrid
			// 
			generalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			generalDataGrid.Location = new Point(22, 16);
			generalDataGrid.Name = "generalDataGrid";
			generalDataGrid.Size = new Size(766, 384);
			generalDataGrid.TabIndex = 0;
			// 
			// BtnSave
			// 
			BtnSave.Location = new Point(30, 413);
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(75, 23);
			BtnSave.TabIndex = 1;
			BtnSave.Text = "Save";
			BtnSave.UseVisualStyleBackColor = true;
			BtnSave.Click += BtnSave_Click;
			// 
			// cbTables
			// 
			cbTables.FormattingEnabled = true;
			cbTables.Location = new Point(149, 415);
			cbTables.Name = "cbTables";
			cbTables.Size = new Size(121, 23);
			cbTables.TabIndex = 2;
			cbTables.SelectedValueChanged += cbTables_SelectedValueChanged;
			// 
			// DataGridForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(cbTables);
			Controls.Add(BtnSave);
			Controls.Add(generalDataGrid);
			Name = "DataGridForm";
			Text = "DataGridForm";
			((System.ComponentModel.ISupportInitialize)generalDataGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView generalDataGrid;
		private Button BtnSave;
		private ComboBox cbTables;
	}
}
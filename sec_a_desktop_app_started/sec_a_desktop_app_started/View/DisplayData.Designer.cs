namespace sec_a_desktop_app_started
{
	partial class DisplayData
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
			dataGridView1 = new DataGridView();
			btnDelete = new Button();
			btnExit = new Button();
			btnDeleteAll = new Button();
			menuStrip1 = new MenuStrip();
			registerPageToolStripMenuItem = new ToolStripMenuItem();
			btnEdit = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(0, 52);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(800, 292);
			dataGridView1.TabIndex = 0;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Segoe UI", 22.2F);
			btnDelete.ForeColor = Color.FromArgb(0, 192, 0);
			btnDelete.Location = new Point(205, 358);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(136, 65);
			btnDelete.TabIndex = 1;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Segoe UI", 22.2F);
			btnExit.ForeColor = Color.Red;
			btnExit.Location = new Point(638, 358);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(136, 65);
			btnExit.TabIndex = 2;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// btnDeleteAll
			// 
			btnDeleteAll.AutoEllipsis = true;
			btnDeleteAll.Font = new Font("Segoe UI", 22.2F);
			btnDeleteAll.ForeColor = Color.Red;
			btnDeleteAll.Location = new Point(384, 358);
			btnDeleteAll.Name = "btnDeleteAll";
			btnDeleteAll.Size = new Size(207, 65);
			btnDeleteAll.TabIndex = 3;
			btnDeleteAll.Text = "Delete ALL";
			btnDeleteAll.UseVisualStyleBackColor = true;
			btnDeleteAll.Click += btnDeleteAll_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { registerPageToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 49);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// registerPageToolStripMenuItem
			// 
			registerPageToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			registerPageToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
			registerPageToolStripMenuItem.Name = "registerPageToolStripMenuItem";
			registerPageToolStripMenuItem.Size = new Size(281, 45);
			registerPageToolStripMenuItem.Text = "Registration Page";
			registerPageToolStripMenuItem.Click += registerPageToolStripMenuItem_Click;
			// 
			// btnEdit
			// 
			btnEdit.Font = new Font("Segoe UI", 22.2F);
			btnEdit.ForeColor = Color.FromArgb(0, 192, 0);
			btnEdit.Location = new Point(33, 358);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(136, 65);
			btnEdit.TabIndex = 5;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click_1;
			// 
			// DisplayData
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnEdit);
			Controls.Add(btnDeleteAll);
			Controls.Add(btnExit);
			Controls.Add(btnDelete);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.None;
			MainMenuStrip = menuStrip1;
			Name = "DisplayData";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DisplayData";
			Load += DisplayData_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnDelete;
		private Button btnExit;
		private Button btnDeleteAll;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem registerPageToolStripMenuItem;
		private Button btnEdit;
	}
}
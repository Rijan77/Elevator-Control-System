namespace sec_a_desktop_app_started
{
	partial class Register
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
			txtName = new TextBox();
			txtPhone = new TextBox();
			radMale = new RadioButton();
			countries = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			radFemale = new RadioButton();
			label4 = new Label();
			panel1 = new Panel();
			label5 = new Label();
			btnSave = new Button();
			btnClear = new Button();
			label6 = new Label();
			txtID = new TextBox();
			menuStrip1 = new MenuStrip();
			registerToolStripMenuItem = new ToolStripMenuItem();
			resultsToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			panel1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// txtName
			// 
			txtName.Location = new Point(161, 211);
			txtName.Name = "txtName";
			txtName.Size = new Size(224, 27);
			txtName.TabIndex = 0;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(555, 211);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(205, 27);
			txtPhone.TabIndex = 1;
			// 
			// radMale
			// 
			radMale.AutoSize = true;
			radMale.Font = new Font("Segoe UI", 12F);
			radMale.Location = new Point(160, 294);
			radMale.Name = "radMale";
			radMale.Size = new Size(76, 32);
			radMale.TabIndex = 2;
			radMale.TabStop = true;
			radMale.Text = "Male";
			radMale.UseVisualStyleBackColor = true;
			// 
			// countries
			// 
			countries.FormattingEnabled = true;
			countries.Location = new Point(555, 294);
			countries.Name = "countries";
			countries.Size = new Size(205, 28);
			countries.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F);
			label1.Location = new Point(26, 197);
			label1.Name = "label1";
			label1.Size = new Size(97, 41);
			label1.TabIndex = 4;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 18F);
			label2.Location = new Point(422, 200);
			label2.Name = "label2";
			label2.Size = new Size(103, 41);
			label2.TabIndex = 5;
			label2.Text = "Phone";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 18F);
			label3.Location = new Point(26, 285);
			label3.Name = "label3";
			label3.Size = new Size(116, 41);
			label3.TabIndex = 6;
			label3.Text = "Gender";
			// 
			// radFemale
			// 
			radFemale.AutoSize = true;
			radFemale.Font = new Font("Segoe UI", 12F);
			radFemale.Location = new Point(248, 294);
			radFemale.Name = "radFemale";
			radFemale.Size = new Size(95, 32);
			radFemale.TabIndex = 7;
			radFemale.TabStop = true;
			radFemale.Text = "Female";
			radFemale.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F);
			label4.Location = new Point(422, 285);
			label4.Name = "label4";
			label4.Size = new Size(124, 41);
			label4.TabIndex = 8;
			label4.Text = "Country";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(label5);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 36);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 87);
			panel1.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Lucida Handwriting", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(180, 20);
			label5.Name = "label5";
			label5.Size = new Size(448, 48);
			label5.TabIndex = 10;
			label5.Text = "USER REGISTRATION";
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 16.2F);
			btnSave.ForeColor = Color.DarkOliveGreen;
			btnSave.Location = new Point(143, 373);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(186, 53);
			btnSave.TabIndex = 10;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnClear
			// 
			btnClear.Font = new Font("Segoe UI", 16.2F);
			btnClear.Location = new Point(432, 373);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(186, 53);
			btnClear.TabIndex = 11;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 18F);
			label6.Location = new Point(26, 131);
			label6.Name = "label6";
			label6.Size = new Size(47, 41);
			label6.TabIndex = 12;
			label6.Text = "ID";
			// 
			// txtID
			// 
			txtID.Location = new Point(160, 139);
			txtID.Name = "txtID";
			txtID.ReadOnly = true;
			txtID.Size = new Size(224, 27);
			txtID.TabIndex = 13;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, exitToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 36);
			menuStrip1.TabIndex = 14;
			menuStrip1.Text = "menuStrip1";
			// 
			// registerToolStripMenuItem
			// 
			registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resultsToolStripMenuItem });
			registerToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			registerToolStripMenuItem.ForeColor = Color.DimGray;
			registerToolStripMenuItem.Name = "registerToolStripMenuItem";
			registerToolStripMenuItem.Size = new Size(80, 32);
			registerToolStripMenuItem.Text = "Menu";
			// 
			// resultsToolStripMenuItem
			// 
			resultsToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			resultsToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
			resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
			resultsToolStripMenuItem.Size = new Size(224, 28);
			resultsToolStripMenuItem.Text = "Results";
			resultsToolStripMenuItem.Click += resultsToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
			exitToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			exitToolStripMenuItem.ForeColor = Color.Red;
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.RightToLeft = RightToLeft.No;
			exitToolStripMenuItem.Size = new Size(62, 32);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveBorder;
			ClientSize = new Size(800, 450);
			Controls.Add(txtID);
			Controls.Add(label6);
			Controls.Add(btnClear);
			Controls.Add(btnSave);
			Controls.Add(panel1);
			Controls.Add(label4);
			Controls.Add(radFemale);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(countries);
			Controls.Add(radMale);
			Controls.Add(txtPhone);
			Controls.Add(txtName);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.None;
			MainMenuStrip = menuStrip1;
			Name = "Register";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Register";
			Load += Register_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtName;
		private TextBox txtPhone;
		private RadioButton radMale;
		private ComboBox countries;
		private Label label1;
		private Label label2;
		private Label label3;
		private RadioButton radFemale;
		private Label label4;
		private Panel panel1;
		private Label label5;
		private Button btnSave;
		private Button btnClear;
		private Label label6;
		private TextBox txtID;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem registerToolStripMenuItem;
		private ToolStripMenuItem resultsToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
	}
}
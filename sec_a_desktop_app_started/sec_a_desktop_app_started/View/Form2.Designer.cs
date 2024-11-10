namespace sec_a_desktop_app_started.View
{
	partial class Form2
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
			panel1 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			btnLift = new Button();
			panel2 = new Panel();
			btnDown = new Button();
			btnUp = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 450);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(panel4);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(550, 450);
			panel3.TabIndex = 1;
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.Fixed3D;
			panel4.Controls.Add(btnLift);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(550, 450);
			panel4.TabIndex = 0;
			// 
			// btnLift
			// 
			btnLift.Location = new Point(221, 70);
			btnLift.Name = "btnLift";
			btnLift.Size = new Size(94, 113);
			btnLift.TabIndex = 0;
			btnLift.Text = "LIFT";
			btnLift.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnDown);
			panel2.Controls.Add(btnUp);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(550, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(250, 450);
			panel2.TabIndex = 0;
			// 
			// btnDown
			// 
			btnDown.Location = new Point(65, 333);
			btnDown.Name = "btnDown";
			btnDown.Size = new Size(124, 44);
			btnDown.TabIndex = 2;
			btnDown.Text = "DOWN";
			btnDown.UseVisualStyleBackColor = true;
			btnDown.Click += btnDown_Click;
			// 
			// btnUp
			// 
			btnUp.Location = new Point(65, 229);
			btnUp.Name = "btnUp";
			btnUp.Size = new Size(124, 44);
			btnUp.TabIndex = 1;
			btnUp.Text = "UP";
			btnUp.UseVisualStyleBackColor = true;
			btnUp.Click += btnUp_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Name = "Form2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form2";
			Load += Form2_Load;
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private Panel panel4;
		private Button btnLift;
		private Panel panel2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button btnDown;
		private Button btnUp;
	}
}
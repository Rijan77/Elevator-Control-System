namespace sec_a_desktop_app_started.View
{
	partial class Form1
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
			btn1 = new Button();
			btn2 = new Button();
			panel2 = new Panel();
			btnStop = new Button();
			btnStart = new Button();
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
			panel3.Paint += Form1_Paint;
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.Fixed3D;
			panel4.Controls.Add(btn1);
			panel4.Controls.Add(btn2);
			panel4.Dock = DockStyle.Bottom;
			panel4.Location = new Point(0, 192);
			panel4.Name = "panel4";
			panel4.Size = new Size(550, 258);
			panel4.TabIndex = 4;
			// 
			// btn1
			// 
			btn1.Location = new Point(109, 35);
			btn1.Name = "btn1";
			btn1.Size = new Size(94, 187);
			btn1.TabIndex = 2;
			btn1.Text = "D1";
			btn1.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			btn2.Location = new Point(347, 35);
			btn2.Name = "btn2";
			btn2.Size = new Size(94, 187);
			btn2.TabIndex = 3;
			btn2.Text = "D2";
			btn2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnStop);
			panel2.Controls.Add(btnStart);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(550, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(250, 450);
			panel2.TabIndex = 0;
			// 
			// btnStop
			// 
			btnStop.Location = new Point(75, 274);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(94, 29);
			btnStop.TabIndex = 1;
			btnStop.Text = "Open";
			btnStop.UseVisualStyleBackColor = true;
			btnStop.Click += btnStop_Click;
			// 
			// btnStart
			// 
			btnStart.Location = new Point(75, 192);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(94, 29);
			btnStart.TabIndex = 0;
			btnStart.Text = "Close";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Paint += Form1_Paint;
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private Panel panel2;
		private Button btnStop;
		private Button btnStart;
		private Button btn2;
		private Button btn1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Panel panel4;
	}
}
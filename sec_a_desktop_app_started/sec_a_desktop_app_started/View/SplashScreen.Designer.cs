namespace sec_a_desktop_app_started.View
{
	partial class SplashScreen
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
			components = new System.ComponentModel.Container();
			progressBar = new ProgressBar();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			loading = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// progressBar
			// 
			progressBar.Dock = DockStyle.Bottom;
			progressBar.Location = new Point(0, 364);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(837, 57);
			progressBar.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(208, 37);
			label1.Name = "label1";
			label1.Size = new Size(375, 69);
			label1.TabIndex = 1;
			label1.Text = "Welcome To";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Courier New", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(37, 124);
			label2.Name = "label2";
			label2.Size = new Size(757, 85);
			label2.TabIndex = 2;
			label2.Text = "Simple CRUD App";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(256, 247);
			label3.Name = "label3";
			label3.Size = new Size(192, 42);
			label3.TabIndex = 3;
			label3.Text = "Loading : ";
			// 
			// loading
			// 
			loading.AutoSize = true;
			loading.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold);
			loading.ForeColor = Color.Gray;
			loading.Location = new Point(437, 248);
			loading.Name = "loading";
			loading.Size = new Size(74, 42);
			loading.TabIndex = 4;
			loading.Text = "0%";
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// SplashScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(837, 421);
			Controls.Add(loading);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(progressBar);
			FormBorderStyle = FormBorderStyle.None;
			Name = "SplashScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SplashScreen";
			Load += SplashScreen_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ProgressBar progressBar;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label loading;
		private System.Windows.Forms.Timer timer1;
	}
}
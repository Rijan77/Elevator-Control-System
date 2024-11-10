namespace sec_a_desktop_app_started.View
{
	partial class Form3
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
			btnStart = new Button();
			btnStop = new Button();
			progressBar1 = new ProgressBar();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnStart
			// 
			btnStart.Location = new Point(205, 211);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(94, 29);
			btnStart.TabIndex = 0;
			btnStart.Text = "Start";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// btnStop
			// 
			btnStop.Location = new Point(353, 211);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(94, 29);
			btnStop.TabIndex = 1;
			btnStop.Text = "Stop";
			btnStop.UseVisualStyleBackColor = true;
			btnStop.Click += btnStop_Click;
			// 
			// progressBar1
			// 
			progressBar1.Dock = DockStyle.Bottom;
			progressBar1.Location = new Point(0, 381);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(800, 69);
			progressBar1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(323, 319);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 3;
			label1.Text = "label1";
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(progressBar1);
			Controls.Add(btnStop);
			Controls.Add(btnStart);
			Name = "Form3";
			Text = "Form3";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnStart;
		private Button btnStop;
		private ProgressBar progressBar1;
		private Label label1;
	}
}
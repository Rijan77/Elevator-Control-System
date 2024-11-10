using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec_a_desktop_app_started.View
{
	public partial class Form2 : Form
	{

		BackgroundWorker bgWorkerUp = new BackgroundWorker();   // For moving up
		BackgroundWorker bgWorkerDown = new BackgroundWorker(); // For moving down
		int liftSpeed = 10;  // Speed of the lift movement
		bool isMovingUp = true; // Flag to control movement direction
		bool isMovingDown = false;
		int liftTopY; // Starting Y position for the lift






		public Form2()
		{
			InitializeComponent();
			// Initialize background workers for lift movement
			bgWorkerUp.DoWork += BgWorkerUp_DoWork;
			bgWorkerUp.WorkerReportsProgress = true;
			bgWorkerUp.ProgressChanged += BgWorker_ProgressChanged;

			bgWorkerDown.DoWork += BgWorkerDown_DoWork;
			bgWorkerDown.WorkerReportsProgress = true;
			bgWorkerDown.ProgressChanged += BgWorker_ProgressChanged;

			// Set the initial Y position of the lift (assuming it's at the bottom)
			liftTopY = panel3.Height - btnLift.Height - 10;
			//liftTopY = panel3.Height;
			//liftTopY = panel3.Height / 2 - btnLift.Width;


			btnLift.Location = new System.Drawing.Point(btnLift.Location.X, liftTopY);
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			if (isMovingDown is false)
			{
				if (!bgWorkerUp.IsBusy)
				{
					isMovingUp = true;
					bgWorkerUp.RunWorkerAsync();

				}
			}
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			if (isMovingUp is false)
			{
				if (!bgWorkerDown.IsBusy)
				{
					isMovingUp = false;
					isMovingDown = true;
					bgWorkerDown.RunWorkerAsync();
				}
			}
		}

		// Logic for moving the lift up
		private void BgWorkerUp_DoWork(object sender, DoWorkEventArgs e)
		{
			int liftY = btnLift.Location.Y;

			// Move the lift up until it reaches the top
			while (liftY > 10) // 10 represents the top margin
			{
				liftY -= liftSpeed; // Move the lift up
				bgWorkerUp.ReportProgress(0, liftY);
				System.Threading.Thread.Sleep(50); // Control the speed
			}

			isMovingUp = false;
		}

		// Logic for moving the lift down
		private void BgWorkerDown_DoWork(object sender, DoWorkEventArgs e)
		{
			int liftY = btnLift.Location.Y;

			// Move the lift down until it reaches the bottom
			while (liftY < panel4.Height - btnLift.Height - 10) // Bottom margin
			{
				liftY += liftSpeed; // Move the lift down
				bgWorkerDown.ReportProgress(0, liftY);
				System.Threading.Thread.Sleep(50); // Control the speed
			}
			isMovingDown = false;
		}

		// Update lift position during movement (for both up and down)
		private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			int liftY = (int)e.UserState;
			btnLift.Location = new System.Drawing.Point(btnLift.Location.X, liftY);
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}

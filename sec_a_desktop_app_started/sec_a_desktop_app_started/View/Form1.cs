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
	public partial class Form1 : Form
	{
		BackgroundWorker bgWorker = new BackgroundWorker();
		bool isClosing = true; // This flag will control whether we're opening or closing
		int btn1StartX, btn2StartX;
		public Form1()
		{
			InitializeComponent();
			bgWorker.DoWork += BgWorker_DoWork;
			bgWorker.WorkerReportsProgress = true;
			bgWorker.ProgressChanged += BgWorker_ProgressChanged;


			// Set initial positions close together (like a closed door)

			btn1StartX = panel4.Width / 2 - btn1.Width - 50; // Start near the center
			btn2StartX = panel4.Width / 2 + 50; // Start near the center

			btn1.Location = new System.Drawing.Point(btn1StartX, btn1.Location.Y);
			btn2.Location = new System.Drawing.Point(btn2StartX, btn2.Location.Y);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//// Code goes here

			//Color red = Color.FromArgb(255, 255, 0, 0);
			//Pen redPen = new Pen(red);
			//redPen.Width = 5;
			//e.Graphics.DrawRectangle(redPen, 10, 10, 20, 20);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!bgWorker.IsBusy)
			{
				bgWorker.RunWorkerAsync();
			}
		}


		private void btnStop_Click(object sender, EventArgs e)
		{
			if (!bgWorker.IsBusy)
			{
				isClosing = false; // Set the flag for opening
				bgWorker.RunWorkerAsync();
			}
		}

		// Logic for moving the buttons (either opening or closing)
		private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			int btn1X = btn1.Location.X;
			int btn2X = btn2.Location.X;

			if (isClosing)
			{
				// Close the door (move buttons together)
				while (btn1X < btn2X - btn1.Width)
				{
					btn1X += 2;  // Move btn1 to the right
					btn2X -= 2;  // Move btn2 to the left
					bgWorker.ReportProgress(0, new Tuple<int, int>(btn1X, btn2X));
					System.Threading.Thread.Sleep(50);
				}
			}
			else
			{
				// Open the door (move buttons apart)
				while (btn1X > 10 && btn2X < panel4.Width - btn2.Width - 10)
				{
					btn1X -= 2;  // Move btn1 to the left
					btn2X += 2;  // Move btn2 to the right
					bgWorker.ReportProgress(0, new Tuple<int, int>(btn1X, btn2X));
					System.Threading.Thread.Sleep(50);
				}
			}
		}

		// Update UI during movement (for both opening and closing)
		private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var positions = (Tuple<int, int>)e.UserState;
			btn1.Location = new System.Drawing.Point(positions.Item1, btn1.Location.Y);
			btn2.Location = new System.Drawing.Point(positions.Item2, btn2.Location.Y);
		}
	}
}

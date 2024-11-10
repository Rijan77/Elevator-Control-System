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
	
	public partial class Form3 : Form
	{
		BackgroundWorker backgroundWorker;
		public Form3()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			backgroundWorker = new BackgroundWorker();

			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.WorkerReportsProgress = true;

			backgroundWorker.DoWork += backgroundWorker1_DoWork;
			backgroundWorker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
			backgroundWorker.ProgressChanged += BGWorker_ProgressChanged;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if(!backgroundWorker.IsBusy)
			{
				backgroundWorker.RunWorkerAsync(100);
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			if(backgroundWorker.IsBusy)
			{
				backgroundWorker.CancelAsync();
			}
		}

		

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker helperBW = sender as BackgroundWorker;
			int arg = (int)e.Argument;
			int percentage;
			string message = "BackgroundWorker is Running!!!";
			MessageBox.Show("I am doing some work in the background.");

			for(int i=0;i<arg;i++)
			{
				Thread.Sleep(100);
				percentage = (i + 1) * 100 / arg;
				helperBW.ReportProgress(percentage,message);

				if(helperBW.CancellationPending)
				{
					e.Cancel = true;
					e.Result = i;
					break;
				}
			}
			e.Result = arg;
		}

		private void BGWorker_ProgressChanged(object sender,  ProgressChangedEventArgs e)
		{
			this.progressBar1.Value = e.ProgressPercentage;
			this.label1.Text = e.UserState.ToString();
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender,  RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled) MessageBox.Show("Operation was canceled");
			else if (e.Error != null) MessageBox.Show(e.Error.Message);
			else MessageBox.Show(e.Result.ToString());
			this.label1.Text = "backgroundWorker is Not in use";
		}
	}
}

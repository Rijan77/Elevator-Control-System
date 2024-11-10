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
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar.Value < 100)
			{
				progressBar.Value += 1;
				loading.Text = progressBar.Value.ToString() + "%";
				if (loading.Text == "100%")
				{
					Register reg = new Register();
					reg.Show();
					this.Hide();
				}
			}
			else
			{
				timer1.Stop();
			}
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}

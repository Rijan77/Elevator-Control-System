using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sec_a_desktop_app_started.Controller;
using sec_a_desktop_app_started.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace sec_a_desktop_app_started
{
	public partial class Register : Form
	{
		BackgroundWorker worker;
		static bool isUpdate = false;
		DBContext dbContext;// = new DBContext();
		UserRepository userRepository;
		ConnectionString connectionString = new ConnectionString();
		private readonly User _user;
		public Register()
		{
			InitializeComponent();
			worker = new BackgroundWorker();
			worker.WorkerSupportsCancellation = true;
			worker.DoWork += BackgroundWorker1_DoWork;
			worker.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
		}


		public Register(User user)
		{
			InitializeComponent();
			_user = user;
			isUpdate = true;

			// Populate the textboxes with user data
			txtID.Text = _user.Id;
			txtName.Text = _user.Name;
			txtPhone.Text = _user.Phone;
			if (_user.Gender == "True")
			{
				radMale.Checked = true;
			}
			else
			{
				radFemale.Checked = true;
			}
		}


		private void btnClear_Click(object sender, EventArgs e)
		{
			clear();
		}

		private void Register_Load(object sender, EventArgs e)
		{
			//var res = worker.IsBusy;
			//if (worker.IsBusy == null)
			//{
			//	worker.CancelAsync();

			//}

			List<string> lst = new List<string>() { "Select your country!!!", "Nepal", "India", "China" };
			countries.DataSource = lst;

			// If this is an update scenario, select the country from the user object
			if (isUpdate)
			{
				if (!string.IsNullOrEmpty(_user.Country) && lst.Contains(_user.Country))
				{
					// Set the selected item based on the user's country
					countries.SelectedItem = _user.Country;
				}
			}
			else
			{
				// Set a default value for new registrations
				countries.SelectedItem = "Select your country!!!";

				dbContext = new DBContext();
				string query = @"select max(id) from dbo.users_1";
				int id = dbContext.GetID(query);

				txtID.Text = id.ToString();
			}


		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			dbContext = new DBContext();
			int id = int.Parse(txtID.Text);
			int gender;
			var name = txtName.Text;
			var phone = Convert.ToInt64(txtPhone.Text);
			if (radMale.Checked == true)
			{
				gender = 1;
			}
			else
			{
				gender = 0;

			}

			var country = countries.SelectedValue;

			User newUser = new User
			{
				Id = id.ToString(),
				Name = name,
				Phone = phone.ToString(),
				Gender = gender.ToString(),
				Country = country.ToString()
			};


			try
			{
				var conn = connectionString.getConn();
				userRepository = new UserRepository(conn);
				if (isUpdate is false)
				{

					userRepository.Insert(newUser);
					MessageBox.Show("Registered User: " + name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					clear();
					txtID.Text = (int.Parse(txtID.Text) + 1).ToString();
				}
				else
				{
					userRepository.Update(newUser);
					MessageBox.Show("Records Update for UserID: " + id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					clear();
					string latest_id_query = @"select max(id) from dbo.users_1";
					int latest_id = dbContext.GetID(latest_id_query);

					txtID.Text = latest_id.ToString();

					isUpdate = false;

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}


		private void clear()
		{
			txtName.Text = "";
			txtPhone.Text = "";
			radFemale.Checked = false;
			radMale.Checked = false;
			countries.Text = "Select your country!!!";
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			DisplayData d = new DisplayData();
			//this.Hide();
			Thread.Sleep(10000);
			d.ShowDialog();
		}

		private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			// Set the worker to null to indicate completion
			worker.CancelAsync();
		}
		private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//DisplayData d = new DisplayData();
			//d.Show();
			//this.Hide();
			if (!worker.IsBusy)
			{
				worker.RunWorkerAsync();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}

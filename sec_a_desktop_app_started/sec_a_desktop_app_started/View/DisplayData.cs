using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	public partial class DisplayData : Form
	{
		DBContext dbContext;
		UserRepository userRepository;
		ConnectionString connectionString = new ConnectionString();
		private User _selectedUser;

		public DisplayData()
		{
			InitializeComponent();
		}

		private void DisplayData_Load(object sender, EventArgs e)
		{
			//dbContext = new DBContext();
			dataGridView1.ReadOnly = true;

			LoadData();

			// Attach the CellClick event handler
			dataGridView1.CellClick += dataGridView1_CellClick;

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex >= 0) // Ensure a valid row is clicked
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				// Create a user object with the selected row data
				_selectedUser = new User
				{
					Id = row.Cells["Id"].Value.ToString(),
					Name = row.Cells["Name"].Value.ToString(),
					Phone = row.Cells["Phone"].Value.ToString(),
					Gender = row.Cells["Gender"].Value.ToString(),
					Country = row.Cells["Country"].Value.ToString()
				};
			}
		}


		private void btnEdit_Click_1(object sender, EventArgs e)
		{
			if (_selectedUser != null)
			{
				try
				{
					// Open the edit form and pass the selected user data
					Register reg = new Register(_selectedUser);
					reg.ShowDialog(); // Show the EditForm as a dialog
					this.Hide();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else
			{
				//MessageBox.Show("Please select a user first.");
				MessageBox.Show("Please select a row before attempting to Edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_selectedUser != null)
			{
				// Show a confirmation dialog before deletion
				DialogResult confirmResult = MessageBox.Show(
					$"Are you sure you want to delete the user '{_selectedUser.Name}'?",
					"Confirm Delete",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning
				);

				// If user clicks 'Yes', delete the user
				if (confirmResult == DialogResult.Yes)
				{
					try
					{
						var conn = connectionString.getConn();
						userRepository = new UserRepository(conn);
						userRepository.DeleteById(_selectedUser.Id); // Delete the selected user
						MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						_selectedUser = null; // Reset the selected user after deletion
						LoadData();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row before attempting to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			dbContext = new DBContext();
			var conn = connectionString.getConn();
			userRepository = new UserRepository(conn);
			// Check if there are any rows to delete
			if (dataGridView1.Rows.Count > 0)
			{
				// Confirm the action with the user
				var confirmResult = MessageBox.Show(
					"Are you sure you want to delete **all** records? This action cannot be undone.",
					"Confirm Delete All",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button2);

				if (confirmResult == DialogResult.Yes)
				{

					try
					{
						// Clear all rows from the DataGridView
						userRepository.DeleteAll();

						LoadData();

						// Show a success message with an Information icon
						MessageBox.Show(
							"All records have been successfully deleted.",
							"Records Deleted",
							MessageBoxButtons.OK,
							MessageBoxIcon.Information); // Success message with checkmark icon
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}

				else
				{
					// If no rows are present, show an information message
					MessageBox.Show(
						"There are no records to delete.",
						"No Records",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information); // Inform the user with "i" icon
				}
			}
		}


		private void registerPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Register r = new Register();
			r.Show();
			this.Close();
		}


		private void LoadData()
		{
			var conn = connectionString.getConn();
			userRepository = new UserRepository(conn);

			try
			{
				// Retrieve fresh data
				var results = userRepository.GetAll();

				// Clear existing data before binding new data
				dataGridView1.DataSource = null; // Clear existing binding
				dataGridView1.Rows.Clear(); // Clear rows if any

				// Bind data to the DataGridView
				dataGridView1.DataSource = results;
			}
			catch (Exception ex)
			{
				// Handle exceptions
				Console.WriteLine(ex.Message);
			}
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}



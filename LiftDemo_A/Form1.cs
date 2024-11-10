using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LiftDemo_A
{
    public partial class Form1 : Form
    {
        bool isClosing = false;
        bool isOpening = false;

        int doorMaxOpenWidth;
        int doorSpeed = 5;
        int liftSpeed = 5;

        private Lift lift;
        DataTable dt = new DataTable();
        DBContext dbContext = new DBContext();

        public Form1()
        {
            InitializeComponent();


            lift = new Lift(mainElevator, btn_1, btn_G, btnCall1, btnCall2, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown, openDoorTimer, closeDoorTimer, autoDoorTimer, this);

            doorMaxOpenWidth = mainElevator.Width / 2 + 80;

            dataGridViewLogs.ColumnCount = 2;
            dataGridViewLogs.Columns[0].Name = "Time";
            dataGridViewLogs.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");

            autoDoorTimer.Interval = 1000; // Set delay to as needed
            autoDoorTimer.Tick += autoDoorTimer_Tick;
        }

        public void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            dt.Rows.Add(currentTime, message);
            dataGridViewLogs.Rows.Add(currentTime, message);

            dbContext.InsertLogsIntoDB(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext.loadLogsFromDB(dt, dataGridViewLogs);
        }

        // Method to update the floor display
        public void UpdateFloorDisplay(int floor)
        {
            lblFloorDisplay.Text = floor.ToString();
        }

        public void btn_1_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            btn_1.BackColor = Color.LightGreen;
            btnCall1.BackColor = Color.White;
            btnCall1.Enabled = false;
            lift.LiftTimerUp.Start();
            btn_G.Enabled = false;
            logEvents("Lift is going up!");
        }

        public void btn_G_click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            btn_G.BackColor = Color.LightGreen;
            btnCall2.BackColor = Color.White;
            btnCall2.Enabled = false;
            btn_1.Enabled = false;
            lift.LiftTimerDown.Start();
            logEvents("Lift is going down!");
        }

        public void liftTimerUp_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
        {
            lift.MovingDown();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            btn_Close.Enabled = false;
            btn_Open.BackColor = Color.LightGreen;
            btn_Close.BackColor = Color.White;
            lift.SetState(new OpenDoorState());
            openDoorTimer.Start();
            logEvents("Lift door opening...");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            btn_Open.BackColor = Color.White;
            isOpening = false;
            isClosing = true;
            btn_Open.Enabled = false;
            btn_Close.BackColor = Color.LightGreen;
            lift.SetState(new CloseDoorState());
            closeDoorTimer.Start();
            logEvents("Lift door closing...");
        }

        private void closeDoorTimer_Tick(object sender, EventArgs e)
        {
            lift.CloseDoor();
        }

        private void openDoorTimer_Tick(object sender, EventArgs e)
        {
            lift.OpenDoor();
        }

        private void btnCall2_Click(object sender, EventArgs e)
        {
            btnCall1.BackColor = Color.White;
            lift.SetState(new MovingUpState());
            btnCall2.BackColor = Color.LightGreen;
            lift.LiftTimerUp.Start();
           

        }

        private void btnCall1_Click(object sender, EventArgs e)
        {
            btnCall2.BackColor = Color.White;
            lift.SetState(new MovingDownState());
            btnCall1.BackColor = Color.LightGreen;
            lift.LiftTimerDown.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete all logs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                // Delete all logs from the database
                dbContext.DeleteAllLogs();

                // Clear the DataTable and DataGridView
                dt.Rows.Clear();
                dataGridViewLogs.Rows.Clear();

                MessageBox.Show("All logs have been deleted");
            }
            else
            {
                // If the user clicked "No", cancel the deletion
                MessageBox.Show("Deletion canceled.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autoDoorTimer_Tick(object sender, EventArgs e)
        {
            autoDoorTimer.Stop();

            // Only close if the lift is idle and the door is currently open
            if (btn_Close.Enabled && lift._CurrentState is IdleState)
            {
                isOpening = false;
                isClosing = true;
                btn_Open.Enabled = false;
                btn_Close.BackColor = Color.LightGreen;
                btn_Open.BackColor = Color.White;
                lift.SetState(new CloseDoorState());
                closeDoorTimer.Start();
                logEvents("Lift door closing automatically...");
            }
        }
    }
}

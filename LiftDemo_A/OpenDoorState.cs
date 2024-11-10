using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiftDemo_A
{
    internal class OpenDoorState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }

        public void CloseDoor(Lift lift)
        {
            /* Do Nothing */
        }

        public void OpenDoor(Lift lift)
        {
            // Get the Form instance
            Form1 form = lift.MainElevator.FindForm() as Form1;
            if (form == null) return;

            // Find the necessary controls
            PictureBox doorLeft_G = form.Controls.Find("doorLeft_G", true)[0] as PictureBox;
            PictureBox doorRight_G = form.Controls.Find("doorRight_G", true)[0] as PictureBox;
            PictureBox doorLeft_1 = form.Controls.Find("doorLeft_1", true)[0] as PictureBox;
            PictureBox doorRight_1 = form.Controls.Find("doorRight_1", true)[0] as PictureBox;
            Button btn_Close = form.Controls.Find("btn_Close", true)[0] as Button;

            // Calculate door parameters
            int doorMaxOpenWidth = lift.MainElevator.Width / 2 + 80;
            int doorSpeed = 5;
            bool doorsFullyOpen = false;

            if (lift.MainElevator.Top != 80)  // Ground floor
            {
                if (doorLeft_G.Left > doorMaxOpenWidth / 2)
                {
                    doorLeft_G.Left -= doorSpeed;
                    doorRight_G.Left += doorSpeed;

                }
                else
                {
                    doorsFullyOpen = true;

                }
            }
            else  // First floor
            {
                if (doorLeft_1.Left > doorMaxOpenWidth / 2)
                {
                    doorLeft_1.Left -= doorSpeed;
                    doorRight_1.Left += doorSpeed;
                }
                else
                {
                    doorsFullyOpen = true;
                }
            }

            // Once doors are fully open, stop the timer and enable closing
            if (doorsFullyOpen)
            {
                lift.OpenDoorTimer.Stop();
                btn_Close.Enabled = true;
                lift.Btn_1.Enabled = false;
                lift.Btn_G.Enabled = false;
                lift.Btn_Call1.Enabled = false;
                lift.Btn_Call2.Enabled = false;

                // Log that doors have opened
                form.logEvents("Lift doors fully opened.");

                // Optionally set button color for visual feedback
                btn_Close.BackColor = Color.LightGreen;

                // Transition to IdleState or keep it open for automatic closing
                lift.SetState(new IdleState());
                lift.AutoDoorTimer.Start();  // Start auto-close timer
            }
        }
    }
}

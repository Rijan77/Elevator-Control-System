using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiftDemo_A
{
    internal class CloseDoorState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }

        public void OpenDoor(Lift lift)
        {
            /* Do Nothing */
        }

        public void CloseDoor(Lift lift)
        {
            // Get the Form instance
            Form1 form = lift.MainElevator.FindForm() as Form1;
            if (form == null) return;

            // Find the necessary controls
            PictureBox doorLeft_G = form.Controls.Find("doorLeft_G", true)[0] as PictureBox;
            PictureBox doorRight_G = form.Controls.Find("doorRight_G", true)[0] as PictureBox;
            PictureBox doorLeft_1 = form.Controls.Find("doorLeft_1", true)[0] as PictureBox;
            PictureBox doorRight_1 = form.Controls.Find("doorRight_1", true)[0] as PictureBox;
            Button btn_Open = form.Controls.Find("btn_Open", true)[0] as Button;
            Button btn_Close = form.Controls.Find("btn_Close", true)[0] as Button;

            // Calculate door parameters
            int doorMaxOpenWidth = lift.MainElevator.Width / 2 + 80;
            int doorSpeed = 5;
            bool doorsFullyClosed = false;

            if (lift.MainElevator.Top != 80) // Ground floor
            {
                if (doorLeft_G.Right < lift.MainElevator.Width + doorMaxOpenWidth / 2)
                {
                    doorLeft_G.Left += doorSpeed;
                    doorRight_G.Left -= doorSpeed;
                }
                else
                {
                    doorsFullyClosed = true;
                }
            }
            else // First floor
            {
                if (doorLeft_1.Right < lift.MainElevator.Width + doorMaxOpenWidth / 2)
                {
                    doorLeft_1.Left += doorSpeed;
                    doorRight_1.Left -= doorSpeed;
                }
                else
                {
                    doorsFullyClosed = true;
                }
            }

            // Once doors are fully closed, stop the timer and reset the state
            if (doorsFullyClosed)
            {
                lift.CloseDoorTimer.Stop();
                lift.SetState(new IdleState());
                lift.Btn_1.Enabled = true;
                lift.Btn_G.Enabled = true;
                lift.Btn_Call1.Enabled = true;
                lift.Btn_Call2.Enabled = true;


                // Enable and reset button colors
                btn_Open.Enabled = true;
                btn_Close.Enabled = false;
                btn_Open.BackColor = Color.White;
                btn_Close.BackColor = Color.White;

                // Log the event
                form.logEvents("Lift doors fully closed.");
            }
        }
    }
}

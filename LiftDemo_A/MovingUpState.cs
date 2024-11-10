using System;
using System.Drawing;

namespace LiftDemo_A
{
    internal class MovingUpState : ILiftState
    {
        public void MovingUp(Lift lift)
        {
            // Move the elevator up if it hasn't reached the top
            if (lift.MainElevator.Top > 80)
            {
                lift.MainElevator.Top -= lift.LiftSpeed;
            }
            else
            {
                // Reached the top floor
                lift.SetState(new IdleState());
                lift.MainElevator.Top = 80;
                lift.LiftTimerUp.Stop();

                // Reset button states and update floor display
                lift.Btn_G.BackColor = Color.White;
                lift.Btn_G.Enabled = true;
                lift.Btn_1.Enabled = true;
                lift.MainForm.UpdateFloorDisplay(2);

                // Log that the lift has reached the top
                lift.MainForm.logEvents("Lift reached 2nd floor. Doors opening...");

                // Start the door opening process
                lift.SetState(new OpenDoorState());
                lift.OpenDoorTimer.Start();

                // Start the auto door close timer
                lift.AutoDoorTimer.Start();
            }
        }

        // Define other state methods with no implementation
        public void MovingDown(Lift lift) { /* Do nothing */ }
        public void OpenDoor(Lift lift) { /* Do nothing */ }
        public void CloseDoor(Lift lift) { /* Do nothing */ }
    }
}

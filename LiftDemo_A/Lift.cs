using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
    internal class Lift
    {
        public ILiftState _CurrentState;

        public PictureBox MainElevator;
        public Button Btn_1;
        public Button Btn_G;
        public Button Btn_Call1;
        public Button Btn_Call2;
        public int FormSize;
        public int LiftSpeed;
        public Timer LiftTimerUp;
        public Timer LiftTimerDown;
        public Timer OpenDoorTimer;
        public Timer CloseDoorTimer;
        public Timer AutoDoorTimer;
        public Form1 MainForm;

        public Lift(PictureBox mainElevator, Button btn_1, Button btn_G, Button btnCall1, Button btnCall2, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown, Timer openDoorTimer, Timer closeDoorTimer, Timer autoDoorTimer, Form1 form)
        {
            MainElevator = mainElevator;
            Btn_1 = btn_1;
            Btn_G = btn_G;
            Btn_Call1 = btnCall1;
            Btn_Call2 = btnCall2;
            FormSize = formSize;
            LiftSpeed = liftSpeed;
            LiftTimerUp = liftTimerUp;
            LiftTimerDown = liftTimerDown;
            OpenDoorTimer = openDoorTimer;
            CloseDoorTimer = closeDoorTimer;
            AutoDoorTimer = autoDoorTimer;
            MainForm = form;

            // Set initial state as IdleState
            _CurrentState = new IdleState();
        }

        public void SetState(ILiftState state)
        {
            _CurrentState = state;
        }

        public void MovingUp()
        {
            _CurrentState.MovingUp(this);
        }

        public void MovingDown()
        {
            _CurrentState.MovingDown(this);
        }

        public void OpenDoor()
        {
            _CurrentState.OpenDoor(this);
        }

        public void CloseDoor()
        {
            _CurrentState.CloseDoor(this);
        }
    }
}

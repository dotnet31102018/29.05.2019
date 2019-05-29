using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2905etgar
{
    class ElevatorFloorManager
    {
        public event EventHandler TheFloorReached;

        public void OnTheFloorReached()
        {
            if (TheFloorReached != null)
            {
                TheFloorReached.Invoke(this, EventArgs.Empty);
            }
        }

        public void SendElevatorToFloor(Elevator elevator, int floor)
        {
            if (elevator.GoToFloor(floor))
            {
                Thread.Sleep(2000);
                this.OnTheFloorReached();
            }
        }
    }
}

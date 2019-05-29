using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2905etgar
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorFloorManager elevatorFM = new ElevatorFloorManager();
            Elevator elevator = new Elevator(ElevatorState.RESTING, 3);

            elevatorFM.TheFloorReached += elevator.TheFloorReachedEventHandler;

            elevatorFM.SendElevatorToFloor(elevator, 2);

        }
    }
}

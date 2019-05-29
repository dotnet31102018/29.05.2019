using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2905etgar
{
    class Elevator
    {
        ElevatorState _elevatorState;
        int _currentFloor;
        int _gotoFloor;

        
        public Elevator(ElevatorState elevatorState, int currentFloor)
        {
            _elevatorState = elevatorState;
            _currentFloor = currentFloor;
        }

        public bool GoToFloor(int newFloor)
        {
            bool IsOkElevatorState = false;
            switch (_elevatorState)
            {
                case ElevatorState.GOING_UP:
                    IsOkElevatorState = false;
                    break;
                case ElevatorState.GOING_DOWN:
                    IsOkElevatorState = false;
                    break;
                case ElevatorState.OPEN_DOORS:
                    IsOkElevatorState = false;
                    break;
                case ElevatorState.RESTING:
                    if (newFloor == _currentFloor)
                    {
                        _elevatorState = ElevatorState.OPEN_DOORS;
                    }
                    else if (newFloor > _currentFloor)
                    {
                        _elevatorState = ElevatorState.GOING_UP;
                    }
                    else if (newFloor<_currentFloor)
                    {
                        _elevatorState = ElevatorState.GOING_DOWN;
                    }
                    IsOkElevatorState = true;
                    break;
                default:
                    break;
            }
            _gotoFloor = newFloor;
            return IsOkElevatorState;
        }

        public void TheFloorReachedEventHandler(object sender, EventArgs e)
        {
            FloorReached();
        }

        public bool FloorReached()
        {
            bool IsOkFloorReached = false;
            switch (_elevatorState) 
            {
                case ElevatorState.GOING_UP:
                    _currentFloor = _gotoFloor;
                    _elevatorState = ElevatorState.OPEN_DOORS;
                    IsOkFloorReached = true;
                    break;
                case ElevatorState.GOING_DOWN:
                    _currentFloor = _gotoFloor;
                    _elevatorState = ElevatorState.OPEN_DOORS;
                    IsOkFloorReached = true;
                    break;
                case ElevatorState.OPEN_DOORS:
                    IsOkFloorReached = false;
                    break;
                case ElevatorState.RESTING:
                    IsOkFloorReached = false;
                    break;
                default:
                    break;
            }
            return IsOkFloorReached;
        }
        public bool CloseDoors()
        {
            bool IsOkElevatorState = false;
            switch (_elevatorState)
            {
                case ElevatorState.GOING_UP:
                    IsOkElevatorState = false;
                    break;
                case ElevatorState.GOING_DOWN:
                    IsOkElevatorState = false;
                    break;
                case ElevatorState.OPEN_DOORS:
                    _elevatorState = ElevatorState.RESTING;
                    IsOkElevatorState = true;
                    break;
                case ElevatorState.RESTING:
                    IsOkElevatorState = false;
                    break;
                default:
                    break;
            }
            return IsOkElevatorState;
        }
    }
}

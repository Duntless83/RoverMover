using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMover
{
    public class RoverController
    {
        private Rover _rover;
        public RoverController()
        {
            _rover = new Rover();
            _rover.YCoOrdinate = 0;
            _rover.XCoOrdinate = 0;
            _rover.CompassDirection = Compass.N;
        }

        public Rover ReturnRover()
        {
            return _rover;
        }

        public Rover MoveForward()
        {
            _rover.YCoOrdinate = _rover.YCoOrdinate + 1;
            return _rover;
        }
    }
}

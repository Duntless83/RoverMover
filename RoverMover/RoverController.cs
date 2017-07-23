using RoverMover.Interfaces;

namespace RoverMover
{
    public class RoverController : IRoverController
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

        public Rover MoveBackward()
        {
            _rover.YCoOrdinate = _rover.YCoOrdinate - 1;
            return _rover;
        }
        
    }
}

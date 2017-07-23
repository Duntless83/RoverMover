using RoverMover.DependencyInjection;
using RoverMover.Interfaces;
using StructureMap;

namespace RoverMover
{
    public class RoverController : IRoverController
    {
        private Rover _rover;
        private readonly IRoverTurn _turner;
        public RoverController()
        {
            _rover = new Rover();
            _rover.YCoOrdinate = 0;
            _rover.XCoOrdinate = 0;
            _rover.CompassDirection = Compass.N;

            var registry = new Registry();
            registry.IncludeRegistry<DependencyRegistry>();
            var container = new Container(registry);
            _turner = container.GetInstance<IRoverTurn>();
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

        public Rover TurnLeft()
        {
            _turner.Turn("LEFT", ref _rover);
            return _rover;
        }
        
        public Rover TurnRight()
        {
            _turner.Turn("RIGHT", ref _rover);
            return _rover;
        }
    }
}

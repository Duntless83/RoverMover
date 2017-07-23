using RoverMover.DependencyInjection;
using RoverMover.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMover
{
    public class ControlInterface
    {
        private readonly IRoverController _rController;
        public ControlInterface()
        {
            var registry = new Registry();
            registry.IncludeRegistry<DependencyRegistry>();
            var container = new Container(registry);
            _rController = container.GetInstance<IRoverController>();
        }

        public Rover Command(string letters)
        {
            var rover = new Rover();
            for (int i = 0; i < letters.Length; i++)
            {
                var cmd = letters.ToUpper()[i];

                switch (cmd)
                {
                    case 'F':
                        rover = _rController.MoveForward();
                        break;
                    case 'B':
                        rover = _rController.MoveBackward();
                        break;
                    case 'R':
                        rover = _rController.TurnRight();
                        break;
                    case 'L':
                        rover = _rController.TurnLeft();
                        break;
                }
            } 
            return rover;
        }
    }
}

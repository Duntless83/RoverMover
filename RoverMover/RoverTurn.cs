using RoverMover.Interfaces;

namespace RoverMover
{
    public class RoverTurn : IRoverTurn
    {
        public void Turn(string direction, ref Rover rover)
        {
            var currentDirection = rover.CompassDirection;

            switch(direction.ToUpper())
            {
                case "LEFT":
                    rover.CompassDirection =  TurnLeft(currentDirection);
                    break;
                case "RIGHT":
                    rover.CompassDirection = TurnRight(currentDirection);
                    break;
            }
        }

        private Compass TurnLeft(Compass currentDirection)
        {
            var newDirection = currentDirection;

            switch (currentDirection)
            {
                case Compass.N:
                    newDirection = Compass.W;
                    break;
                case Compass.W:
                    newDirection = Compass.S;
                    break;
                case Compass.S:
                    newDirection = Compass.E;
                    break;
                case Compass.E:
                    newDirection = Compass.N;
                    break;
            }

            return newDirection;
        }

        private Compass TurnRight(Compass currentDirection)
        {
            var newDirection = currentDirection;

            switch (currentDirection)
            {
                case Compass.N:
                    newDirection = Compass.E;
                    break;
                case Compass.E:
                    newDirection = Compass.S;
                    break;
                case Compass.S:
                    newDirection = Compass.W;
                    break;
                case Compass.W:
                    newDirection = Compass.N;
                    break;
            }

            return newDirection;
        }
    }
}

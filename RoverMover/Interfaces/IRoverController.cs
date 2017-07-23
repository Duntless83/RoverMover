namespace RoverMover.Interfaces
{
    public interface IRoverController
    {
        Rover MoveForward();
        Rover MoveBackward();
        Rover ReturnRover();
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverMover;

namespace RoverTester
{
    [TestClass]
    public class SimpleMoveTest
    {
        [TestMethod]
        public void MoveRoverForwardOneSquare()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("F");

            Assert.AreEqual(1, rover.YCoOrdinate);
        }

        [TestMethod]
        public void MoveRoverBackwardOneSquare()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("B");

            Assert.AreEqual(100, rover.YCoOrdinate);
        }

        [TestMethod]
        public void MoveRoverRightAndForward()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("RF");

            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(1, rover.XCoOrdinate);
            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRoverLeft()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("L");

            Assert.AreEqual(Compass.W, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRoverRight()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("R");

            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }
    }
}

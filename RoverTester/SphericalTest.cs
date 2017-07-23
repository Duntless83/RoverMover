using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverMover;

namespace RoverTester
{
    [TestClass]
    public class SphericalTest
    {
        [TestMethod]
        public void MoveForward101Spaces()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            for(int i =0; i < 101; i++)
                rover = controller.Command("F");

            Assert.AreEqual(0, rover.YCoOrdinate);
        }

        [TestMethod]
        public void MoveBackward101Spaces()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            for (int i = 0; i < 101; i++)
                rover = controller.Command("B");

            Assert.AreEqual(0, rover.YCoOrdinate);
        }

        [TestMethod]
        public void TurnLeftAndMoveForward1Space()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("LF");

            Assert.AreEqual(100, rover.XCoOrdinate);
            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(Compass.W, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRightAndMoveForward1Space()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("RF");

            Assert.AreEqual(1, rover.XCoOrdinate);
            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRightAndMoveBack1Space()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("RB");

            Assert.AreEqual(100, rover.XCoOrdinate);
            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnLeftAndMoveBack1Space()
        {
            var controller = new ControlInterface();
            var rover = new Rover();

            rover = controller.Command("LB");

            Assert.AreEqual(1, rover.XCoOrdinate);
            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(Compass.W, rover.CompassDirection);
        }
    }
}

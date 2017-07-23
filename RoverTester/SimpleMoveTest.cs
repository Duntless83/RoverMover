﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverMover;

namespace RoverTester
{
    [TestClass]
    public class SimpleMoveTest
    {
        [TestMethod]
        public void MoveRoverForwardOneSquare()
        {
            var controller = new RoverController();
            var rover = new Rover();
            var y = 0;

            rover = controller.MoveForward();

            Assert.AreEqual((y + 1), rover.YCoOrdinate);
        }

        [TestMethod]
        public void MoveRoverBackwardOneSquare()
        {
            var controller = new RoverController();
            var rover = new Rover();
            var y = 0;

            rover = controller.MoveBackward();

            Assert.AreEqual((y - 1), rover.YCoOrdinate);
        }

        [TestMethod]
        public void MoveRoverRightAndForward()
        {
            var controller = new RoverController();
            var rover = new Rover();

            rover = controller.TurnRight();
            rover = controller.MoveForward();

            Assert.AreEqual(0, rover.YCoOrdinate);
            Assert.AreEqual(1, rover.XCoOrdinate);
            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRoverLeft()
        {
            var controller = new RoverController();
            var rover = new Rover();

            rover = controller.TurnLeft();

            Assert.AreEqual(Compass.W, rover.CompassDirection);
        }

        [TestMethod]
        public void TurnRoverRight()
        {
            var controller = new RoverController();
            var rover = new Rover();

            rover = controller.TurnRight();

            Assert.AreEqual(Compass.E, rover.CompassDirection);
        }
    }
}

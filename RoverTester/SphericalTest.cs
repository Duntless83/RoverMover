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
            var controller = new RoverController();
            var rover = new Rover();
            var y = 0;

            rover = controller.MoveForward();

            Assert.AreEqual((y + 1), rover.YCoOrdinate);
        }
    }
}

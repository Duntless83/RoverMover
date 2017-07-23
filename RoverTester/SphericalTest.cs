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
            var y = 0;

            rover = controller.Command("F");

            Assert.AreEqual((y + 1), rover.YCoOrdinate);
        }
    }
}

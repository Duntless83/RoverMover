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
    }
}

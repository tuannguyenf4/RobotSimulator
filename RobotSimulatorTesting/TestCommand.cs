using NUnit.Framework;
using RobotSimulator.Enums;
using RobotSimulator.Services.ToyControl;
using RobotSimulator.Services.ToyDimension;

namespace RobotSimulatorTesting
{
    [TestFixture]
    public class TestCommand
    {
        /// <summary>
        /// Test a valid place command
        /// </summary>
        [Test]
        public void ProcessValidPlaceCommand()
        {
            // arrange
            IToyDimension toyDimension = new ToyDimension(5, 5);
            IToyControl toyControl = new ToyControl();
            var simulator = new RobotSimulator.Services.Behaviours.Behaviour(toyControl, toyDimension);

            // act
            simulator.ProcessCommand("PLACE 3,4,WEST".Split(' '));

            // assert
            Assert.AreEqual(3, toyControl.Position.X);
            Assert.AreEqual(4, toyControl.Position.Y);
            Assert.AreEqual(Direction.WEST, toyControl.Direction);
        }

        /// <summary>
        /// Test an invalid place command
        /// </summary>
        [Test]
        public void ProcessInValidPlaceCommand()
        {
            // arrange
            IToyDimension toyDimension = new ToyDimension(5, 5);
            IToyControl toyControl = new ToyControl();
            var simulator = new RobotSimulator.Services.Behaviours.Behaviour(toyControl, toyDimension);

            // act
            simulator.ProcessCommand("PLACE 5,9,WEST".Split(' '));

            // assert
            Assert.IsNull(toyControl.Position);
        }

        /// <summary>
        /// Test a valid move command
        /// </summary>
        [Test]
        public void ProcessValidMoveCommand()
        {
            // arrange
            IToyDimension toyDimension = new ToyDimension(5, 5);
            IToyControl toyControl = new ToyControl();
            var simulator = new RobotSimulator.Services.Behaviours.Behaviour(toyControl, toyDimension);

            // act
            simulator.ProcessCommand("PLACE 0,0,NORTH".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            var output = simulator.ProcessCommand("REPORT".Split(' '));

            // assert
            Assert.AreEqual("Output: 0,1,NORTH", output);
        }

        /// <summary>
        /// Test and invalid move command
        /// </summary>
        [Test]
        public void ProcessInValidMoveCommand()
        {
            // arrange
            IToyDimension toyDimension = new ToyDimension(5, 5);
            IToyControl toyControl = new ToyControl();
            var simulator = new RobotSimulator.Services.Behaviours.Behaviour(toyControl, toyDimension);

            // act
            simulator.ProcessCommand("PLACE 2,2,NORTH".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            // if the robot goes out of the board it ignores the command
            simulator.ProcessCommand("MOVE".Split(' '));
            var output = simulator.ProcessCommand("REPORT".Split(' '));

            // assert
            Assert.AreEqual("Output: 2,4,NORTH", output);
        }

        /// <summary>
        /// Test report command
        /// </summary>
        [Test]
        public void ProcessValidReportCommand()
        {
            // arrange
            IToyDimension toyDimension = new ToyDimension(5, 5);
            IToyControl toyControl = new ToyControl();
            var simulator = new RobotSimulator.Services.Behaviours.Behaviour(toyControl, toyDimension);

            // act
            simulator.ProcessCommand("PLACE 1,2,EAST".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("LEFT".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            var output = simulator.ProcessCommand("REPORT".Split(' '));

            // assert
            Assert.AreEqual("Output: 3,3,NORTH", output);
        }
    }
}
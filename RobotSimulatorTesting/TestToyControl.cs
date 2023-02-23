using NUnit.Framework;
using RobotSimulator.Enums;
using RobotSimulator.Models;
using RobotSimulator.Services.ToyControl;

namespace RobotSimulatorTesting
{
    [TestFixture]
    public class TestToyControl
    {
        /// <summary>
        /// Test toy turn left
        /// </summary>
        [Test]
        public void ToyTurnLeft()
        {
            // arrange
            var robot = new ToyControl { Direction = Direction.WEST, Position = new Position(2, 2) };

            // act
            robot.TurnLeft();

            // assert
            Assert.AreEqual(Direction.SOUTH, robot.Direction);
        }

        /// <summary>
        /// Test toy turn right
        /// </summary>
        [Test]
        public void ToyTurnRight()
        {
            // arrange
            var robot = new ToyControl { Direction = Direction.WEST, Position = new Position(2, 2) };

            // act
            robot.TurnRight();

            // assert
            Assert.AreEqual(Direction.NORTH, robot.Direction);
        }


        /// <summary>
        /// Test move
        /// </summary>
        [Test]
        public void ToyMove()
        {
            // arrange
            var robot = new ToyControl { Direction = Direction.EAST, Position = new Position(2, 2) };

            // act
            var nextPosition = robot.GetNextPosition();

            // assert
            Assert.AreEqual(3, nextPosition.X);
            Assert.AreEqual(2, nextPosition.Y);
        }

        /// <summary>
        /// Test set toy position and direction
        /// </summary>
        [Test]
        public void ToyPositionAndDirection()
        {
            // arrange
            var position = new Position(3, 3);
            var robot = new ToyControl();

            // act
            robot.SetPlace(position, Direction.NORTH);

            // assert
            Assert.AreEqual(3, robot.Position.X);
            Assert.AreEqual(3, robot.Position.Y);
            Assert.AreEqual(Direction.NORTH, robot.Direction);
        }

    }
}
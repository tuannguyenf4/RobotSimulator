using NUnit.Framework;
using RobotSimulator.Models;
using RobotSimulator.Services.ToyDimension;

namespace RobotSimulatorTesting
{
    [TestFixture]
    public class TestToyDimension
    {

        /// <summary>
        /// Try to put the toy outside of the board
        /// </summary>
        [Test]
        public void InValidToyDimension()
        {
            // arrange
            ToyDimension toyDimension = new ToyDimension(5, 5);
            Position position = new Position(6, 6);

            // act
            var result = toyDimension.IsValidPosition(position);

            // assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test valid positon 
        /// </summary>
        [Test]
        public void ValidToyDimension()
        {
            // arrange
            ToyDimension toyDimension= new ToyDimension(5, 5);
            Position position = new Position(1, 4);

            // act
            var result = toyDimension.IsValidPosition(position);

            // assert
            Assert.IsTrue(result);
        }

    }
}
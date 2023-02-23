using RobotSimulator.Enums;
using RobotSimulator.Models;

namespace RobotSimulator.Services.ToyControl
{
    public class ToyControl : IToyControl
    {
        public Direction Direction { get; set; }
        public Position Position { get; set; }

        // Sets the toy's position and direction.
        public void SetPlace(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        // Determines the next position of the toy based on the direction it's currently facing.
        public Position GetNextPosition()
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case Direction.NORTH:
                    newPosition.Y = newPosition.Y + 1;
                    break;
                case Direction.EAST:
                    newPosition.X = newPosition.X + 1;
                    break;
                case Direction.SOUTH:
                    newPosition.Y = newPosition.Y - 1;
                    break;
                case Direction.WEST:
                    newPosition.X = newPosition.X - 1;
                    break;
            }
            return newPosition;
        }

        // Move the direction of the toy 90 degrees to the left.
        public void TurnLeft()
        {
            Rotate(-1);
        }

        // Move the direction of of the toy 90 degrees to the right.
        public void TurnRight()
        {
            Rotate(1);
        }

        // Determines the new direction of the toy. The new direction is based
        // on current direction and the rotation command (LEFT - RIGHT)
        // the code uses the enumerate values for the NSEW and a modulus
        // operator to calculate the new direction.
        public void Rotate(int rotationNumber)
        {
            var directions = (Direction[])Enum.GetValues(typeof(Direction));
            Direction newDirection;
            if ((Direction + rotationNumber) < 0)
                newDirection = directions[directions.Length - 1];
            else
            {
                var index = ((int)(Direction + rotationNumber)) % directions.Length;
                newDirection = directions[index];
            }
            Direction = newDirection;
        }
    }
}

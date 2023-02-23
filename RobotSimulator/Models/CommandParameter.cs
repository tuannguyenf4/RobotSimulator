using RobotSimulator.Enums;

namespace RobotSimulator.Models
{
    /// <summary>
    /// The parameters for the "PLACE" command.
    /// </summary>
    public class CommandParameter
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public CommandParameter(Position position, Direction direction)
        {
            Position = position;
            Direction = direction;
        }
    }
}

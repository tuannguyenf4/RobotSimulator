using RobotSimulator.Models;

namespace RobotSimulator.Services.ToyDimension
{
    public interface IToyDimension
    {
        // Check if the position of the robot is within the dimension
        bool IsValidPosition(Position position);
    }
}

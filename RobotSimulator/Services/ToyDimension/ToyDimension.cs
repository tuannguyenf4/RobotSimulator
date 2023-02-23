using RobotSimulator.Models;

namespace RobotSimulator.Services.ToyDimension
{
    /// <summary>
    /// Initial the dimension of the table that toy robot moves arround 
    /// Checking the position of toy is valid
    /// </summary>
    public class ToyDimension : IToyDimension
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public ToyDimension(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
        }

        // Check whether the position specified is inside the boundaries of the square board.
        public bool IsValidPosition(Position position)
        {
            return position.X < Columns && position.X >= 0 &&
                   position.Y < Rows && position.Y >= 0;
        }
    }
}

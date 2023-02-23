namespace RobotSimulator.Models
{
    /// <summary>
    /// The position of toy
    /// </summary>
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

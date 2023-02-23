﻿using RobotSimulator.Enums;
using RobotSimulator.Models;

namespace RobotSimulator.Services.ToyControl
{
    public interface IToyControl
    {
        Direction Direction { get; set; }
        Position Position { get; set; }

        // Sets the toy's position and direction.
        void SetPlace(Position position, Direction direction);

        // Checks the next position of the toy based on the direction it's currently facing.
        Position GetNextPosition();

        // Move the direction of the toy 90 degrees to the left.
        void TurnLeft();

        //Move the direction of the toy 90 degrees to the right.
        void TurnRight();

        // Checks the new direction of the toy. The new direction is based on current direction and the rotation command (LEFT - Right)
        // identifies the side which the toy should be rotated on Left is -1 Right is 1      
        void Rotate(int rotationNumber);
    }
}

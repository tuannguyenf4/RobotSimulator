using RobotSimulator.Enums;
using RobotSimulator.Helpers;
using RobotSimulator.Models;
using RobotSimulator.Services.ToyControl;
using RobotSimulator.Services.ToyDimension;

namespace RobotSimulator.Services.Behaviours
{
    public class Behaviour
    {
        public IToyControl _toyControl { get; private set; }
        public IToyDimension _toyDimension { get; private set; }

        /// <summary>
        /// This class is used to simulate the behaviour of the toy
        /// </summary>
        public Behaviour(IToyControl toyControl, IToyDimension toyDimension)
        {
            _toyControl = toyControl;
            _toyDimension = toyDimension;
        }

        public string ProcessCommand(string[] input)
        {
            CommandType command = ProcessCommandsHelper.ParseCommand(input);
            if (command != CommandType.PLACE && _toyControl.Position == null) return string.Empty;

            switch (command)
            {
                case CommandType.PLACE:
                    CommandParameter placeCommandParameter = ProcessCommandsHelper.ParseCommandParameter(input);
                    if (_toyDimension.IsValidPosition(placeCommandParameter.Position))
                        _toyControl.SetPlace(placeCommandParameter.Position, placeCommandParameter.Direction);
                    break;
                case CommandType.MOVE:
                    Position newPosition = _toyControl.GetNextPosition();
                    if (_toyDimension.IsValidPosition(newPosition))
                        _toyControl.Position = newPosition;
                    break;
                case CommandType.LEFT:
                    _toyControl.TurnLeft();
                    break;
                case CommandType.RIGHT:
                    _toyControl.TurnRight();
                    break;
                case CommandType.REPORT:
                    return GetReport();
            }
            return string.Empty;
        }

        public string GetReport()
        {
            return string.Format("Output: {0},{1},{2}", _toyControl.Position.X,
                _toyControl.Position.Y, _toyControl.Direction.ToString().ToUpper());
        }
    }
}

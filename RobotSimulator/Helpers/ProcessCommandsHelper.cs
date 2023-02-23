using RobotSimulator.Enums;
using RobotSimulator.Models;

namespace RobotSimulator.Helpers
{
    public static class ProcessCommandsHelper
    {
        // Parse the command from console and throw the exception when command is invalid
        public static CommandType ParseCommand(string[] rawInput)
        {
            CommandType command;
            if (!Enum.TryParse(rawInput[0], true, out command))
                throw new ArgumentException("Format is invalid. Please try again using the following format: PLACE X,Y,F|MOVE|LEFT|RIGHT|REPORT");
            return command;
        }

        // Extracts the parameters from the user input and returns it       
        public static CommandParameter ParseCommandParameter(string[] input)
        {
            var thisPlaceCommandParameter = new CommandParameterParser();
            return thisPlaceCommandParameter.ParseParameters(input);
        }
    }
}

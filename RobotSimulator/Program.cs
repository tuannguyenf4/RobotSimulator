using RobotSimulator.Services.Behaviours;
using RobotSimulator.Services.ToyControl;
using RobotSimulator.Services.ToyDimension;

public class Program
{
    public static void Main(string[] args)
    {
        // The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.
        IToyDimension toyDimension = new ToyDimension(5, 5);
        IToyControl toyControl = new ToyControl();

        // Inittial the service
        Behaviour robotSimulator = new Behaviour(toyControl, toyDimension);

        bool isStop = false;
        do
        {
            // Command line input
            String command = Console.ReadLine();

            if (command == null) continue;

                try
                {
                // Process the command from command line input
                    string output = robotSimulator.ProcessCommand(command.Split(' '));
                    if (!string.IsNullOrEmpty(output))
                        Console.WriteLine(output);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

        } while (!isStop);
    }
}
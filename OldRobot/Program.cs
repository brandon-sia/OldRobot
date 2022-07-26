using System;

namespace OldRobot // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            for (int index = 0; index < robot.Commands.Length; index++)
            {
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "on":
                        robot.Commands[index] = new OnCommand();
                        break;
                    case "off":
                        robot.Commands[index] = new OffCommand();
                        break;
                    case "north":
                        robot.Commands[index] = new NorthCommand();
                        break;
                    case "south":
                        robot.Commands[index] = new SouthCommand();
                        break;
                    case "east":
                        robot.Commands[index] = new EastCommand();
                        break;
                    case "west":
                        robot.Commands[index] = new WestCommand();
                        break;

                }
            }
            Console.WriteLine();
            robot.Run();
        }
    }
}
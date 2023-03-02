using System;

namespace Examination
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileReader file = new FileReader("input.txt");

            Position posRobot = new Position(file.xRobotPos, file.yRobotPos);
            Position endPostion = new Position(file.xEndPos, file.yEndPos);

            Robot robot = new Robot(posRobot);
            robot.Run(file.operations);

            Console.WriteLine(Position.Compare(robot.posRobot, endPostion));
        }
    }
}
namespace Examination
{
    class Robot
    {
        Position posRobot { get; set; }

        public Robot(Position posRobot)
        {
            this.posRobot = posRobot;
        }

        public void Run(string[] operations)
        {
            for (int i = 0; i < operations.Length; i++)
            {
                string[] info = operations[i].Split(" ");
                posRobot.ChangePosition(info[0], int.Parse(info[1]));
            }
        }
    }
}
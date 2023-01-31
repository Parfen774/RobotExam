namespace Examination
{
    internal class Position
    {
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Position(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public static bool Compare(Position first, Position second)
        {
            return first.xPos == second.xPos && first.yPos == second.yPos;
        }

        public void ChangePosition(string operation, int count)
        {
            switch (operation)
            {
                case "l":
                    xPos -= count;
                    break;
                case "r":
                    xPos += count;
                    break;
                case "u":
                    yPos += count;
                    break;
                case "d":
                    yPos -= count;
                    break;
                case "dul":
                    yPos += count;
                    xPos -= count;
                    break;
                case "dur":
                    yPos += count;
                    xPos += count;
                    break;
                case "ddl":
                    yPos -= count;
                    xPos -= count;
                    break;
                case "ddr":
                    yPos -= count;
                    xPos += count;
                    break;
            }
        }
    }
}
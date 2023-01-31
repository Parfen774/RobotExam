using System.IO;

namespace Examination
{
    internal class FileReader
    {
        public int xRobotPos { get; set; }
        public int yRobotPos { get; set;}
        public int xEndPos { get; set; }
        public int yEndPos { get; set; }
        public string[] operations { get; set; }

        public FileReader(string path)
        {
            string[] file = File.ReadAllLines("input.txt");

            xRobotPos = int.Parse(file[0].Split(";")[0]);
            yRobotPos = int.Parse(file[0].Split(";")[1]);

            xEndPos = int.Parse(file[1].Split(";")[0]);
            yEndPos = int.Parse(file[1].Split(";")[1]);

            operations = file[2..];
        }
    }
}
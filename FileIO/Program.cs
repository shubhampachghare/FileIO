namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path =@"C:\RFP 289\FileIO\FileIO\abc.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");

            }
            else
            {
                Console.WriteLine("File Not Exists");
            }

            string[] lines;
            string lines2;
            lines = File.ReadAllLines(path);

             Console.WriteLine(lines[0]);
             Console.WriteLine(lines[1]);
            Console.WriteLine("-----------------");
            lines2 = File.ReadAllText(path);
            Console.WriteLine(lines2);
        }
    }
}
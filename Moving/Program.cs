namespace Moving
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * lenght * height;
            int boxCount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{freeSpace - boxCount} Cubic meters left.");
                    break;
                }

                boxCount += int.Parse(command);

                if (freeSpace < boxCount)
                {
                    Console.WriteLine($"No more free space! You need {boxCount - freeSpace} Cubic meters more.");
                    break;
                }
            }
        }
    }
}

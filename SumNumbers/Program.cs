namespace SumNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
        }

        private static void WhileLoop()
        {
            int sumNumbers = 0;
            string text;

            while ("Stop" != (text = Console.ReadLine()))
            {
                sumNumbers += int.Parse(text);
            }

            Console.WriteLine($"{sumNumbers}");
        }

        static void ForLoop()
        {
            int sumNumber = 0;

            for (string i = Console.ReadLine(); i != "Stop"; i = Console.ReadLine())
            {
                sumNumber += int.Parse(i);
            }

            Console.WriteLine($"{sumNumber}");
        }
    }
}

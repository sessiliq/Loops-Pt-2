namespace Sequence2K_1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = 1;

            while (number1 <= number)
            {
                Console.WriteLine($"{number1}");
                number1 = number1 * 2 + 1;
            }
        }
    }
}

namespace MinNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            int i = 0;
            while (i < countNumbers)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }

                i++;
            }
            Console.WriteLine("{0}", minNumber);
        }
    }
}

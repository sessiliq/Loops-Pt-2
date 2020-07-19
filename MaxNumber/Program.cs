namespace MaxNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            int i = 0;
            while (i < countNumbers)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                
                i++;
            }

            Console.WriteLine("{0}", maxNumber);
        }
    }
}

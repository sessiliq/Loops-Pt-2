namespace BankAccount
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countDeposit = int.Parse(Console.ReadLine());
            double sumInAccount = 0;
            int i = 0;
            while (i != countDeposit)
            {
                double deposit = double.Parse(Console.ReadLine());

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {deposit:F2}");
                sumInAccount += deposit;
                i++;
            }
            Console.WriteLine($"Total: {sumInAccount:F2}");
        }
    }
}

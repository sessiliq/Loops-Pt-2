namespace ReadText
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countWords = 0;
            string word = string.Empty;
                        
            while (word != "Stop")
            {
                word = Console.ReadLine();
                countWords++;
            }
            
            Console.WriteLine("{0}", countWords - 1);
        }
    }
}

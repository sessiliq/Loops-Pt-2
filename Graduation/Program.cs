
namespace Graduation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grade = 0;
            double totalGrade = 0;
            
            int i = 0;
            while (i < 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    grade = double.Parse(Console.ReadLine());
                }

                totalGrade += grade;
                i++;
            }

            double averageGrade = totalGrade / 12.0;

            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}

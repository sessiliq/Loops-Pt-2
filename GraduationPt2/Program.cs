namespace GraduationPt2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double totalGrade = 0;

            double previousGrade = 6;
            int i = 1;
            while (i <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4 && previousGrade < 4)
                {
                    Console.WriteLine($"{studentName} has been excluded at {i-1} grade");

                    return;
                }

                previousGrade = grade;
                totalGrade += grade;
                i++;
            }
            double averageGrade = totalGrade / 12.0;

            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}

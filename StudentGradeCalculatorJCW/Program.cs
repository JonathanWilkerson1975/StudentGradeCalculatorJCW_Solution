using System;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Calculator");

            Console.Write("Enter the number of subjects: ");
            int subjectCount = Convert.ToInt32(Console.ReadLine());

            double totalScore = 0;

            for (int i = 1; i <= subjectCount; i++)
            {
                Console.Write($"Enter the score for subject {i}: ");
                double score = Convert.ToDouble(Console.ReadLine());
                totalScore += score;
            }

            double average = totalScore / subjectCount;
            Console.WriteLine($"The average score is: {average}");

            if (average >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (average >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (average >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (average >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}

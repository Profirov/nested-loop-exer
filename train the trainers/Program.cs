using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double totalScore = 0;
        int presentationCount = 0;

        while (true)
        {
            string presentation = Console.ReadLine();
            if (presentation == "Finish")
            {
                break;
            }

            double presentationScore = 0;
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                presentationScore += grade;
                totalScore += grade;
            }

            double presentationAverage = presentationScore / n;
            Console.WriteLine($"{presentation} - {presentationAverage:f2}.");
            presentationCount++;
        }

        double averageScore = totalScore / (presentationCount * n);
        Console.WriteLine($"Student's final assessment is {averageScore:f2}.");
    }
}

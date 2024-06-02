using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the GradeCalculator class
            GradeCalculator calculator = new GradeCalculator();

            // Get the grade from the user
            float grade = calculator.GetGradeFromUser();

            // Determine the letter grade
            string letterGrade = calculator.DetermineLetterGrade(grade);

            // Display the letter grade
            calculator.DisplayLetterGrade(letterGrade);
        }
    }
}

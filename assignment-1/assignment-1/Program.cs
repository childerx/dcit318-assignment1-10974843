using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the GradeCalculator class
            GradeCalculator gradeCalculator = new GradeCalculator();

            float grade = gradeCalculator.GetGradeFromUser();

           
            string letterGrade = gradeCalculator.DetermineLetterGrade(grade);

           
            gradeCalculator.DisplayLetterGrade(letterGrade);


            // Create an instance of the TicketPriceCalculator class
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();

         
            int age = ticketPriceCalculator.GetAgeFromUser();

         
            decimal price = ticketPriceCalculator.CalculateTicketPrice(age);

            
            ticketPriceCalculator.DisplayTicketPrice(price);


            // Create an instance of the TriangleTypeIdentifier class
            TriangleTypeIdentifier triangleTypeIdentifier = new TriangleTypeIdentifier();

          
            var (side1, side2, side3) = triangleTypeIdentifier.GetTriangleSidesFromUser();

           
            string triangleType = triangleTypeIdentifier.DetermineTriangleType(side1, side2, side3);

           
            triangleTypeIdentifier.DisplayTriangleType(triangleType);
        }
    }
}

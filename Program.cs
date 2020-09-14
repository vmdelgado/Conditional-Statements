/*
 
Author: Valentina Delgado-Rodriguez
Date: 09/14/2020
Comments: This C# console application code demonstrates the use of IF conditional
          statements after getting input from users.

*/
using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message to users asking them what they expect to get in ISM 4300
            Console.WriteLine("What grade do you expect to get in ISM 4300? Please enter a value from 0 to 100.");

            // Try-catch used to display a message if a user inputs words or a number larger than 100 or smaller than 0
            try
            {
                // Allows the user to input an integer from 0 to 100
                string input = Console.ReadLine();

                // Declared a variable that will store the number that the user enters
                int grade_entered = int.Parse(input);

                // If a user inputs a number between 90 and 100, it will display a message that tells them they will get an A
                if ((grade_entered <= 100) && (grade_entered >= 90))
                {
                    Console.WriteLine("You expect to get an A.");
                }

                // If a user inputs a number between 80 and 89, it will display a message that tells them they will get a B
                else if ((grade_entered <= 89) && (grade_entered >= 80))
                {
                    Console.WriteLine("You expect to get a B.");
                }

                // If a user inputs a number between 70 and 79, it will display a message that tells them they will get a C
                else if ((grade_entered <= 79) && (grade_entered >= 70))
                {
                    Console.WriteLine("You expect to get a C.");
                }

                // If a user inputs a number between 60 and 69, it will display a message that tells them they will get a D
                else if ((grade_entered <= 69) && (grade_entered >= 60))
                {
                    Console.WriteLine("You expect to get a D.");
                }

                // if a user inputs a number that's between 0 and 59, it will display a message that tells them they will get an F
                else if ((grade_entered <= 59) && (grade_entered >= 0))
                {
                    Console.WriteLine("You expect to get an F.");
                }

                // if a user inputs a number outside 0-100, it will display a message asking them to try again
                else
                {
                    Console.WriteLine("Please enter a value from 0 to 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }

            } // end of try

            // Try-catch used to display a message if a user inputs words or a number larger than 100 or smaller than 0
            catch
            {
                Console.WriteLine("Please enter a value from 0 to 100 and try again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);

            } // end of catch
        } // end of main
    } // end of class
} // end of namespace

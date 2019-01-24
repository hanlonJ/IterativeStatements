/*
Author: Jared Hanlon
Date: 1/21/2019
Comments: This C# Console application code demonstrates the use of 
          iterative statements after getting input from users
*/

using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            /* use the try catch block to validate user input
               if the user provides bad input, the catch block
               will display a message and recommend proper input
            */
            try
            {
                string input = Console.ReadLine();
                
                int value_of_input = int.Parse(input);

                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The Do While Loop will iterate " + value_of_input.ToString() + " times.");
                    // Here is the Do While Loop
                    do
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                        value_of_input--;
                    } while (value_of_input > 0);
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 100, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            } // end of catch
        }
    }
}

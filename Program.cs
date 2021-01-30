/* Author: Cody Jones
   Date: 1/29/21
   Comments: This C# Console Application demonstrates the use of
             iterative statements after retrieval of data from user
*/

using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer value between 1 and 100 to execute an iterative statement: ");
            // Use try catch block to validate user input
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 100, execute a For loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    // The For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered" + value_of_input.ToString() + "This is the current integer value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit program..");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again");
                Console.WriteLine("Press any key and exit the program");
                Console.ReadKey(true);
            }
        }
    }
}

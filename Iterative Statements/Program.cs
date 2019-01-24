/*
    Author: Monica Costa
    Date: 1/22/2019
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1-20: ");

            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as int
                int value_of_input = int.Parse(input);

                if ((value_of_input > 0) && (value_of_input <=5))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                    
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of variable i is: " + i.ToString());
                    }

                    Console.WriteLine("Press any key to exit");
                    // Pause the program and wait for the user to press a key and end the program
                    Console.ReadKey(true);
                }
                // If the value of user input is between 6 and 10, execute a While Loop
                else if((value_of_input > 5) && (value_of_input <= 10))
                {
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("The value of variable i is: " + value_of_input.ToString());
                        value_of_input--;
                    }
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);

                }
                else if ((value_of_input > 10 && (value_of_input <=20)))
                {
                    Console.WriteLine("Executing a Do While Loop");
                    Console.WriteLine("The Do While Loop will iterate " + value_of_input.ToString() + "times.");
                    //This is the Do While Loop
                    do
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                        value_of_input--;
                    }
                    while (value_of_input > 0);
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 20, display a message
                else
                {
                    Console.WriteLine("Please enter an integer");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
                

            } // End of try

            catch
            {
                Console.WriteLine("Big mistake buddy...");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            } // End of catch
        } // End of main
    } // End of class
} // End of namespace

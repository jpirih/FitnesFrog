using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;

            Console.WriteLine("Fitnes FROG - Exercise Time Tracking App\n");


            while (true)
            {
                // Promt the user for minutes exercised
                Console.Write("Please enter how many minutes you exercised or type \"quit\" to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }


                try
                {
                    var minutes = Double.Parse(input);

                    if (minutes <= 0)
                    {
                        Console.WriteLine("Incorrect value entred");
                        continue;
                    }

                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothingb, am I right?");
                    }
                    else if (minutes <= 30)
                    {

                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid input.");
                }



                // Display total minutes exercised to the screan
                Console.WriteLine("You've exercised " + runningTotal + " minutes.");

            }

            Console.WriteLine("Goodbye!");

            // Repet until the user Quits

            //  press any key to exit  progam 
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

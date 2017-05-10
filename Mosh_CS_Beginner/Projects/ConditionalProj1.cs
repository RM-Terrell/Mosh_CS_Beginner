using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter a number. 
 * The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
 * Otherwise, display "Invalid". 
 * (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/

namespace Mosh_CS_Beginner.Projects
{
    class ConditionalProj1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number between 1 and 10");
            var input = int.Parse(Console.ReadLine());
            if(input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid input");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

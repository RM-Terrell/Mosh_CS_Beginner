using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and continuously ask the user to enter a number or "ok" to exit. 
 * Calculate the sum of all the previously entered numbers and display it on the console.*/

namespace Mosh_CS_Beginner.Projects
{
    class LoopsProj2
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number or \"okay\" to exit");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
            

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

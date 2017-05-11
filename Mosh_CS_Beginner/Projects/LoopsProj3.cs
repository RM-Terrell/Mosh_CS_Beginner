using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter a number. 
 * Compute the factorial of the number and print it on the console. 
 * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/

namespace Mosh_CS_Beginner.Projects
{
    class LoopsProj3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate factorial: ");
            var number = int.Parse(Console.ReadLine());

            var factorial = 1;

            for (var i = number; i >=1; i--)
            {
                factorial *= i;
            }
                

            Console.WriteLine("{0}! = {1}", number, factorial);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

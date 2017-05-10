using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program which takes two numbers from the console and displays the maximum of the two.*/

namespace Mosh_CS_Beginner.Projects
{
    class ConditionalProj2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            var numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var numTwo = int.Parse(Console.ReadLine());

            if(numOne > numTwo)
            {
                Console.WriteLine("Larger number is " + numOne);
            }
            else if(numOne < numTwo)
            {
                Console.WriteLine("Larger number is" + numTwo);
            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

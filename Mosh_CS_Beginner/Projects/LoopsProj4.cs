using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that picks a random number between 1 and 10. 
 * Give the user 4 chances to guess the number. 
 * If the user guesses the number, display “You won"; otherwise, display “You lost". 
 * (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

namespace Mosh_CS_Beginner.Projects
{
    class LoopsProj4
    {
        static void Main(string[] args)
        {

            var number = new Random().Next(1, 10);

            Console.WriteLine("The number is " + number);

            
            

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

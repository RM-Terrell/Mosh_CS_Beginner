using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter 5 numbers. 
 * If a number has been previously entered, display an error message and ask the user to re-try. 
 * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/

namespace Mosh_CS_Beginner.Projects
{
    class ListProj3
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Please enter 5 unique numbers, each followed by an \"Enter\" keystroke.");

                var number = int.Parse(Console.ReadLine());
                if (numbers.Contains(number)) // Had to look "contains" up. Very useful method
                {
                    Console.WriteLine(number + " has already been entered");
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

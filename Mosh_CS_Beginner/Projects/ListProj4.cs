using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/

namespace Mosh_CS_Beginner.Projects
{
    class ListProj4
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();


            while (true)
            {
                Console.WriteLine("Enter number set. Type \"Quit\" to return unique numbers.");
                
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                var inputNum = int.Parse(input);
                
                if (!numbers.Contains(inputNum))
                {
                    numbers.Add(inputNum);

                }
                
            }

        
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * Work out if the numbers are consecutive. 
 * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".*/

namespace Mosh_CS_Beginner.Projects
{
    class TextProj1
    {
        static void Main(string[] args)
        {

            Console.Write("Enter numbers to check if consecutive.");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-')) // Splits by hyphen
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

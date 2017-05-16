using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
 * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. */

namespace Mosh_CS_Beginner.Projects
{
    class ListProj5
    {
        static void Main(string[] args) 
            // Had a hard time with this one. Needed to consult the Mosh solution. 
            //Not as hard as i thought honestly and I need to do a better job of breaking up a problem into smaller parts to avoid creating a mess.
        {

            string[] elements;
            //----------------------------Section for checking null/whitespace and input count-------------------------------//
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) // Checks for if the input is blank
                {
                    elements = input.Split(','); // Had no idea how to do this previously. Very useful method.
                    if (elements.Length >= 5) // Checks for length
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            //--------------------Section for conversion to int32 and storing in list-------------------------------------//
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            //-----------------Section for returning smallest numbers----------------------------------------------------//

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}


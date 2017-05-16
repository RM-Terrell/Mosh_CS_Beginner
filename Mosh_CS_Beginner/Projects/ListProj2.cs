using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.*/

namespace Mosh_CS_Beginner.Projects
{
    class ListProj2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name");
            var input = Console.ReadLine();
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray); // Just using built in reverse method instead of a loop
            string outputRev = new string(inputarray);

            Console.WriteLine(outputRev);

            //Loop solution
            //var array = new char[input.Length];
            //for (var i = input.Length; i > 0; i--)
            //    array[input.Length - i] = input[i - 1];

            //var outputRev = new string(array);




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

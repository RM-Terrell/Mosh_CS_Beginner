using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.*/

namespace Mosh_CS_Beginner.Projects
{
    class ReverseProcedural
        {
        static void Main(string[] args)
        {
            //Separate stuff that works with the console from the "business logic"//
            Console.WriteLine("Please enter name");
            var input = Console.ReadLine();
            var reversed = ReverseName(input);

            Console.WriteLine(reversed);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

        public static string  ReverseName(string input)
        {
            var array = new char[input.Length];
            for (var i = input.Length; i > 0; i--)
                array[input.Length - i] = input[i - 1];


            var outputRev = new string(array);
            return outputRev;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.
 
     Remove the logic and place it in its own method. Keep the console interaction separate from the math. */

namespace Mosh_CS_Beginner.Projects
{
    class ReverseProcedural
        {
        static void Main(string[] args)
        {
            
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


            return new string(array);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Array syntax
// var matrix = new int[3, 5]; array with 3 rows with 5 columns
// var array = new int[3][]; for a jagged array



namespace Mosh_CS_Beginner
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3]; //Need to specifiy size as 3. Can also use "var" instead of int[]
            //numbers[0] = 1; // default values in a number array are 0. Default values in a bool array are false ( 0 is false 1 is true)

            int[] numbers = new int[]{ 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);

            Console.WriteLine(index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            // Sort
            Array.Sort(another); // Will sort array numerically

            // Reverse
            Array.Reverse(numbers);


          
                


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

    }
}

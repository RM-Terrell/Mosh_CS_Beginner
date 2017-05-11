using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
 * Display the count on the console.*/

namespace Mosh_CS_Beginner.Projects
{
    class LoopsProj1
    {
        static void Main(string[] args)
        {
            var count = 0;

            for(var i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

    }
}

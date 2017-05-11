using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_CS_Beginner
{
    class Loops
    {
        static void Main(string[] args)
        {
            for(var i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Reverse the loop
            for(var i = 10; i >= 1; i--)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }

            // While loop verison
            var x = 0;
            while(x <= 10)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;

            }


            // Display each element of a string
            var name = "John Smith";
            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //For each version
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Name echo while loop
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break; //jumps out of the loops

                Console.WriteLine("@EchoL " + input);
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

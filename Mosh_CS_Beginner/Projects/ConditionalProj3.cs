using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program and ask the user to enter the width and height of an image. 
 * Then tell if the image is landscape or portrait.*/

namespace Mosh_CS_Beginner.Projects
{
    class ConditionalProj3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter width");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            var height = int.Parse(Console.ReadLine());

            if (width < height)
            {
                Console.WriteLine("Image is portrait");
            }
            else if(width > height)
            {
                Console.WriteLine("Image is landscape");

            }
            else
            {
                Console.WriteLine("Image is square");

            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

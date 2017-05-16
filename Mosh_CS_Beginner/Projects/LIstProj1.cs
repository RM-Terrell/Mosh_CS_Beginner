using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

    If no one likes your post, it doesn't display anything.
    If only one person likes your post, it displays: [Friend's Name] likes your post.
    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.*/

namespace Mosh_CS_Beginner.Projects
{
    class ListProj1
    {
        static void Main(string[] args)
        {
            var people = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter name. Press enter with no name to stop");
                // people.Add(Console.ReadLine()); yeah this doesnt work
                var input = Console.ReadLine();
                if(input == "") // could also use "NullOrWhiteSpace" here
                {
                    break;
                }
                people.Add(input);
            }

            if (people.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", people[0], people[1], people.Count - 2);
            else if (people.Count == 2)
                Console.WriteLine("{0} and {1} like your post", people[0], people[1]);
            else if (people.Count == 1)
                Console.WriteLine("{0} likes your post.", people[0]);
            else
                Console.WriteLine();



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

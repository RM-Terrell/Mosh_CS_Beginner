using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.

In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.*/

    /*Personal notes: Same as stopwatch, broke program into two files to clean up the code.*/

namespace CS_Intermediate.Intermediate_Projects.StackOverFlow
{
    class Post
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Provide Title to post");
            var title = Console.ReadLine();

            Console.WriteLine("Provide Description of the post");
            var description = Console.ReadLine();

            var StackPost = new StackPost(title, description);

            //Decided to use a while loop to make running and closing the program easly like the stopwatch
            while (true)
            {
                Console.WriteLine(StackPost.ToString());
                Console.WriteLine("Type 'upvote' or 'downvote' followed by 'enter' to vote");
                var input = Console.ReadLine().ToLower();

                if(input == "upvote")
                {
                    StackPost.UpVote();
                }
                if(input == "downvote")
                {
                    StackPost.DownVote();
                }
                else
                {
                    Console.WriteLine("Please chose 'upvote' or 'downvote'.");
                }               


            }

        }

    }
}

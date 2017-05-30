using System;
using System.Threading;

/*Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.

We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice.*/

    /*Personal notes: Decided to break this into two files in order to keep things more organized and practice using common namespaces and calling methods, etc.*/

namespace CS_Intermediate.Intermediate_Projects.Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Press enter to start stopwatch. Press escape twice to stop program.");

                var keyPressed = Console.ReadKey().Key;
                var stopWatch = new Stopwatch();

                stopWatch.Start();

                Console.WriteLine("Press any key to stop stopwatch");
                keyPressed = Console.ReadKey().Key;

                if (keyPressed.Equals(ConsoleKey.Escape)) break;

                stopWatch.Stop();

                Console.WriteLine("Stop - start = {0}\n", stopWatch.Difference());
                
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// var numbers = new List<int> { 1, 2, 3, 4};

// Lists methods
// add() 
// addRange()
// Remove()
// RemoveAt()
// IndexOf()
// Contains()
// Count


namespace Mosh_CS_Beginner
{
    class Lists
    {
        static void Main(string[] args)
        {


            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1); // adds one. cant do this with an array, lists can be added to
            numbers.AddRange(new int[3] {5, 6, 7 }); // can add another list or array to existing list

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1)); // beginning of list
            Console.WriteLine(numbers.LastIndexOf(1)); // end of list

            Console.WriteLine(numbers.Count); // number of objects in the list

            Console.WriteLine();
            //numbers.Remove(1);

            //foreach (var number in numbers)
            //    Console.WriteLine(number); 
            
            // cant modify collection inside for each block. use normal for loop instead
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear(); // Removes all values form list



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

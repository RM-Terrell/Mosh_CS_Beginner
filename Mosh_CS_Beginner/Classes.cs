using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mosh_CS_Beginner.Math; //Needed to add this in order to use calculator

// void means its does not return any values
// int number'
// Person person = new Person(); allocates new memory for the new class. Dont have to dealocate memory though like C++. Garbage Collection.
// Static  allows method to be accessed, and not repeated 3 times in memory


namespace Mosh_CS_Beginner
{


    class Classes 
    {
        static void Main(string[] args)
        {

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            Console.ReadKey();


        }


    }
}

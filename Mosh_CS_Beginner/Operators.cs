using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arithmetic

//int a = 1;
//int b = a++;
//after one line a = 2 and b = 1  

// int 1 = 1
//int b = ++a
// a = 2 , b = 2  NOTE THAT ORDER MATTERS


//Comparison
// equal : ==  NOTE THAT ITS A DOUBLE = FOR COMPARISON
// not equal : !=

//Assignment 
// = for assigning example: a=1
//Addition, sub, mult, div assignment : +=,-=,*=,/=

//Logical
// AND : &&
// OR : ||
// NOT : !

//Bitwise
// AND : &
// OR : |

namespace Mosh_CS_Beginner
{
    class Operators
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 5;
            //Console.WriteLine(a / b); result will be 3. Need to cast both numbers to float
            Console.WriteLine((float)a / (float)b); //Give proper floating point number result
            Console.WriteLine(a + b * c); // Order of operations is maintained in C#. Use parens to change it

            Console.WriteLine(a > b); // returns boolean
            Console.WriteLine(a == b); //compares the values and returns boolean

            Console.WriteLine(c > b && c > a); // returns false because both must be true
            Console.WriteLine(c > b || c > a); // returns true because just one is true



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

           

        }
    

    


    }
}

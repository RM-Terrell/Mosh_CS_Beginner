﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion. Design a class called Stack with three methods.
 * 
void Push(object obj)
object Pop()
void Clear()

The Push() method stores the given object on top of the stack. We use the “object” type here so we can store any objects inside the stack. 
Remember the “object” class is the base of all classes in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
take into account the scenario that null is passed to this object. We should not store null references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException. Remember, when coding every method, you should think of all possibilities and make sure the method behaves properly in all these edge cases. That’s what
distinguishes you from an “average” programmer.

The Pop() method removes the object on top of the stack and returns it. Make sure to take into account the scenario that we call the Pop() method on an empty stack. In this case, this method
should throw an InvalidOperationException. Remember, your classes should always be in a valid state and used properly. When they are misused, they should throw exceptions. Again, thinking
of all these edge cases, separates you from an average programmer. The code written this way will be more robust and with less bugs.

The Clear() method removes all objects from the stack. We should be able to use this stack class as follows:
var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
The output of this program will be
3
2
1

 */

namespace CS_Intermediate.Intermediate_Projects.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var _stack = new Stack();

            int start = 1;
            int end = 5;

            for (int i = start; i <= end; i++)
                _stack.Push(i);
            for(int i = start; i <= end; i++)
                Console.WriteLine(_stack.Pop());

            Console.ReadLine(); 


        }
    }
    public class Stack
    {
        private readonly List<object> _list = new List<object>(); //Added readonly to avoid reinitiallizing elsewhere in the code
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null object");

            _list.Add(obj); // Add current object
           
        }
        

    public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("No elements in stack");

            var currentElement = _list.Count - 1;

            var Return = _list[currentElement];
           
            _list.RemoveAt(currentElement); // Removes last element in the list

            return (Return);

        }
    }

}

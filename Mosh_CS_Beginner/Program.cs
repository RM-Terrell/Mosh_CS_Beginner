using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_CS_Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notes on data types
            //Console.WriteLine("Hello world!");
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f; //have to add f to explicitly treat as float
            //char character = 'A';
            //string firstName = "Mosh";
            //bool isWorking = true;
            //Console.WriteLine(number);


            //Type converstion

            int i = 1;
            //byte b = i; this will result in an error due to converting and int to byte
            byte b = (byte)i; //this cast explicilty converts and doesnt result in data loss
            // console.writeline will return 1. cant store larger numbers though than 255

            //To convert a string to a number
            var number = "1234";
            int x = Convert.ToInt32(number); //if ToByte will get overflow exception
            // Console.WriteLine(x); will return 1234 as number


            //Try catch example           

            try // type "try" and double tap tab
            {
                var bigNumber = "125483";
                int y = Convert.ToByte(bigNumber);
                Console.WriteLine(y);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte"); //prevents app from crashing and shows message instead
                
            }

        }
    }
}

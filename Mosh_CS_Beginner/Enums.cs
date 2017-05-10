using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_CS_Beginner
{
    public enum ShippingMethod
    {
        RegularAir = 1,
        RegisteredAir = 2,
        Express =3
    }

    class Enums
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID); // casts value

            Console.ReadKey();
        }


    }
}

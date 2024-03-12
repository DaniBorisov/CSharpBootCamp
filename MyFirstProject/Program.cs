using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main1 (string[] args)
        {
            Console.WriteLine("Hello, World!");

  
            int age = 23; // initialization

            Console.WriteLine(age);

            long bugNumber = 90000000L; // to force the compiler to to see it not as int but long integer

            Console.WriteLine(bugNumber);


            double negative = -55.2D; // make it been seen as double 

            System.Console.WriteLine(  negative);
            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(double.MinValue);

            float precision = 5.000001F;
            System.Console.WriteLine(precision);
            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(float.MinValue);


            decimal money = 19.99M;

            System.Console.WriteLine(money);

            age = 50; // Assigment
            // Console.ReadLine();

        }
    }
}


 


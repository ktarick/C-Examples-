// used to search name spaces for unqualified statements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 This Program is the Hello World!
*/

namespace HelloWorldProject //new high level name for everything in the program
{
    class Program //class defines program 
    {
        static int a = 7;

        static void WhileExample()
        {
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Count is {counter}");
                counter = counter + 1;
            }
        }

        static void Print()
        {
            Console.WriteLine($"The value of a is {a}");
        }

        static void Main(string[] args) //program starts run with main
        {
            WhileExample();
            Print();
            var counter = 0;
            var b = 13;
            var c = a * b;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("by, Kellan");
            Console.WriteLine("I WISH THIS WAS ALL C# DID!");
            Console.WriteLine($"For a = {a} and B = {b}, A * B = {c} "); // $ used when printing out variables, wrap variable in {}
            Console.WriteLine($"Value of counter is {counter}");
        
        }
    }
}
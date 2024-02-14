using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float epsilon = 0.000001f;

            Console.WriteLine("Enter the first real number");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second real number:");
            float number2 = float.Parse(Console.ReadLine());
            if (Math.Abs(number1 - number2) < epsilon)
            {
                Console.WriteLine("The two numbers are considered equal within the specified accuracy.");
            }
            else 
            {
                Console.WriteLine("The two numbers are not equal within the specified accuracy.");
            }

            string a = "Hello";
            string b = "World";
            Console.WriteLine(a  + " " + b);
        }
    }
}

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
            double epsilon = 0.000001;

            Console.WriteLine("Enter the first real number");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second real number:");
            double number2 = double.Parse(Console.ReadLine());
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

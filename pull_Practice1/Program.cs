using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace pull_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Happy ";
            string b = "Valentine";
            object c = (a + b);
            string d = c.ToString();
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}

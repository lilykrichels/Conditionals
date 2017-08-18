using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age."  );
            int age = int.Parse(Console.ReadLine());
             if (age < 21)
            {
                Console.WriteLine("You are too young.");
            }
            else
            {
                Console.WriteLine("Welcome to the show!");
            }
        }
    }
}

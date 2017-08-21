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
            //Console.WriteLine("Please enter your age."  );
            //int age = int.Parse(Console.ReadLine());
            // if (age >= 18)
            //{
            //    Console.WriteLine("You are too young.");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome to the show!");
            //}

            Console.WriteLine("What percentage did you recieve on this test?");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("You got an A.");
            }
            else if (grade >= 80 && grade <= 90)
            {
                Console.WriteLine("You got a B");
            }
            else if (grade >= 70 && grade <= 80)
            {
                Console.WriteLine("You have a C");
            }


        }
    }
}

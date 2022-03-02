using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// The source of the exercises which is solved, will be displayed here:https://www.w3resource.com/csharp-exercises/basic-algo/index.php
//Second Exercice: Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30
namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool callCheck = Check();

        }
        static bool Check()
        {
            // I initialize the variable sum, to have as a start value,the number zero-Sum=0
            int sum = 0;
            Console.WriteLine("Give me the first integer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the Second integer");
            int y = Convert.ToInt32(Console.ReadLine());
            sum = (x + y);
            Console.WriteLine("The sum of the two integers is:\n" + sum);
            if (x == 30 || y == 30 || sum == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}










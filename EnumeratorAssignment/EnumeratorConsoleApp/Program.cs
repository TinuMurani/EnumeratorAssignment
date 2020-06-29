using System;
using System.Drawing;
using System.Linq;

namespace EnumeratorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (int item in IntegerEnumerator.GenerateAllIntegers(265))
            //{
            //    Console.WriteLine(item);

            //}

            Console.WriteLine("Results displayed using Delegates:");
            foreach (var item in IntegerEnumerator.GenerateAllOddIntegers(IntegerEnumerator.GenerateAllIntegers(38)))
            {
                Console.WriteLine(item.ToString(), Console.ForegroundColor = ConsoleColor.Green);
            }

            Console.ResetColor();

            //using LINQ
            Console.WriteLine();
            Console.WriteLine("Results displayed using LINQ:");
            IntegerEnumerator.GenerateAllIntegers(38).Where(number => number % 2 == 1)
                .ToList().ForEach(number => Console.WriteLine(number.ToString(), Console.ForegroundColor = ConsoleColor.Red));

            Console.ReadLine();
        }
    }
}

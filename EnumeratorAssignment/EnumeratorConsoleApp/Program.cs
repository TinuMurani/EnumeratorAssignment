using System;

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

            foreach (var item in IntegerEnumerator.GenerateAllOddIntegers(IntegerEnumerator.GenerateAllIntegers(38)))
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}

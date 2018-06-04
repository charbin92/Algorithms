using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingAlgorithms
{
    class SortingApp
    {
        static void Main(string[] args)
        {
            testMergeSort();

            ReadKey();
        }

        private static void testMergeSort()
        {
            int[] numbers = { 1, 4, 9, 7, 3, 5, 1, 75, 89, 3, 7 };

            foreach (int number in numbers)
            {
                Write(number + " ");
            }

            WriteLine();
            WriteLine("===============================");
            WriteLine();

            numbers.DoMergeSort();

            foreach (int number in numbers)
            {
                Write(number + " ");
            }
        }
    }
}

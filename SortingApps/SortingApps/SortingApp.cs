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
            testBubbleSort();

            ReadKey();
        }

        private static void testMergeSort()
        {
            int[] numbers = { 1, 4, 9, 7, 3, 5, 1, 75, 89, 3, 7 };
            WriteLine("Testing Merge Sort");

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
            WriteLine();
            WriteLine("================================");
            WriteLine();
        }

        private static void testBubbleSort()
        {
            int[] numbers = {5, 1, 4, 2, 8};
            WriteLine("Testing Bubble Sort");

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

            WriteLine();
            WriteLine("================================");
            WriteLine();
        }
    }
}

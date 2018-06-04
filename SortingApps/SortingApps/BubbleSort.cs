using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApps
{
    public static class BubbleSort
    {
        public static void doBubbleSort(int[] numbers)
        {
            List<int> sortedNumbers = sort(numbers).ToList();

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }

        private static int[] sort(int[] numbers)
        {
            List<int> result = new List<int>();
            bool swapped;
            do
            {
                swapped = false;
                swapped = CheckIfCurrentNumberIsGreaterThanNextNumber(numbers.ToList(), result, swapped);
            } while (swapped == true);

            return result.ToArray();
        }

        private static bool CheckIfCurrentNumberIsGreaterThanNextNumber(List<int> list, List<int> result, bool swapped)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > list[i + 1])
                {
                    swap(list, result, i);
                    swapped = true;
                }
            }

            return swapped;
        }

        private static void swap(List<int> list, List<int> result, int i)
        {
            result.Add(list[i + 1]);
            list.RemoveAt(i);
        }
    }
}

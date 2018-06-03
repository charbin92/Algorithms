using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApps
{
    public static class MergeSort
    {
        public static void DoMergeSort(this int[] numbers)
        {
            List<int> sortedNumbers = mergeSort(numbers).ToList();

            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }

        private static int[] mergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) // Base Case
                return numbers;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2 == 0)
                    right.Add(numbers[i]);
                else
                    left.Add(numbers[i]);
            }

            // Recursively sort bot sublists.
            right = mergeSort(right.ToArray()).ToList();
            left = mergeSort(left.ToArray()).ToList();

            return merge(right, left);
        }

        private static int[] merge(List<int> right, List<int> left)
        {
            List<int> result = new List<int>();

            while (notEmpty(right) && notEmpty(left))
            {
                if (right.First() <= left.First())
                    moveValueFromSourceToResult(right, result);
                else
                    moveValueFromSourceToResult(left, result);
            }

            while(notEmpty(right))
                moveValueFromSourceToResult(right, result);

            while(notEmpty(left))
                moveValueFromSourceToResult(left, result);

            return result.ToArray();
        }

        private static bool notEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void moveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}

using SortingApps;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void DoMergeSort(this int[] numbers)
        {
            List<int> sortedNumbers = mergeSort(numbers).ToList();

            for (int i = 0; i < sortedNumbers.Count; i++)
                numbers[i] = sortedNumbers[i];
        }

        private static int[] mergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) // Base Case
                return numbers;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            divide(numbers, left, right);

            // Recursively sort both sublists.
            right = mergeSortList(right);
            left = mergeSortList(left);

            return merge(right, left);
        }

        private static void divide(int[] numbers, List<int> left, List<int> right)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i.isEven())
                    right.Add(numbers[i]);
                else
                    left.Add(numbers[i]);
            }
        }

        private static List<int> mergeSortList(List<int> list)
        {
            return mergeSort(list.ToArray()).ToList();
        }

        private static int[] merge(List<int> right, List<int> left)
        {
            List<int> result = new List<int>();

            while (notEmpty(right) && notEmpty(left))
                moveSmallerValueInLeftOrRightToResult(right, left, result);

            moveRemainingValuesFromSourceToResult(right, result);
            moveRemainingValuesFromSourceToResult(left, result);

            return result.ToArray();
        }

        private static bool notEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void moveSmallerValueInLeftOrRightToResult(List<int> right, List<int> left, List<int> result)
        {
            if (right.First() <= left.First())
                moveValueFromSourceToResult(right, result);
            else
                moveValueFromSourceToResult(left, result);
        }

        private static void moveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }

        private static void moveRemainingValuesFromSourceToResult(List<int> list, List<int> result)
        {
            while (notEmpty(list))
                moveValueFromSourceToResult(list, result);
        }
    }
}

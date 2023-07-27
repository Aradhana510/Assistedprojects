using System;

namespace MergeSortDemo
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            int[] tempArray = new int[array.Length];
            MergeSortHelper(array, tempArray, 0, array.Length - 1);
        }

        private static void MergeSortHelper(int[] array, int[] tempArray, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortHelper(array, tempArray, left, middle);
                MergeSortHelper(array, tempArray, middle + 1, right);
                Merge(array, tempArray, left, middle, right);
            }
        }

        private static void Merge(int[] array, int[] tempArray, int left, int middle, int right)
        {
            int leftIndex = left;
            int rightIndex = middle + 1;
            int tempIndex = left;

            while (leftIndex <= middle && rightIndex <= right)
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    tempArray[tempIndex] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    tempArray[tempIndex] = array[rightIndex];
                    rightIndex++;
                }
                tempIndex++;
            }

            while (leftIndex <= middle)
            {
                tempArray[tempIndex] = array[leftIndex];
                leftIndex++;
                tempIndex++;
            }

            while (rightIndex <= right)
            {
                tempArray[tempIndex] = array[rightIndex];
                rightIndex++;
                tempIndex++;
            }

            for (int i = left; i <= right; i++)
            {
                array[i] = tempArray[i];
            }
        }
    }
}

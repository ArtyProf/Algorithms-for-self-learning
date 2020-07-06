using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    static partial class Program
    {
        static void Sorting()
        {
            //Insertion sort
            //This algorithm works effectively when sorting a small number of elements.
            int[] dataForInsertSort = new int[] { 7, 3, 5, 1, 6, 2, 9, 4, 8 };
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Source array: {0}", string.Join(", ", dataForInsertSort));
            for (int i = 1; i < dataForInsertSort.Length; i++)
            {
                int current = dataForInsertSort[i];
                int pointer = i - 1;

                while (pointer >= 0 && dataForInsertSort[pointer] > current)
                {
                    dataForInsertSort[pointer + 1] = dataForInsertSort[pointer];
                    pointer = pointer - 1;
                }

                dataForInsertSort[pointer + 1] = current;
            }

            Console.WriteLine("Sorted array: {0} \n", string.Join(", ", dataForInsertSort));

            //Merge sort
            //Divide & Conquer
            List<int> unsortedDataForMergeSort = new List<int>() { 7, 3, 5, 1, 6, 2, 9, 4, 8 };
            List<int> sortedDataForMergeSort;
            Console.WriteLine("Merge Sort");
            Console.WriteLine("Source array: {0}", string.Join(", ", unsortedDataForMergeSort));

            sortedDataForMergeSort = Sort(unsortedDataForMergeSort);

            static List<int> Sort(List<int> unsorted)
            {
                if (unsorted.Count <= 1)
                {
                    return unsorted;
                }

                List<int> left = new List<int>();
                List<int> right = new List<int>();

                int median = unsorted.Count / 2;
                for (int i = 0; i < median; i++)  //Dividing the unsorted list
                {
                    left.Add(unsorted[i]);
                }

                for (int i = median; i < unsorted.Count; i++)
                {
                    right.Add(unsorted[i]);
                }

                left = Sort(left);
                right = Sort(right);
                return Merge(left, right);
            }

            static List<int> Merge(List<int> left, List<int> right)
            {
                List<int> result = new List<int>();

                while (left.Any() || right.Any())
                {
                    if (left.Any() && right.Any())
                    {
                        if (left.First() <= right.First()) 
                        {
                            result.Add(left.First());
                            left.Remove(left.First());
                        }
                        else
                        {
                            result.Add(right.First());
                            right.Remove(right.First());
                        }
                    }
                    else if (left.Any())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else if (right.Any())
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                return result;
            }
            Console.WriteLine("Sorted array: {0} \n", string.Join(", ", sortedDataForMergeSort));
        }
    }
}

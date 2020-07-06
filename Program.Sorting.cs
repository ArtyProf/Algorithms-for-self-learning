using System;

namespace Algorithms
{
    static partial class Program
    {
        static void Sorting()
        {
            //Insertion sort
            //This algorithm works effectively when sorting a small number of elements.
            int[] data = new int[] { 7, 3, 5, 1, 6, 2, 9, 4 };
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Source array: {0}", string.Join(", ", data));
            for (int i = 1; i < data.Length; ++i)
            {
                int current = data[i];
                int pointer = i - 1;

                while (pointer >= 0 && data[pointer] > current)
                {
                    data[pointer + 1] = data[pointer];
                    pointer = pointer - 1;
                }

                data[pointer + 1] = current;
            }

            Console.WriteLine("Sorted array: {0} \n", string.Join(", ", data));
        }
    }
}

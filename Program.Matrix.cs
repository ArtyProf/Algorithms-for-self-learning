using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    static partial class Program
    {
        static void Matrix()
        {
            //Square-Matrix-Multiply
            //Case:  O(n3)
            int[,] matrixA = new int[,] { { 1, 1 }, { 2, 2 } };
            int[,] matrixB = new int[,] { { 2, 2 }, { 1, 1 } };

            Console.WriteLine("Square-Matrix-Multiply");


            int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(0); k++)
                    {
                        matrixC[i,j] = matrixC[i,j] + matrixA[i,k] * matrixB[k,j];
                    }
                }
            }

            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Console.Write(matrixC[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}

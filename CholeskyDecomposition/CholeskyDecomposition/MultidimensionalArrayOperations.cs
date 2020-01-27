using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CholeskyDecomposition
{
    static class MultidimensionalArrayOperations
    {
        public static double[,] Read(int size)
        {
            double[,] array = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Row {i + 1}:");
                double[] row = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

                for (int j = 0; j < row.Length; j++)
                {
                    array[i, j] = row[j];
                }
            }

            return array;
        }

        public static void Write(double[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
        }

        public static double[,] Transpose(double[,] matrix, int size)
        {
            double[,] transposedMatrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }
    }
}

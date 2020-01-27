using System;
using System.Collections.Generic;
using System.Text;

namespace CholeskyDecomposition
{
    class Cholesky
    {
        public Cholesky(double[,] matrixA, int size)
        {
            if (IsSymmetric(matrixA, size))
            {
                double[,] matrixL = decomposition(matrixA, size);
                double[,] transposedMatrixL = MultidimensionalArrayOperations.Transpose(matrixL, size);

                Console.WriteLine();
                Console.Write("Matrix L:");
                MultidimensionalArrayOperations.Write(matrixL, size);

                Console.WriteLine();
                Console.Write("Transposed matrix L:");
                MultidimensionalArrayOperations.Write(transposedMatrixL, size);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The matrix is not symmetric");
            }
        }
        private bool IsSymmetric(double[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i, j] != array[j, i])
                        return false;
                }
            }
            return true;
        }

        private double[,] decomposition(double[,] matrixA, int size)
        {
            double[,] matrixL = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                    {
                        double sum = 0;
                        for (int k = 0; k < i; k++)
                        {
                            sum += matrixL[i, k] * matrixL[i, k];
                        }
                        matrixL[i, i] = Math.Sqrt(matrixA[i, i] - sum);
                    }
                    else
                    {
                        double sum = 0;
                        for (int k = 0; k < j; k++)
                        {
                            sum += matrixL[i, k] * matrixL[j, k];
                        }
                        matrixL[i, j] = (1.0 / matrixL[j, j]) * (matrixA[i, j] - sum);
                    }
                }
            }

            return matrixL;
        }
    }
}

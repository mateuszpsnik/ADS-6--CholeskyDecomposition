using System;

namespace CholeskyDecomposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of rows/columns:");
            int size = int.Parse(Console.ReadLine());
            double[,] matrixA = new double[size, size];

            matrixA = MultidimensionalArrayOperations.Read(size);

            Console.WriteLine();
            Console.Write("Matrix A:");
            MultidimensionalArrayOperations.Write(matrixA, size);

            new Cholesky(matrixA, size);
        }
    }
}

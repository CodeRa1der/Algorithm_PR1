using System;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n1 = rand.Next(2, 16);
            int n2 = rand.Next(2, 16);
            int[,] matrix = new int[n1, n2];
            Console.WriteLine("Текущая матрица:");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = 0;
            int min = 0;
            for (int i = 0; i < n1; i++)
            {

                for (int j = 0; j < n2; j++)
                {

                    if (i == 0 && j > 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i, j - 1];
                    }
                    if (i > 0 && j == 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i - 1, j];
                    }
                    if (i > 0 && j > 0)
                    {
                        if (matrix[i - 1, j] >= matrix[i, j - 1])
                        {
                            matrix[i, j] = matrix[i, j] + matrix[i - 1, j];
                        }
                        else if (matrix[i, j - 1] >= matrix[i - 1, j])
                        {
                            matrix[i, j] = matrix[i, j] + matrix[i, j - 1];
                        }
                    }
                    if (i == n1 - 1 && j == n2 - 1)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (i == 0 && j > 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i, j - 1];
                    }
                    if (i > 0 && j == 0)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[i - 1, j];
                    }
                    if (i > 0 && j > 0)
                    {
                        if (matrix[i - 1, j] < matrix[i, j - 1])
                        {
                            matrix[i, j] = matrix[i, j] + matrix[i - 1, j];
                        }
                        else if (matrix[i, j - 1] < matrix[i - 1, j])
                        {
                            matrix[i, j] = matrix[i, j] + matrix[i, j - 1];
                        }
                    }
                    if (i == n1 - 1 && j == n2 - 1)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
    }
}

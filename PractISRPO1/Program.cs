using System;

namespace PractISRPO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер строк: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер столбца: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, row];

            Console.WriteLine("\nВведите элементы матрицы");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{i + 1}-я строка, {j + 1}-й столбец: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Обычная матрица");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица по столбцам:");
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

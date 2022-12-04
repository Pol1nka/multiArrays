using System;
using System.Diagnostics;

namespace helping
{
    internal class Program
    {
        private const int minItem = 1;
        private const int maxItem = 1000;
        
        private static int vertical;
        private static int horizontal;
        
        private static int[,] matrix;
        
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            readSizes();
            fullMatrix();
        }

        public static void readSizes()
        {
            Console.Write("Введите размер матрицы по вертикали: ");
            while (vertical <= 0)
            {
                try
                {
                    vertical = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    if (vertical <= 0) throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое неотрицательное число: ");
                }
            }

            Console.Write("Введите размер матрицы по горизонтали: ");
            while (horizontal <= 0)
            {
                try
                {
                    horizontal = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    if (vertical <= 0) throw new Exception();
                }
                catch (Exception )
                {
                    Console.WriteLine("Введите целое неотрицательное число: ");
                }
            }
        }
        public static void fullMatrix()
        {
            matrix = new int[vertical, horizontal];
            
            Random ran = new Random();
            
            for (int i = 0; i < vertical; i++)
            {
                for (int j = 0; j < horizontal; j++)
                {
                    matrix[i, j] = ran.Next(minItem, maxItem);
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
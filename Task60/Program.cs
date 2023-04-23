using System;

namespace Task60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2, 2, 2];
            array = FillArray(array);
            PrintIndex(array);
            Console.WriteLine();
        }

        static int[,,] FillArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[k, i, j] = new Random().Next(0,100);
                    }
                }
            }
            return array;
        }

        static void PrintIndex(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                    }
                }
            }
        }
    }
}

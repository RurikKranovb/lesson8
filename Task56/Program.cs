using System;

namespace Task56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наш массив:");
            var m = 4;
            var n = 4;
            var array = new int[m, n];

            FillArray(array);
            ArrayOutputConsole(array);

            var sumItems = 0;
            var line = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var item = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    item += array[i, j];

                    if (sumItems >= item) continue;
                    line = i;
                    sumItems = item;

                }
            }

            Console.WriteLine("Строка с наименьшей суммой:");
            Console.WriteLine(line);
        }

        private static void ArrayOutputConsole(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t  ");
                Console.WriteLine();

            }
        }

        private static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
            }
        }

    }
}

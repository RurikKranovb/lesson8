using System;

namespace Task54
{

    //https://metanit.com/sharp/tutorial/2.7.php
    //Программа сортировки массива

    class Program
    {
        static void Main(string[] args)
        {

            const int nextItem = 1;
            Console.WriteLine("Введите размеры массива");
            var m = Convert.ToInt32(Console.ReadLine());
            var n = Convert.ToInt32(Console.ReadLine());
            var array = new int[m, n];

            FillArray(array);
            ArrayOutputConsole(array);


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + nextItem])
                        {
                            int temp = array[i, k + nextItem];
                            array[i, k + nextItem] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Массив после сортировки:");
            ArrayOutputConsole(array);

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




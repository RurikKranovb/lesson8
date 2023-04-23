using System;

namespace Task62
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер матрицы: ");

            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrixArray = new int[size, size];
            matrixArray = FillSpiralArray(matrixArray);

            PrintMatrix(matrixArray);
        }

        static int[,] FillSpiralArray(int[,] matrixArray) 
        {
            int[,] newMatrixArray = matrixArray;

            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= newMatrixArray.GetLength(0) * newMatrixArray.GetLength(1))
            {
                newMatrixArray[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < newMatrixArray.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= newMatrixArray.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > newMatrixArray.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }

            return newMatrixArray;
        }

        static void PrintMatrix(int[,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j] :D2} ");
                }

                Console.WriteLine();
            }
        }
    }
}


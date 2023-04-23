using System;


namespace Task58
{
    class Program
    {
		static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры матриц:");
            int  rows1 = SetNumber("Set rows matrixA"), 
                 rows2 = SetNumber("Set rows matrixB");
            int columns1 = SetNumber("Set columns matrixA"),
                columns2 = SetNumber("Set columns matrixB");

            int[,] matrixA = GetRandomMatrix(rows1, columns1);
            PrintMatrix(matrixA);

            int[,] matrixB = GetRandomMatrix(rows2, columns2);
            PrintMatrix(matrixB);


            if (matrixA.LongLength != matrixB.LongLength)
            {
                Console.WriteLine("Умножение невозможно");
            }
            else
            {
                int[,] newMatrix = ResultMatrix(matrixA, matrixB);
                Console.WriteLine("Произведение матриц равно:");
                PrintMatrix(newMatrix);
            }

            Console.WriteLine();
        }

        static int SetNumber(string text)
        {
            Console.Write($"{text}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static int[,] GetRandomMatrix(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
                }
            }

            return array;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]:D2}  ");
                }

                Console.WriteLine();
            }
        }

        static int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
        {
            var newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = 0;
                    for (int n = 0; n < matrix1.GetLength(1); n++)
                    {
                        newMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
                    }
                }
            }

            return newMatrix;
        }
    }
}
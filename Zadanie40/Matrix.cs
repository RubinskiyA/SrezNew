using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie40
{
    internal class Matrix
    {
        private int[,] mas1;
        private int[,] mas2;

        public Matrix(int[,] mas1, int[,] mas2)
        {
            this.mas1 = mas1;
            this.mas2 = mas2;
        }
        public void SumMas()
        {
            int[,] masResult = new int[mas1.GetLength(0), mas1.GetLength(1)];
            Console.WriteLine("Результат сложения матриц: ");
            if (mas1.GetLength(0) == mas2.GetLength(0) && mas1.GetLength(1) == mas2.GetLength(1))
            {
                for (int i = 0; i < mas1.GetLength(0); i++)
                {
                    for (int j = 0; j < mas1.GetLength(1); j++)
                    {
                        masResult[i, j] = mas1[i, j] + mas2[i, j];
                        Console.Write(masResult[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Сложение невозможно, размеры матриц не равны. ");
        }
        public void SubMas()
        {
            int[,] masResult = new int[mas1.GetLength(0), mas1.GetLength(1)];
            Console.WriteLine("Результат вычитания матриц: ");
            if (mas1.GetLength(0) == mas2.GetLength(0) && mas1.GetLength(1) == mas2.GetLength(1))
            {
                for (int i = 0; i < mas1.GetLength(0); i++)
                {
                    for (int j = 0; j < mas1.GetLength(1); j++)
                    {
                        masResult[i, j] = mas1[i, j] - mas2[i, j];
                        Console.Write(masResult[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Вычитание невозможно, размеры матриц не равны. ");
        }
        public void MultiMas()
        {
            int[,] masResult = new int[mas1.GetLength(0), mas1.GetLength(1)];
            Console.WriteLine("Результат умножения матриц: ");
            if (mas1.GetLength(0) == mas2.GetLength(0) && mas1.GetLength(1) == mas2.GetLength(1))
            {
                for (int i = 0; i < mas1.GetLength(0); i++)
                {
                    for (int j = 0; j < mas1.GetLength(1); j++)
                    {
                        masResult[i, j]=0; 
                        for (int k = 0; k < mas1.GetLength(1); k++)
                        {
                            masResult[i, j] += mas1[i, k] * mas2[k, j];
                        }
                        Console.Write(masResult[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Умножение невозможно, размеры матриц не равны. ");
        }
        public void TransMas()
        {
            Console.WriteLine("Транпонированная матрица A: ");
            int[,] transMas1 = new int[mas1.GetLength(0), mas1.GetLength(1)];
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    transMas1[j, i] = mas1[i, j];
                }
            }
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    Console.Write(transMas1[i,j] +" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Транпонированная матрица B: ");

            int[,] transMas2 = new int[mas2.GetLength(0), mas2.GetLength(1)];
            for (int i = 0; i < mas2.GetLength(0); i++)
            {
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    transMas2[j, i] = mas2[i, j];
                }
            }
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    Console.Write(transMas2[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    
}

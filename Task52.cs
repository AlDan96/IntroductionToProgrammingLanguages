using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    public class Task52
    {
        ///<summmary>
        /// Задача № 52
        ///</summmary>
        public Task52()
        {
            int[,] array=CreateArray(); // Создание рандомного двумерного массива
            PrintArray(array); // Вывод полученного массива
            double[] sumArray=GetColumnsSumsArray(array); // Получение массива с суммами чисел в кажом столбце
            PrintArrayColumnsAverages(sumArray, array.GetLength(0)); // Вывод средних арифметических каждого столбца массива
        }

        ///<summmary>
        /// Генерирование двумерного массивамассива
        ///</summmary>
        static int[,] CreateArray()
        {
            var random = new Random();
            int arrayRows=random.Next(2,5);
            int arrayColumns=random.Next(2,5);
            int[,] randomArray = new int[arrayRows, arrayColumns];
            for (int i = 0; i < arrayRows; i++)
            {
                for (int k = 0; k < arrayColumns; k++)
                {
                    randomArray[i, k] = random.Next(1, 9);
                }
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива в виде матрицы
        /// </summary>
        static void PrintArray(int[,] array)
        {
            Write("Полученный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Write($"{array[i, k]} ");
                }
            }
            WriteLine();
        }
        ///<summmary>
        /// Получение массива с суммами чисел в каждом столбце
        ///</summary>
        static double[] GetColumnsSumsArray(int[,] array)
        {
            double[] sumArray=new double[array.GetLength(1)];
            for (int i=0;i<array.GetLength(1);i++)
            {
                for (int k=0;k<array.GetLength(0);k++)
                {
                    sumArray[i]+=array[k,i];
                }
            }
            return sumArray;
        }
        ///<summmary>
        /// Вычисление среднего арифметического
        ///</summmary>
        static double CalculateAverage(double sum, int digitsNumber)
        {
            return Math.Round(sum/digitsNumber,2);
        }
        ///<summmary>
        /// Вывод массива с средними арифметическими
        ///</summary>
        static void PrintArrayColumnsAverages(double[] sumArray, int digitsNumber)
        {
            Write("Среднее арифметическое каждого столбца: ");
            for (int i=0;i<(sumArray.Length-1);i++)
            {
                Write($"{CalculateAverage(sumArray[i], digitsNumber)}; ");
            }
            Write($"{CalculateAverage(sumArray[sumArray.Length-1], digitsNumber)}.");
        }
    }
}
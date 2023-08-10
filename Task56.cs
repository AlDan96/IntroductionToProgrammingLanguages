using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте прямоугольный двумерный массив. Напишите программу, которая будет
    // находить строку с наименьшей суммой элементов.
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4 
    // 5 2 6 7 
    // Программа считает сумму элементов в каждой строке и выдает номер строки
    // с наименьшей суммой элементов: 1 строка.
    public class Task56
    {
        ///<summary>
        /// Задача № 56
        ///</summmary>
        public Task56()
        {
            int[,] array=CreateArray(); // Создание рандомного двумерного массива
            PrintArray(array); // Вывод полученного массива
            int[] sumArray=RowSumArray(array); // Создание массива с суммами строк
            int minSumIndex=GetRowMinSumNumber(sumArray); // Получение номера строки с минимальной суммой
            WriteLine($"Ответ: {minSumIndex} строка."); // Вывод результатов
        }
        ///<summmary>
        /// Генерирование двумерного массивамассива
        ///</summmary>
        static int[,] CreateArray()
        {
            var random = new Random();
            int arrayRows=random.Next(3,5);
            int arrayColumns=random.Next(4,5);
            if (arrayRows==arrayColumns)
            {
                arrayColumns+=1;
            }
            int[,] array = new int[arrayRows, arrayColumns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = random.Next(1, 9);
                }
            }
            return array;
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
        /// <summary>
        /// Вычисление суммы строки
        /// </summary>
        static int[] RowSumArray(int[,] array)
        {
            int[] sumArray=new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum=0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                   sum+=array[i,k];
                }
                sumArray[i]=sum;
            }
            return sumArray;
        }
        ///<summmary>
        /// Получение номера строки с наименьшей суммой
        ///</summary>
        static int GetRowMinSumNumber(int[] sumArray)
        {
            int minSum=sumArray[0];
            int minSumIndex=0;
            for (int i=1; i<sumArray.Length;i++)
            {
                if (minSum>sumArray[i])
                {
                    minSum=sumArray[i];
                    minSumIndex=Array.IndexOf(sumArray,sumArray[i]);
                }
            }
            return (minSumIndex+1);
        }
    }
}
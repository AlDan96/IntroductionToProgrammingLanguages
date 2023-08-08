using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
    // m=3, n=4 -> 0,5 7 -2 -0,2
    //             1 -3,3 8 -9,9
    //             8 7,8 -7 1,9
    public class Task47
    {
        ///<summmary>
        /// Задача № 47
        ///</summmary>
        public Task47()
        {
            int arrayRows = GetArraySize("рядов"); // Ввод количества рядов в массива
            int arrayColumns = GetArraySize("столбцов"); // Ввод количества столбцов в массиве
            double[,] array = CreateArray(arrayRows, arrayColumns); // Создание двумерного массива с рандомными вещественными числами
            PrintArray(array); // Вывод массива в виде матрицы
        }
        ///<summary>
        /// Получение размера массива
        ///</summmary>
        static int GetArraySize(string arrayParameterName)
        {
            string arraySize = string.Empty;
            while (string.IsNullOrWhiteSpace(arraySize) || !CheckIsAllDigits(arraySize))
            {
                Write($"Введите количество {arrayParameterName} массива: ");
                arraySize = ReadLine();
            }
            return int.Parse(arraySize.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool CheckIsAllDigits(string arraySize)
        {
            try
            {
                if (int.Parse(arraySize.Trim()) <= 0)
                {
                    return false;
                }
                for (int i = 0; i < arraySize.Trim().Length; i++)
                {
                    if (char.IsDigit(arraySize[i]) == false)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        ///<summmary>
        /// Генерирование двумерного массивамассива
        ///</summmary>
        static double[,] CreateArray(int arrayRows, int arrayColumns)
        {
            double[,] randomArray = new double[arrayRows, arrayColumns];
            var random = new Random();
            for (int i = 0; i < arrayRows; i++)
            {
                for (int k = 0; k < arrayColumns; k++)
                {
                    randomArray[i, k] = Math.Round(random.Next(-10, 10) + random.NextDouble(), 1);
                }
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива в виде матрицы
        /// </summary>
        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Write($"{array[i, k]} ");
                }
            }
        }
    }
}
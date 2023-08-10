using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    // 2 4 | 3 4 
    // 3 2 | 3 3 
    // Результирующая матрица будет:
    // 18 20
    // 15 18
    public class Task58
    {
        ///<summmary>
        /// Задача № 58
        /// </summmary>
        public Task58()
        {
            int arraySize = GetArraySize(); // Ввод размера массива
            int[,] firstArray=CreateArray(arraySize); // Создание первой матрицы
            int[,] secondArray=CreateArray(arraySize); // Создание второй матрицы
            PrintArray("Первая", firstArray); // Вывод первой матрицы
            PrintArray("Вторая", secondArray); // Вывод второй матрицы
            ArrayMultiplication(firstArray, secondArray, out int[,] resultArray);
            PrintArray("Полученная", resultArray); // Вывод полученной матрицы
        }
        ///<summary>
        /// Получение размера массива
        ///</summmary>
        static int GetArraySize()
        {
            string arraySize = string.Empty;
            while (string.IsNullOrWhiteSpace(arraySize) || !CheckIsAllDigits(arraySize) || (int.Parse(arraySize.Trim())<2))
            {
                Write($"Введите размер квадратной матрицы (минимум 2): ");
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
        /// Генерирование двумерного массива
        ///</summmary>
        static int[,] CreateArray(int arraySize)
        {
            var random = new Random();
            int[,] array = new int[arraySize, arraySize];
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
        /// Вывод массива в виде матрицы
        /// </summary>
        static void PrintArray(string arrayNumber, int[,] array)
        {
            Write($"{arrayNumber} матрица:");
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
        /// Умножение двух матриц
        ///</summmary>
        static void ArrayMultiplication(int[,] firstArray, int[,] secondArray, out int[,] resultArray)
        { 
            resultArray=new int[firstArray.GetLength(0), firstArray.GetLength(1)];
            for (int i=0;i<firstArray.GetLength(0);i++)
            {
                for (int k=0;k<secondArray.GetLength(1);k++)
                {
                    resultArray[i,k]=0;
                    for (int j=0;j<firstArray.GetLength(1);j++)
                    {
                        resultArray[i,k]+=(firstArray[i,j]*secondArray[j,k]);
                    }
                }
            }
        }
    }
}
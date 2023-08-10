using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте двумерный массив. Напишите программу, которая упорядочит
    // по убыванию элементы каждой строки двумерного массива.
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    //Ответ:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2
    public class Task54
    {
        ///<summmary>
        /// Задача № 54
        ///</summary>
        public Task54()
        {
            int[,] array=CreateArray(); // Создание рандомного двумерного массива
            PrintArray(array); // Вывод полученного массива
            SortAndPrintArray(array); // Упорядочивание элементов массива и вывод результата
        }
        ///<summmary>
        /// Генерирование двумерного массивамассива
        ///</summmary>
        static int[,] CreateArray()
        {
            var random = new Random();
            int arrayRows=random.Next(3,6);
            int arrayColumns=random.Next(4,6);
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
        /// <summary>
        /// Сортировка и вывод полученного массива
        /// </summary>
        static void SortAndPrintArray(int[,] array)
        {
            Write("Результат:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    for (int j=0;j<(array.GetLength(1)-1);j++)
                    {
                        if(array[i,j]<array[i,j+1])
                        {
                            int tempVariable=array[i,j+1];
                            array[i,j+1]=array[i,j];
                            array[i,j]=tempVariable;
                        }
                    }
                    Write($"{array[i, k]} ");
                }
            }
            WriteLine();
        }
    }
}
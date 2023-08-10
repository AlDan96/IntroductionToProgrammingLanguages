using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите программу, которая заполнит спирально массив 4 на 4.
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07
    public class Task62
    {
        ///<summmary>
        /// Задача № 62
        ///</summmary>
        public Task62()
        {
            int[,] spiralArray=CreateSpiralArray(); // Заполнение спирального массива
            PrintArray(spiralArray); // Вывод полученного массива
        }
        ///<summmary>
        /// Заполнение двумерного массива
        ///</summmary>
        static int[,] CreateSpiralArray()
        {
            int[,] array = new int[4, 4];
            int firstElement=1;
            int startRow=0;
            int endRow=array.GetLength(0)-1;
            int startColumn=0;
            int endColumn=array.GetLength(1)-1;
            int row=0;
            int column=0;

            for (;column<array.GetLength(1);column++)
            {
                array[row,column]=firstElement;
                firstElement++;
            }
            row++;
            column=endColumn;
            for (;row<array.GetLength(0);row++)
            {
                array[row,column]=firstElement;
                firstElement++;
            }
            row=array.GetLength(0)-1;
            column=array.GetLength(1)-2;
            while(column>startColumn-1)
            {
                array[row,column]=firstElement;
                firstElement++;
                column--;
            }
            column=startColumn;
            row--;
            while(row>startRow)
            {
                array[row,column]=firstElement;
                firstElement++;
                row--;
            }
           row++;
           while(column<endColumn)
           {
                array[row,column]=firstElement;
                firstElement++;
                column++;
           }
           row++;
           column--;
           while(column>startColumn)
           {
                array[row,column]=firstElement;
                firstElement++;
                column--;
           } 
            return array;
        }
        /// <summary>
        /// Вывод массива в виде матрицы
        /// </summary>
        static void PrintArray(int[,] array)
        {
            Write($"Спиральная матрица:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Write($"{array[i, k]:D2} ");
                }
            }
            WriteLine();
        }
    }
}
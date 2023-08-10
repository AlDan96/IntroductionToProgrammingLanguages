using System;
using System.Collections.Generic;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
    // Напишите программу, которая будет построчно выводить массив,
    // добавляя индексы каждого элемента.
    // Массив размеров 2х2х2
    //66(0,0,0) 25(0,1,0)
    //34(1,0,0) 41(1,1,0)
    //27(0,0,1) 90(0,1,1)
    //26(1,0,1) 55(1,1,1)

    public class Task60
    {
        public static List<int> SavingValuesList=new List<int>();
        ///<summmary>
        /// Задача № 60
        ///</summmary>
        public Task60()
        {
            int arraySize = GetArraySize(); // Ввод размера массива
            int[,,] array=CreateArray(arraySize); // Получение трехмерного массива
            PrintArray(array); // Вывод массива
        }
        ///<summary>
        /// Получение размера массива
        ///</summmary>
        static int GetArraySize()
        {
            string arraySize = string.Empty;
            while (string.IsNullOrWhiteSpace(arraySize) || !CheckIsAllDigits(arraySize) || (int.Parse(arraySize.Trim()) < 2))
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
        /// Генерирование массива
        ///</summmary>
        static int[,,] CreateArray(int arraySize)
        {
            
            int[,,] array = new int[arraySize, arraySize, arraySize];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    for (int j = 0; j < array.GetLength(2); j++)
                    {
                        if (i==0 && j==0 && k==0)
                        {
                        array[i, k, j] = GetRandomValue();
                        SavingValuesList.Add(array[i,j,k]);
                        }
                        array[i, k, j]=GetValueForArrayElement();
                    }
                }
            }
            return array;
        }
        ///<summary>
        /// Полчение рандомного значения элемента
        ///</summmary>
        static int GetRandomValue()
        {
            var random = new Random();
            return random.Next(10, 99);
        }
        ///<summmary>
        /// Получение значения для массива
        //</summmary>
        static int GetValueForArrayElement()
        {
            int elementValue=GetRandomValue();
            while(!CheckingUniqueValue(elementValue))
            {
                elementValue=GetRandomValue();
            }
            SavingValuesList.Add(elementValue);
            return elementValue;
        }
        ///<summmary>
        ///Проверка значения на уникальность
        ///</summmary>
        static bool CheckingUniqueValue(int elementValue)
        {
            foreach(int ListElement in SavingValuesList)
            {
                if (ListElement==elementValue)
                {
                    WriteLine($"Совпадение {elementValue}.");
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Вывод массива в виде матрицы
        /// </summary>
        static void PrintArray(int[,,] array)
        {
            WriteLine("Результат:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    for (int j = 0; j < array.GetLength(2); j++)
                    {
                        Write($"{array[i, k, j]}({i},{j},{k}) ");
                    }
                    WriteLine();
                }
            }
        }
    }
}
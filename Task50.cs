using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента.
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 1 7 -> числа с такими индексами в массиве нет
    public class Task50
    {
        ///<summmary>
        /// Задача № 50
        ///</summary>
        public Task50()
        {
            int[,] array=CreateArray(); // Создание рандомного двумерного массива
            PrintArray(array); // Вывод полученного массива
            int[] inputIndexes = GetArrayElementIndexes();  // Ввод строки с индексами
            PrintArrayElement(inputIndexes, array); // Вывод результатов
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
                    randomArray[i, k] = random.Next(-9, 9);
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
        static int[] GetArrayElementIndexes()
        {
            string inputIndexes = string.Empty;
            while (string.IsNullOrWhiteSpace(inputIndexes) || !CheckingInputIndexes(inputIndexes))
            {
                Write($"Введите числа через запятую или пробел: ");
                inputIndexes = ReadLine();
            }
            ConvertStringArrayToIntArray(ConvertIndexesStringToArray(inputIndexes), out int[] inputIndexesIntArray);
            return inputIndexesIntArray;
        }
        ///<summmary>
        /// Проверка строки с индексами
        ///</summmary>
        static bool CheckingInputIndexes(string inputIndexes)
        {
            string[] inputIndexesStringArray = ConvertIndexesStringToArray(inputIndexes);
            if (inputIndexesStringArray.Length!=2)
            {
                return false;
            }
            foreach (string inputIndex in inputIndexesStringArray)
            {
                if (!CheckingConvertStringToInt(inputIndex))
                {
                    return false;
                }
            }
            return true;
        }
         ///<summmary>
        /// Проверка на преобразование строки в целое число
        ///</summmary>
        static bool CheckingConvertStringToInt(string inputIndex)
        {
            try
            {
                Convert.ToInt32(inputIndex);
                return true;
            }
            catch
            {
                return false;
            }
        }
        ///<summmary>
        /// Преобразование строки с индексами в массив
        ///</summmary>
        static string[] ConvertIndexesStringToArray(string inputIndexes)
        {
            inputIndexes=DeleteExtraElements(inputIndexes);
            string[] inputIndexesStringArray = inputIndexes.Split(' ');
            for (int i=0;i<inputIndexesStringArray.Length;i++)
            {
                inputIndexesStringArray[i]=DeleteExtraElements(inputIndexesStringArray[i]);
            }
            return inputIndexesStringArray;
        }
        ///<summary>
        /// Удаление пробелов в начале и конце строки и запятых
        ///</summmary>
        static string DeleteExtraElements(string inputIndex)
        {
            return inputIndex.Replace(',',' ').Trim();
        }
        ///<summmary>
        /// Преобразование строкового массива в числовой
        ///</summmary>
        static void ConvertStringArrayToIntArray(string[] inputIndexesStringArray, out int[] inputIndexesIntArray)
        {
            inputIndexesIntArray=new int[inputIndexesStringArray.Length];

            for (int i=0;i<inputIndexesIntArray.Length;i++)
            {
                inputIndexesIntArray[i]=Convert.ToInt32(inputIndexesStringArray[i]);
            }
        }
        ///<summary>
        /// Вывод числа с заданными индексами
        ///</summary>
        static void PrintArrayElement(int[] inputIndexes, int[,] array)
        {
            try
            {
                WriteLine("Ответ: "+array[inputIndexes[0], inputIndexes[1]]);
            }
            catch
            {
                WriteLine("Ответ: Числа с такими индексами в массиве нет");
            }
        }
    }
}
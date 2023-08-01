using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте массив, заполненный случайными положительными трехзначными числами.
    // Напишите программу, которая показывает количество четных чисел в массиве
    // [345, 897, 568, 234] -> 2
    public class Task34
    {
        ///<summary>
        /// Задача № 34
        ///</summary>
        public Task34()
        {
            int arrayLength=GetArrayLength(); // Ввод длины массива
            int[] array=CreateArray(arrayLength); // Генерирование массива
            PrintArray(array); // Вывод массива
            CountArrayElements(array, out int count);
            WriteLine($"Количество четных элементов в массиве: {count}"); // Вывод количества четных элементов в массиве
        }

        ///<summary>
        /// Получение длины массива
        ///</summmary>
        static int GetArrayLength()
        {
            string arrayLength = string.Empty;
            while (string.IsNullOrWhiteSpace(arrayLength) || !CheckIsAllDigits(arrayLength))
            {
                Write($"Введите длину массива: ");
                arrayLength = ReadLine();
            }
            return int.Parse(arrayLength.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool CheckIsAllDigits(string arrayLength)
        {
            if (int.Parse(arrayLength.Trim())<=0)
            {
                return false;
            }
            for (int i = 0; i < arrayLength.Trim().Length; i++)
            {
                if (char.IsDigit(arrayLength[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        ///<summmary>
        /// Генерирование массива
        ///</summmary>
        static int[] CreateArray(int arrayLength)
        {
            int[] randomArray=new int[arrayLength];
            var random=new Random();
            for (int i=0;i<arrayLength;i++)
            {
                randomArray[i] = random.Next(100,999);
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива
        /// </summary>
        static void PrintArray(int[] array)
        {
            Write($"Сгенерированный массив: [{array[0]}, ");
            for (int i=1;i<array.Length-1;i++)
            {
                Write($"{array[i]}, ");
            }
            Write($"{array[array.Length-1]}]");
        }
        ///<summmary>
        /// Подсчет элементов массива
        ///</summmary>
        static void CountArrayElements(int[] array, out int count)
        {
            count=0;
            for (int i=0;i<array.Length;i++)
            {
                if (CheckingArrayElementsForParity(array[i]))
                {
                    count++;
                }
            }
        }
        ///<summary>
        /// Проверка элемента на четность
        ///</summary>
        static bool CheckingArrayElementsForParity(int arrayElement)
        {
            if (arrayElement%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте массив вещественных чисел.
    // Найдите разницу между макисмальным и минимальным элементами массива.
    // [3.22,4.2,77.15,65.2] -> 77.15-1.15=76
    public class Task38
    {
        ///<summmary>
        /// Задача № 38
        ///</summmary>
       public Task38()
       {
            int arrayLength=GetArrayLength(); // Ввод длины массива
            double[] array=CreateArray(arrayLength); // Генерирование массива
            PrintArray(array); // Вывод массива
            double maxElement=MaxArrayElemet(array); // Поиск максимального элемента массива
            double minElement=MinArrayElement(array); // Поиск минимального элемента массива
            double subtraction = ArrayElementsSubtraction(maxElement, minElement); // Вычисление разницы элементов
            WriteLine();
            WriteLine($"Ответ: {maxElement}-{minElement} = {subtraction}"); // Вывод ответа
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
        static double[] CreateArray(int arrayLength)
        {
            double[] randomArray=new double[arrayLength];
            var random=new Random();
            for (int i=0;i<arrayLength;i++)
            {
                randomArray[i] = Math.Round(random.Next(0,100)+random.NextDouble(),2);
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива
        /// </summary>
        static void PrintArray(double[] array)
        {
            Write($"Сгенерированный массив: [{array[0]}; ");
            for (int i=1;i<array.Length-1;i++)
            {
                Write($"{array[i]}; ");
            }
            Write($"{array[array.Length-1]}]");
        }
        ///<summary>
        /// Поиск максимального элемента массива
        ///</summmary>
        static double MaxArrayElemet(double[] array)
        {
            double maxElement=array[0];
            for (int i=1;i<array.Length;i++)
            {
                if (maxElement<array[i])
                {
                    maxElement=array[i];
                }
            }
            return maxElement;
        }
        ///<summary>
        /// Поиск минимального элемента массива
        ///</summmary>
        static double MinArrayElement(double[] array)
        {
            double minElement=array[0];
            for (int i=1;i<array.Length;i++)
            {
                if (minElement>array[i])
                {
                    minElement=array[i];
                }
            }
            return minElement;
        }
        ///<summary>
        /// Разность максимального и минимального элементов массива
        ///</summmary>
        static double ArrayElementsSubtraction(double maxElement, double minElement)
        {
            return Math.Round(maxElement-minElement,2);
        }
    }
}
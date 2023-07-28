using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите программу, которая задает массив из m элементов и выводит их на экран.
    // Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
    // 1,2,5,7,19->[1,2,5,7,19]
    // 6,1,33 -> [6,1,33]
    public class Task29
    {
        /// <summary>
        /// Задача № 29
        /// </summary>
        public Task29()
        {
            int arrayLength = GetArrayLength(); // Ввод длины массива
            int[] randomArray = CreateArray(arrayLength); // Генерирование массива
            PrintArray(randomArray); // Вывод массива
        }
        ///<summary>
        /// Получение длины массива
        ///</summary>
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
        static int[] CreateArray(int arrayLength)
        {
            int[] randomArray=new int[arrayLength];
            var random=new Random();
            for (int i=0;i<arrayLength;i++)
            {
                randomArray[i] = random.Next(0,100);
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива
        /// </summary>
        static void PrintArray(int[] randomArray)
        {
            Write($"[{randomArray[0]}, ");
            for (int i=1;i<randomArray.Length-1;i++)
            {
                Write($"{randomArray[i]}, ");
            }
            Write($"{randomArray[randomArray.Length-1]}]");
        }
    }
}
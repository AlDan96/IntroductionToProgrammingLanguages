using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте значение N. Напишите программу, которая выведет все
    // натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    public class Task64
    {
        /// <summary>
        /// Задача № 64
        /// </summary>
        public Task64()
        {
            int inputNumber = GetInputNumber();
            Write("Результат: ");
            PrintNumbers(inputNumber);
        }
        /// <summary>
        /// Получение числа от пользователя
        /// </summary>
        static int GetInputNumber()
        {
            Write("Введите число N = ");
            string inputNumber = ReadLine();
            while (string.IsNullOrWhiteSpace(inputNumber) || !IsAllDigits(inputNumber))
            {
                Write("Ошибка. Введите число N = ");
                inputNumber = ReadLine();
            }
            return int.Parse(inputNumber.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool IsAllDigits(string inputNumber)
        {
            try
            {
                if (int.Parse(inputNumber.Trim()) <= 0)
                {
                    return false;
                }
                for (int i = 0; i < inputNumber.Trim().Length; i++)
                {
                    if (char.IsDigit(inputNumber[i]) == false)
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
        /// <summary>
        /// Вывод чисел от N до 1
        /// </summary>
        static void PrintNumbers(int inputNumber)
        {
            if (inputNumber>=2)
            {
                Write(inputNumber + ", ");
                PrintNumbers(inputNumber-1);
            }
            else if (inputNumber==1)
            {
                Write(inputNumber + ".");
            }
        }
    }
}
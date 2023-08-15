using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите программу вычисления функции Аккермана
    // с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29
    public class Task68
    {
        /// <summary>
        /// Задача № 68
        /// </summary>
        public Task68()
        {
            int firstInputNumber = GetInputNumber("m"); // Ввод первого числа
            int secondInputNumber = GetInputNumber("n"); // Ввод второго числа
            Write("Результат: "+ AkkermanFunction(firstInputNumber, secondInputNumber)); // Вывод результата функции Аккермана
        }
        /// <summary>
        /// Получение числа от пользователя
        /// </summary>
        static int GetInputNumber(string variableName)
        {
            Write($"Введите число {variableName} = ");
            string inputNumber = ReadLine();
            while (string.IsNullOrWhiteSpace(inputNumber) || !IsAllDigits(inputNumber))
            {
                Write($"Ошибка. Введите число {variableName} = ");
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
        ///<summary>
        /// Реализация функции Аккермана
        ///</summary>
        static int AkkermanFunction(int firstInputNumber, int secondInputNumber)
        {
            if (firstInputNumber==0)
            {
                return secondInputNumber+1;
            }
            else if (firstInputNumber!=0 && secondInputNumber==0)
            {
                return AkkermanFunction(firstInputNumber-1, 1);
            }
            else
            {
                return AkkermanFunction(firstInputNumber-1, AkkermanFunction(firstInputNumber, secondInputNumber-1));
            }
        }
    }
}
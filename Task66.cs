using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте значения M и N. Напишите программу, которая найдет
    // сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4, N = 8 -> 30
    public class Task66
    {
        /// <summary>
        /// Задача № 66
        /// </summary>
        public Task66()
        {
            int firstInputNumber = GetInputNumber("M"); // Ввод первого числа
            int secondInputNumber = GetInputNumber("N"); // Ввод второго числа
            if (firstInputNumber<secondInputNumber) // Если первое число меньше первого
            {
                int numbersSum=NumbersSum(firstInputNumber, secondInputNumber);
                WriteLine("Результат: " + numbersSum);
            }
            else // Иначе, если первое число больше и равно второму
            {
                int numbersSum=NumbersSum(secondInputNumber, firstInputNumber);
                WriteLine("Результат: " + numbersSum);
            }
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
        /// Получение суммы чисел
        ///</summary>
        static int NumbersSum(int minInputNumber, int maxInputNumber)
        {
            if(minInputNumber<maxInputNumber)
            {
                return minInputNumber+NumbersSum(minInputNumber+1, maxInputNumber);
            }
            else
            {
                return minInputNumber;
            }
        }
    }
}
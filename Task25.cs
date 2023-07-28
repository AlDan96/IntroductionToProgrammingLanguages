using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите цикл, который принимает на вход два числа (А и В) и возводит
    // число А в натуральную степень В
    // 3,5 -> 243 (3^5)
    // 2,4 -> 16
    public class Task25
    {
        /// <summary>
        /// Задача № 25
        /// </summary>
        public Task25()
        {
            int firstNumber = GetInputNumber('A'); // Ввод числа А
            int secondNumber = 0; // Инициализация числа В
            while (!CheckPower(secondNumber)) // Пока число В менее единицы
            {
                secondNumber = GetInputNumber('B'); // надо будет вводить значение числа В
            }
            RaiseNumberToPower(firstNumber, secondNumber); // Вычисление результата и его вывод
        }
        ///<summary>
        /// Получение входящих чисел
        ///</summary>
        static short GetInputNumber(char numberName)
        {
            string inputNumber = string.Empty;
            while (string.IsNullOrWhiteSpace(inputNumber) || !CheckIsAllDigits(inputNumber))
            {
                Write($"Введите число {numberName}: ");
                inputNumber = ReadLine();
            }
            return Convert.ToInt16(inputNumber.Trim());
        }
        ///<summary>
        /// Возведение числа в натуральную степень
        ///</summary>
        static void RaiseNumberToPower(int firstNumber, int secondNumber)
        {
            int result = firstNumber;
            for (int i = 1; i < secondNumber; i++)
            {
                result *= firstNumber;
            }
            WriteLine($"Отыет: {result}");
        }
        ///<summary>
        /// Проверка степени
        ///</summary>
        static bool CheckPower(int inputNumber)
        {
            while (inputNumber < 1)
            {
                return false;
            }
            return true;
        }
        ///<summary>
        /// Проверка чисел
        ///</summary>
        static bool CheckIsAllDigits(string inputNumber)
        {
            try
            {
                Convert.ToInt16(inputNumber.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
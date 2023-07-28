using System;
using static System.Console;
using System.Linq;

namespace ConsoleApplicationForTest
{

    // Условие:
    // Напишите программу, которая принимает на вход число
    // и выдает сумму цифр в числе
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12
    public class Task27
    {
        ///<summary>
        /// Задача № 27
        ///</summary>
        public Task27()
        {
            int inputNumber = GetInputNumber(); // Ввод числа
            GetDigitsSum(inputNumber); // ВЫчисление и вывод суммы цифр числа
        }

        ///<summary>
        /// Получение входящего числа
        ///</summary>
        static int GetInputNumber()
        {
            string inputNumber = string.Empty;
            while (string.IsNullOrWhiteSpace(inputNumber) || !CheckIsAllDigits(inputNumber))
            {
                Write($"Введите число: ");
                inputNumber = ReadLine();
            }
            return int.Parse(inputNumber.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool CheckIsAllDigits(string inputNumber)
        {
            for (int i = 0; i < inputNumber.Trim().Length; i++)
            {
                if (char.IsDigit(inputNumber[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        ///<summary>
        /// Суммирование цифр в массиве
        ///</summary>
        static void GetDigitsSum(int inputNumber)
        {
            int sum = 0;
            while(inputNumber>0)
            {
                sum+=inputNumber%10;
                inputNumber=inputNumber/10;
            }
            WriteLine($"Ответ: {sum}");
        }
    }
}
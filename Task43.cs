using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Напишите программу, которая найдет точку пересечения двух прямых,
    // заданных уравнениями y=k1*x+b1, y=k2*x+b2;
    // значения b1, k1, b2 и k2 задаются пользователем.
    // b1=2, k1=5, b2=4, k2=9 -> (-0,5;-0,5).
    public class Task43
    {
        ///<summmary>
        /// Задача № 43
        ///</summmary>
        public Task43()
        {
            int b1 = GetInputDigit("b1"); // Получение значения переменной b1
            int k1 = GetInputDigit("k1"); // Получение значения переменной k1
            int b2 = GetInputDigit("b2"); // Получение значения переменной b2
            int k2 = GetInputDigit("k2"); // Получение значения переменной k2
            double x = CalculateVariableX(b1, b2, k1, k2); // Расчет координат точки пересечения
            Write($"Ответ: ({x};{x})"); // Вывод результатов
        }
        ///<summary>
        /// Получение числа
        ///</summmary>
        static int GetInputDigit(string digitName)
        {
            string inputDigit = string.Empty;
            while (string.IsNullOrWhiteSpace(inputDigit) || !CheckIsAllDigits(inputDigit))
            {
                Write($"Введите значение переменной  {digitName}: ");
                inputDigit = ReadLine();
            }
            return int.Parse(inputDigit.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool CheckIsAllDigits(string inputDigit)
        {
            try
            {
                if (int.Parse(inputDigit.Trim()) <= 0)
                {
                    return false;
                }
                for (int i = 0; i < inputDigit.Trim().Length; i++)
                {
                    if (char.IsDigit(inputDigit[i]) == false)
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

        static double CalculateVariableX(int b1, int b2, int k1, int k2)
        {
            double x = (double)(b2 - b1) / (double)(k1 - k2);
            return Math.Round(x, 2);
        }
    }
}
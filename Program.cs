// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace HomeWork
{
    class Program
    {
        public static void Main()
        {
            Task10();
            //Task13();
            //Task15();
        }
        /// <summary>
        /// Задача № 10
        /// </summary>
        static void Task10()
        {
            Write("Введите трехзначное число: ");
            string inputNumber = ReadLine(); // Ввод трехзначного числа
            // Проверка числа на трехзначность
            if (inputNumber.Length != 3 || string.IsNullOrWhiteSpace(inputNumber))
            {
                while (inputNumber.Length != 3 || string.IsNullOrWhiteSpace(inputNumber))
                {
                    Write("Ошибка. Введите трехзначное число: ");
                    inputNumber = ReadLine(); // Ввод трехзначного число
                }
            }
            int result = (Convert.ToInt16(inputNumber) / 10) % 10;
            WriteLine("Ответ: " + result); // Вывод второй цифры числа, или второго символа строки
        }
        /// <summary>
        /// Задача № 13
        /// </summary>
        static void Task13()
        {
            Write("Введите число: ");
            int inputNumber = Convert.ToInt16(ReadLine()); // Ввод числа
            // Если при делении на 100 число не равно нулю
            if ((inputNumber/100)!=0)
            {
                while(inputNumber>999) // Пока число больше 999
                {
                    inputNumber=inputNumber/10; // Число делится на 10
                }
                WriteLine(inputNumber%10); // Вывод ответа
            }
            else // В ином случае ответ, что третьей цифры нет
            {
                WriteLine("Третьей цифры нет.");
            }
        }
        /// <summary>
        /// Задача № 15
        /// </summary>
        static void Task15()
        {
            Write("Введите число, обозначающее день недели: ");
            int weekdayNumber = Convert.ToInt16(ReadLine()); // Ввод числа
            WriteLine("Введенное число является выходным днем?");
            // Если число равно 6 или 7
            if (weekdayNumber is 6 or 7)
            {
                WriteLine("Да."); // то положительный ответ
            }
            // Нсли число внутри диапазона значений 1-5
            else if (weekdayNumber >= 1 && weekdayNumber <= 5)
            {
                WriteLine("Нет."); // то отрицательный ответ
            }
            else
            {
                WriteLine("Ошибка. Это число не обозначает день недели."); // При всех других сообщениях выводится сообщение об ошибке
            }
        }
    }
}

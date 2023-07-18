// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Task2();
            //Task4();
            //Task6();
            //Task8();
        }

        /// <summary>
        /// Задача № 2
        /// </summary>
        static void Task2()
        {
            Console.Write("Введите первое число: ");
            var firstNumber = Convert.ToInt16(Console.ReadLine());  // Вводится певое число
            Console.Write("Введите второе число: ");
            var secondNumber = Convert.ToInt16(Console.ReadLine());  // Вводится второе число

            // Если первое число больше второго
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Большее число: " + firstNumber); // Выводится первое число
            }
            else
            {
                Console.WriteLine("Большее число: " + secondNumber); // Выводится второе число
            }
        }

        /// <summary>
        /// Задача № 4
        /// </summary>
        static void Task4()
        {
            Console.Write("Введите первое число: ");
            var firstNumber = Convert.ToInt16(Console.ReadLine());  // Вводится певое число
            Console.Write("Введите второе число: ");
            var secondNumber = Convert.ToInt16(Console.ReadLine());  // Вводится второе число
            Console.Write("Введите третье число: ");
            var thirdNumber = Convert.ToInt16(Console.ReadLine());  // Вводится второе число
            var maxNumber = firstNumber; // Берем значение первого числа для максимального

            // Если максимальное число меньше второго
            if (maxNumber < secondNumber)
            {
                maxNumber = secondNumber; // Берем значение второго числа
            }
            // Если максимальное число меньше третьего
            if (maxNumber < thirdNumber)
            {
                maxNumber = thirdNumber; // Берем значение третьего числа
            }
            Console.WriteLine("Максимальное число: " + maxNumber); // Выводим максимальное число
        }

        /// <summary>
        /// Задача № 6
        /// </summary>
        static void Task6()
        {
            Console.Write("Введите число: ");
            var number = Convert.ToInt16(Console.ReadLine());  // Вводится певое число
            Console.WriteLine("Число четное?");

            // Если число делятся на 2
            if (number % 2 == 0)
            {
                Console.WriteLine("Да");
            }
            else // Иначе
            {
                Console.WriteLine("Нет");
            }
        }

        /// <summary>
        /// Задача № 8
        /// </summary>
        static void Task8()
        {
            Console.Write("Введите число: ");
            var number = Convert.ToInt16(Console.ReadLine());  // Вводится певое число
            int[] array = new int[number];  // Объявление массива
            List<int> evenNumbersList = new List<int>(); // Объявление списка для четных чисел
            var arrayFirstElement = 1;  // Значение первого элемента массива
            //Заполнение массива
            for (int i = 0; i < number; i++)
            {
                array[i] = arrayFirstElement++;
                // Если элемента массива четный
                if (array[i] % 2 == 0)
                {
                    evenNumbersList.Add(array[i]); // Элемент добавляется в список
                }
            }
            Console.WriteLine(String.Join(", ", evenNumbersList)); // Вывод списка в виде строки
        }
    }
}

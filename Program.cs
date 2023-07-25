// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace HomeWork
{
    class Program
    {
        public static void Main()
        {
            Task19();    
            //Task21();
            //Task23();
        }
        /// <summary>
        /// Задача № 19
        /// </summary>
        static void Task19()
        {
            Write("Является ли число полиномом? Введите пятизначное число: ");
            string inputNumber = ReadLine(); //Ввод пятизначного числа
            if (inputNumber.Length != 5 || string.IsNullOrWhiteSpace(inputNumber)) // Если число не пятизначное
            {
                // Будет выводиться сообщение об ошибке, пока пользователь не введет пятизначное число
                while (inputNumber.Length != 5)
                {
                    Write("Ошибка. Введите пятизначное число: ");
                    inputNumber = ReadLine();
                }
            }
            // Если цифры числа равны: вторая=четвертая, первая=пятая
            if (inputNumber[1] == inputNumber[3] && inputNumber[0] == inputNumber[4])
            {
                WriteLine("Да."); // То положительный ответ
            }
            else
            {
                WriteLine("Нет."); // Иначе отрицательный ответ
            }
        }
        /// <summary>
        /// Задача № 21
        /// </summary>
        static void Task21()
        {
            char[] dividers = { ',', ' ' }; // Массив с разделителями между координатами точек
            Write("Введите координаты точки А через пробел или запятую: ");
            string pointACoordinates = ReadLine(); // Ввод координат точки А
            Write("Введите координаты точки В через пробел или запятую: ");
            string pointBCoordinates = ReadLine(); // Ввод координат точки В
            // Если вместо координат точки А пустая строка
            if (string.IsNullOrWhiteSpace(pointACoordinates))
            {
                // Пока строка оставется пустой
                while (string.IsNullOrWhiteSpace(pointACoordinates))
                {
                    Write("Ошибка. Введите координаты точки А: ");
                    pointACoordinates = ReadLine(); // Ввод координат точки А
                }
            }
            //Если вместо координат точки В пустая строка
            if (string.IsNullOrWhiteSpace(pointBCoordinates))
            {
                // Пока пустая строка
                while (string.IsNullOrWhiteSpace(pointBCoordinates))
                {
                    Write("Ошибка. Введите координаты точки B: ");
                    pointBCoordinates = ReadLine(); // Ввод координат точки B
                }
            }

            string[] pointACoordinatesArray = pointACoordinates.Split(dividers); // Удаление разделителей между координатами точки А
            string[] pointBCoordinatesArray = pointBCoordinates.Split(dividers); // Удаление разделителей между координатами точки В

            //Вычиление расстояния между точками А и В
            double pointX = Math.Pow(Convert.ToDouble(pointBCoordinatesArray[0]) - Convert.ToDouble(pointACoordinatesArray[0]), 2);
            double pointY = Math.Pow(Convert.ToDouble(pointBCoordinatesArray[1]) - Convert.ToDouble(pointACoordinatesArray[1]), 2);
            double pointZ = Math.Pow(Convert.ToDouble(pointBCoordinatesArray[2]) - Convert.ToDouble(pointACoordinatesArray[2]), 2);

            double pointDistance = Math.Pow((pointX + pointY + pointZ), 0.5);
            WriteLine("Результат: {0:0.00}", pointDistance); // Вывод расстояния
        }
        /// <summary>
        /// Задача № 23
        /// </summary>
        static void Task23()
        {
            Write("Введите число: ");
            string inputNumber = ReadLine(); // Ввод числа
            // Если строка пустая или число меньше 1
            if (string.IsNullOrWhiteSpace(inputNumber) || Convert.ToInt16(inputNumber) < 1)
            {
                // Пока не исправлена ошибка, надо будет вводить числа
                while (string.IsNullOrWhiteSpace(inputNumber) || Convert.ToInt16(inputNumber) < 1)
                {
                    Write("Ошибка. Введите корректное число: ");
                    inputNumber = ReadLine(); // Ввод числа
                }
            }
            // Вычисление и выыод таблицы кубов чисел
            WriteLine($"Таблица кубов числе от 1 до {inputNumber}");
            for (int i = 1; i <= Convert.ToInt16(inputNumber); i++)
            {
                WriteLine($"{i}-" + Math.Pow(i, 3));
            }
        }
    }
}

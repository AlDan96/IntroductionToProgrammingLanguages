using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Пользователь вводит с клавиатуры M чисел.
    // Посчитайте, сколько чисел больше 0 ввел пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223 -> 4
    public class Task41
    {
        ///<summmary>
        /// Задача № 41
        ///</summmary>
        public Task41()
        {
            string inputNumbersString = GetInputNumbersString();  // Ввод строки с числами
            string[] inputNumbersStringArray = ConvertInputNumbersStringToArray(inputNumbersString); // Преобразование строки в строковый массив
            ConvertStringArrayToIntArray(inputNumbersStringArray, out int[] inputNumbersArray); // Преобразование строкового массива в числовой массив
            int arrayElementCount = ArrayElementsCount(inputNumbersArray); // Подсчет элементов массива больше 0
            WriteLine($"Всего элементов больше 0: {arrayElementCount}"); // Вывод полученного результата
        }

        ///<summmary>
        /// Получение чисел в виде строки
        ///</summmary>
        static string GetInputNumbersString()
        {
            string inputData = string.Empty;
            while (string.IsNullOrWhiteSpace(inputData) || !CheckingNumbersInString(inputData))
            {
                Write($"Введите числа через запятую или пробел: ");
                inputData = ReadLine();
            }
            return inputData;
        }
        ///<summmary>
        /// Проверка на преобразование строки в целое число
        ///</summmary>
        static bool CheckingConvertStringToInt(string arrayElement)
        {
            try
            {
                Convert.ToInt32(arrayElement);
                return true;
            }
            catch
            {
                return false;
            }
        }
        ///<summmary>
        /// Проверка строку с числами на наличие посторонних символов
        ///</summmary>
        static bool CheckingNumbersInString(string inputNumbersString)
        {
            string[] inputnumbersArray = ConvertInputNumbersStringToArray(inputNumbersString);

            foreach (string arrayElement in inputnumbersArray)
            {
                if (!CheckingConvertStringToInt(arrayElement))
                {
                    return false;
                    //continue;
                }
            }
            return true;
        }
        ///<summmary>
        /// Преобразование строки с числами в массив
        ///</summmary>
        static string[] ConvertInputNumbersStringToArray(string inputNumbersString)
        {
            inputNumbersString=DeleteExtraElements(inputNumbersString);
            string[] inputNumbersArray = inputNumbersString.Split(' ');
            for (int i=0;i<inputNumbersArray.Length;i++)
            {
                inputNumbersArray[i]=DeleteExtraElements(inputNumbersArray[i]);
            }
            return inputNumbersArray;
        }
        ///<summary>
        /// Удаление пробелов в начале и конце строки и запятых
        ///</summmary>
        static string DeleteExtraElements(string inputString)
        {
            return inputString.Replace(',',' ').Trim();
        }
        ///<summmary>
        /// Преобразование строкового массива в числовой
        static void ConvertStringArrayToIntArray(string[] inputNumbersStringArray, out int[] inputNumbersIntArray)
        {
            inputNumbersIntArray=new int[inputNumbersStringArray.Length];

            for (int i=0;i<inputNumbersIntArray.Length;i++)
            {
                inputNumbersIntArray[i]=Convert.ToInt32(inputNumbersStringArray[i]);
            }
        }
        ///<summary>
        /// Подсчет элементов массива больше 0
        ///</summary>
        static int ArrayElementsCount(int[] array)
        {
            int count=0;
            for (int i=0;i<array.Length;i++)
            {
                if (array[i]>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
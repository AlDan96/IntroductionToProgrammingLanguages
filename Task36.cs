using System;
using static System.Console;

namespace HomeWork
{
    // Условие:
    // Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов, стоящих на нечетных позициях.
    // [3,7,23.12] -> 19
    // [-4,-6,89,6] -> 0
    public class Task36
    {
        ///<summary>
        /// Задача № 36
        ///</summary>
       public Task36()
       {
            int arrayLength=GetArrayLength(); // Ввод длины массива
            int[] array=CreateArray(arrayLength); // Генерирование массива
            PrintArray(array); // Вывод массива
            ArrayElementsSum(array, out int sum); // Сложение элементов массива на нечетных позициях
            WriteLine($"Сумма элементов массива на нечентных позициях: {sum}");
       }
       ///<summary>
        /// Получение длины массива
        ///</summmary>
        static int GetArrayLength()
        {
            string arrayLength = string.Empty;
            while (string.IsNullOrWhiteSpace(arrayLength) || !CheckIsAllDigits(arrayLength))
            {
                Write($"Введите длину массива: ");
                arrayLength = ReadLine();
            }
            return int.Parse(arrayLength.Trim());
        }
        ///<summary>
        ///Проверка символов строки на то, что являются цифрами
        ///</summary>
        static bool CheckIsAllDigits(string arrayLength)
        {
            if (int.Parse(arrayLength.Trim())<=0)
            {
                return false;
            }
            for (int i = 0; i < arrayLength.Trim().Length; i++)
            {
                if (char.IsDigit(arrayLength[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        ///<summmary>
        /// Генерирование массива
        ///</summmary>
        static int[] CreateArray(int arrayLength)
        {
            int[] randomArray=new int[arrayLength];
            var random=new Random();
            for (int i=0;i<arrayLength;i++)
            {
                randomArray[i] = random.Next(-100,100);
            }
            return randomArray;
        }
        /// <summary>
        /// Вывод сгенерированного массива
        /// </summary>
        static void PrintArray(int[] array)
        {
            Write($"Сгенерированный массив: [{array[0]}, ");
            for (int i=1;i<array.Length-1;i++)
            {
                Write($"{array[i]}, ");
            }
            Write($"{array[array.Length-1]}]");
        }
        ///<summmary>
        /// Сложение элементов массива на нечетных позициях
        ///</summmary>
        static void ArrayElementsSum(int[] array, out int sum)
        {
            sum=0;
            for (int i=0;i<array.Length;i++)
            {
                if (Array.IndexOf(array, array[i])%2!=0 && Array.IndexOf(array, array[i])>0)
                {
                    sum+=array[i];
                }
            }
        }
    }
}
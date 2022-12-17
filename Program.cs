using System;

namespace Ex41
{
    class Program
    {
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
        // Ввод масива
        static int[] getArray()
        {
            //  return new int[5] { 0, 7, 8, -2, -2 };


            int[] Array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите числа");
                Array[i] = int.Parse(Console.ReadLine());
            }

            return Array;
        }
        static void Main(string[] args)
        {
            int[] Array = getArray();
            int value = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Array[i] > 0)
                {
                    value += 1;
                }
            }
            Console.WriteLine($"Чисел больше нуля:{value}");
            Console.ReadLine();
        }
    }
}

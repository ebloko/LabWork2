using System;

namespace Task1
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++) // запись в массив чисел
            {
                arr[i] = random.Next(35); 
            }

            for (int i = 0; i < arr.Length; i++) // вывод массива
            {
                Console.Write("[" + i + "]" + arr[i] + " ");
            }
            Console.WriteLine();       

            Console.Write("Введите искомое число (0-35): ");
            var num = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Convert.ToInt32(num))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

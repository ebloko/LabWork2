using System;

namespace temp
{
    class Program
    {
        public class JumpSearch

        {

            public static int jumpSearch(int[] arr, int x)

            {

                int n = arr.Length;



                // Находим размер блока для перехода

                int step = (int)Math.Floor(Math.Sqrt(n));



                // Находим блок, где находится элемент

                // присутствует (если есть)

                int prev = 0;

                while (arr[Math.Min(step, n) - 1] < x)

                {

                    prev = step;

                    step += (int)Math.Floor(Math.Sqrt(n));

                    if (prev >= n)

                        return -1;

                }



                // Выполнение линейного поиска x в блоке

                // начиная с пред.

                while (arr[prev] < x)

                {

                    prev++;



                    // Если мы достигли следующего блока или конца

                    // массив, элемент отсутствует.

                    if (prev == Math.Min(step, n))

                        return -1;

                }



                // Если элемент найден

                if (arr[prev] == x)

                    return prev;



                return -1;

            }



            // Программа драйвера для тестирования функции

            public static void Main()

            {

                int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21,

                    34, 55, 89, 144, 233, 377, 610};

                int x = 55;



                // Находим индекс 'x' с помощью Jump Search

                int index = jumpSearch(arr, x);



                // Распечатать индекс, где находится 'x'

                Console.Write("Number " + x +

                                    " is at index " + index);

            }

        }
    }
}

using System;

namespace Task2
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] temp = new int[20]; // временный массив
            int[] sortArr = new int[temp.Length]; // массив отсортирвоанный
            Random random = new Random();
            for (int i = 0; i < temp.Length; i++) // запись в массив чисел
            {
                temp[i] = random.Next(35);
            }
            Array.Sort(sortArr);

            Console.Write("Введите искомое число (0-35): "); // ввести искомое число
            var num = Console.ReadLine();

            double middle = 0;
            int tempSumm = 0;
            for (int i = 0; i < sortArr.Length; i++) // нахождение ср знач-я (middle)
            {
                for (int j = 0; j < sortArr.Length; j++)
                    tempSumm += sortArr[j];

                middle = tempSumm / sortArr.Length;
            }

            int left = 0, right = 0;
            while (left > right)
            {
                if (Convert.ToInt32(num) < middle)
                {
                    left = Convert.ToInt32(middle - 1);
                }
                else
                {
                    right = Convert.ToInt32(middle + 1);
                }
            }
            return -1;
        }
    }
}

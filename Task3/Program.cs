using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[30];
            int[] sortArr = new int[temp.Length]; // массив отсортирвоанный
            Random random = new Random();
            for (int i = 0; i < temp.Length; i++) // запись в массив чисел
            {
                temp[i] = random.Next(35);
            }
            Array.Sort(sortArr);


            Console.Write("Введите искомое число : "); // ввести искомое число
            var elementToSearch = Console.ReadLine();

            double jump = Math.Sqrt(sortArr.Length);
            double jumpStep = 1 * jump;
            double previousStep;

            while(jumpStep < Convert.ToInt32(elementToSearch)) // прыжки пока число не будет > искомого
            {
                int i = 1;
                previousStep = jumpStep;
                jumpStep = i * jump;
                i++;
                previousStep = jumpStep;
            }

            for (int diff = (jumpStep - previousStep), i = 0; i < (jumpStep - previousStep); i++)
            {
                if (arr[i] == Convert.ToInt32(num))
                {
                    return i;
                }
            }


        }
    }
}

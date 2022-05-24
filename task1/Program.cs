using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiyi indexi tapan alqoritm (binary search)
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 1;
            int min = 0;
            int max = numbers.Length - 1;
            int index = 0;
            int count = 0;

            while (min <= max)

            {
                int mid = (min + max) / 2;
                if (numbers[mid] == n)
                {
                    index = mid;
                    count++;
                    break;
                }
                else if (numbers[mid] < n)

                {
                   min = mid + 1;
                }
                else
                {
                   max = mid -1;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("n ededi arrayde yoxdur");
            }
            else
            {
                Console.WriteLine(index);
            }




        }
    }
}

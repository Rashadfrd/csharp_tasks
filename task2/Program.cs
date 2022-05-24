using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 6, 4, 9, 8, 2 };
            int temp = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length-(i+1); j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        temp = numbers[j+1];
                        numbers[j+1] = numbers[j];
                        numbers[j] = temp;

                    }
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

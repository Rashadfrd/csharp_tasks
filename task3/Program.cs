using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers1 = { 3, 4, 5 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers1[i] == numbers2[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == numbers1.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}

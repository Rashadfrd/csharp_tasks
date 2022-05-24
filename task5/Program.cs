using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', };
            Console.WriteLine("Ad daxil edin:");
            string input = Console.ReadLine();
          

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (input[i] == numbers[j])
                    {
                       
                        i = -1;
                        Console.WriteLine("Try again!");
                        input = Console.ReadLine();
                        break;
                    }
                }
            }
           
            
        }
    }
}

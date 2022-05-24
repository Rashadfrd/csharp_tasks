using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] writings = { "Alma", "Aanan", "Armud", "Aartof", };
            int count = 0;
            for (int i = 0; i < writings.Length; i++)
            {
                for (int j = 0; j < writings[i].Length; j++)

                {
                    if (writings[i][j] == 'A')

                    {
                        count++;
                        break;
                    }
                    
                }
            }
            if (count == writings.Length)

            {
                Console.WriteLine("hamisi a ile basliyir");
            }
            else
            {
                Console.WriteLine("baslamir");
            }




        }
    }
}

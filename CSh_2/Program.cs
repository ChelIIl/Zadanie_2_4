using System;

namespace CSh_2
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= i; j++)
                    Console.Write(j + "  ");
            }

            Console.ReadKey();
        }
    }
}

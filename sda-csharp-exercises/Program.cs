using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int power(int a, int b)
            {
                int result = 1;
                for (int i = b; i > 0; i--)
                {
                    result = result * a;
                }
                return result;

                if (result < 0)
                {
                    Console.WriteLine("Wynik ujemny");
                }

                
            }

            Console.WriteLine("Wynik potegowania to: " +power(2, 4));
        }
    }
}

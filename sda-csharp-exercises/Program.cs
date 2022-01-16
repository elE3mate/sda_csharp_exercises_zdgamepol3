using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public void DrawTriangle(int linesNumber, char sign)
        {
            for (int i = 0; i < linesNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sign);

                }
                Console.WriteLine();
            }

            for (int i = linesNumber - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę linii");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj znak");
            char sign = Convert.ToChar(Console.ReadLine());

            DrawTriangle(lines, sign);
        }
    }
}

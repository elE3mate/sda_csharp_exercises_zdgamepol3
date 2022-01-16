using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void ArithmeticSequence(int length, int firstElement, int difference)
        {
            int value = firstElement;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{value} ");
                value += difference;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dlugosc");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj pierwszy element");
            int firstElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj roznice ciagu");
            int difference = Convert.ToInt32(Console.ReadLine());

            ArithmeticSequence(length, firstElement, difference);
        }
    }
}

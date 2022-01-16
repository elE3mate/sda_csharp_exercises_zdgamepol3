using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc;
            int cena;

            ilosc = 3;
            cena = 5;

            for (int i = 1; i <= ilosc; i++)
            {
                Console.WriteLine("Liczba sztuk to: " + i + " a laczny koszt to: " + i*cena + " zlotych");
            }
        }
    }
}

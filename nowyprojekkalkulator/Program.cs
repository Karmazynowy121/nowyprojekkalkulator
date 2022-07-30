using System;

namespace nowyprojekkalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj Liczbe:  ");
            int Liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj kolejna liczbe:  ");
            int Liczba2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Liczba1 + Liczba2);

            Console.ReadLine();
        }
    }
}

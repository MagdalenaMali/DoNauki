using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1;
            int liczba2;
            int Dodawanie;
            int Odejmowanie;
            int mnozenie;
            int dzielenie;
            int modulo;

            Console.WriteLine("Podaj pierwszą liczbę");
            liczba1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbę");
            liczba2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Liczba1: {0}", liczba1);
            Console.WriteLine("Liczba2: {0}", liczba2);

            Dodawanie = liczba1 + liczba2;
            Console.WriteLine("Dodawanie: {0}", Dodawanie);

            Odejmowanie = liczba1 - liczba2;
            Console.WriteLine("Odejmowanie: {0}", Odejmowanie);

            mnozenie = liczba1 * liczba2;
            Console.WriteLine("mnozenie: {0}", mnozenie);

            dzielenie = liczba1 / liczba2;
            Console.WriteLine("dzielenie {0}", dzielenie);

            modulo = liczba1 % liczba2;
            Console.WriteLine("modulo {0}", modulo);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

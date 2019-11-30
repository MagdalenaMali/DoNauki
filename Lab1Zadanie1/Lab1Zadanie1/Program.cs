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
           
            Console.WriteLine("Podaj pierwszą liczbę");
            liczba1 = Int32.Parse(Console.ReadLine());
            liczba2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Liczba1: {0}", liczba1);
            Console.WriteLine("Liczba2: {0}", liczba2);

            Dodawanie = liczba1 + liczba2;
            Console.WriteLine("Dodawanie: {0}", Dodawanie);

            Odejmowanie = liczba1 - liczba2;
            Console.WriteLine("Odejmowanie: {0}", Odejmowanie);

            mnozenie = liczba1 * liczba2;
            Console.WriteLine("mnozenie: {0}", mnozenie);

            Console.WriteLine("Podaj druga liczbę");
            

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

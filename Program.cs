using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzacowanieZłożonościObliczeniowej
{
    class Program
    {
        static long SilniaRekurencyjnie(int n)
        {
            // deklaracja rekurencyjna
            if (n == 0)
                return 1;
            return n * SilniaRekurencyjnie(n - 1);
        }
        static long SilniaIteracynie(int n)
        {
            // deklaracja iteracyjna
            // deklaracja pomocnicza
            long KolejnaWartośćSilni = 1; // dla n = 0
            for(ushort i = 1; i <= n; i++)
                KolejnaWartośćSilni = KolejnaWartośćSilni * i;
            // zwrotne przekazanie wyniku
            return KolejnaWartośćSilni;
        }
        static long FibonacciRekurencyjny(int n)
        {
            // sprawdzanie warunku brzegowego
            if (n == 0 || n == 1)
                return 1;
            return FibonacciRekurencyjny(n - 1) + FibonacciRekurencyjny(n - 2);
        }
        static long FibonacciRekurencyjny2(int n)
        {
            // sprawdzanie warunku brzegowego
            if (n > 1)
                return FibonacciRekurencyjny2(n - 1) + FibonacciRekurencyjny2(n - 2);
            return 1;
        }
        static long FibonacciIteracyjny(int n)
        {
            if (n > 1)
            {
                // pomocnicze deklaracje
                long F, Fp, Fpp;
                // ustalenie stanu początkowego
                F = 0; Fpp = 1; Fp = 1;
                for(ushort i = 2; i <= n; i++)
                {
                    // wyznaczenie i-tego wyrazu ciągu Fibonacciego
                    F = Fp + Fpp;
                    // uaktualnienie wyrazu Fp i Fpp dla obliczenia wyrazu i+1
                    Fpp = Fp;
                    Fp = F;
                }
                return F;
            }
            return 1;
        }
        static void Hanoi(char A, char B, char C, int n)
        {
            if (n == 1)
                Console.WriteLine("\n\tPrzenieś krążek z wieży " + char.ToUpper(A) + " i połóż go na wierzchołku wieży " + char.ToUpper(C));
            else
            {
                Hanoi(A, C, B, n - 1);
                Console.WriteLine("\n\tPrzenieś krążek z wieży " + char.ToUpper(A) + " i połóż go na wierzchołku wieży " + char.ToUpper(C));
                Hanoi(B, A, C, n - 1);
            }
        }
        static void Main(string[] args)
        {
            char WybranaFunkcjonalność;
            ushort N;
            Console.WriteLine("\n\n\t\t\t Wieże HANOI");
            do
            {
                Console.WriteLine("\tA. Wieże Hanoi\n");
                Console.WriteLine("\tX. Zakończenie programu\n");
                Console.WriteLine("\n\tWybierz jedną z funkcjonalnośći");
                char.TryParse(Console.ReadLine(), out WybranaFunkcjonalność);

                //rozpoznanie wybranych funkconajlności
                if (WybranaFunkcjonalność == 'a' || WybranaFunkcjonalność == 'A')
                {
                    Console.WriteLine("\tPodaj liczbę krążków: ");
                    while (!ushort.TryParse(Console.ReadLine(), out N))
                    {
                        Console.WriteLine("\n\tERROR: wystąpił niedozwolony znak w zapisie liczby krążków");
                        Console.WriteLine("\nPodaj ponownie liczbę krążków: ");
                    }
                    // wywołanie metody Hanoi
                    Hanoi('A', 'B', 'C', N);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji programu...");
                    Console.ReadKey();
                }
            } while (WybranaFunkcjonalność != 'X' || WybranaFunkcjonalność != 'x');
            Console.WriteLine("\n\tNaciśnij dowolny klawisz dla zakończenia programu...");
            Console.ReadKey();
        }
    }
}
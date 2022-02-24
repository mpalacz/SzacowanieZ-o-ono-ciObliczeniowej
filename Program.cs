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
            // zwrot na przekazanie wyniku
            return KolejnaWartośćSilni;
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
        }
    }
}

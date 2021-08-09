using System;

namespace Macierze
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Macierz macierz = new Macierz(2,2);
            Console.WriteLine("\n wiersze : "+ macierz.getRows() + "\nkolumny: "+ macierz.getCols());
            macierz.losowanieMacierzy();
            macierz.wyswietlenieMacierzy();
            Console.WriteLine();
            var wyznacznik = macierz.wyznacznikMacierzy();
            if(wyznacznik != 0)
               macierz.odwracanieMacierzy();
            
        }
    }
}

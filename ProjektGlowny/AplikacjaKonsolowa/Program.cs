using System;
using BibliotekaWspolna;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siema");

            Test test = new Test();
                test.TestBibliotekiWspolnej();
            test.TestNowejFunkcjonalnosciPiotr();
        }
    }
}

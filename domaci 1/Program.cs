using System;
using System.Collections.Generic;

namespace Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Banka> lstBanka = new List<Banka>();
            Admin.Unos(lstBanka);
            Admin.Ispis(lstBanka);
            Admin.NajviseZaNagrade(lstBanka);
            Console.ReadKey();
        }
    }
}
// Od Duje i Gabi

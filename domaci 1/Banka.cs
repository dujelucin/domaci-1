using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace Ponavljanje
{
    public class Banka
    {
        string _naziv, _adresa;
        List<Stedisa> lstStedisa = new List<Stedisa>();

        public Banka()
        {
            Console.Write("Unesi naziv banke: ");
            _naziv = Console.ReadLine();

            Console.Write("Unesi adresu banke: ");
            _adresa = Console.ReadLine();

            Console.Write("Unesi broj štediša: ");
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                Stedisa s = new Stedisa();
                lstStedisa.Add(s);
            }
        }

        public void NoviStedisa()
        {
            Stedisa s = new Stedisa();
            lstStedisa.Add(s);
        }

        public void ObrisiStedisa()
        {
            Console.Write("Unesi matični broj za brisanje: ");
            string mb = Console.ReadLine();
            Stedisa trazeni = null;

            foreach (Stedisa s in lstStedisa)
            {
                if (s.MaticniBroj == mb)
                {
                    trazeni = s;
                    break;
                }
            }

            if (trazeni == null)
                Console.WriteLine("Štediša nije pronađen.");
            else
                lstStedisa.Remove(trazeni);
        }

        public double Najbogatiji()
        {
            double max = 0;
            foreach (Stedisa s in lstStedisa)
            {
                if (s.Iznos > max)
                    max = s.Iznos;
            }
            return max;
        }

        public double UkupneNagrade()
        {
            double suma = 0;
            foreach (Stedisa s in lstStedisa)
                suma += s.Nagrada();
            return suma;
        }

        public void Ispis()
        {
            Console.WriteLine("Banka: {0}, Adresa: {1}", _naziv, _adresa);
            foreach (Stedisa s in lstStedisa)
                s.Ispis();
        }

        public string Naziv
        {
            get { return _naziv; }
        }
    }
}
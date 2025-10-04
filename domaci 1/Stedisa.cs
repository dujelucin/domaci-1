using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Stedisa : Osoba
    {
        double _iznosStednje;
        DateTime _datumAktivacije;
        public Stedisa()
        {
            Console.Write("Unesi ime: ");
            Ime = Console.ReadLine();

            Console.Write("Unesi prezime");
            Prezime = Console.ReadLine();

            Console.Write("Unesi datum rodjenja");
            DatumRodenja = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesi matični broj");
            MaticniBroj = Console.ReadLine();

            Console.Write("Unesi iznos stednje");
            _iznosStednje = double.Parse(Console.ReadLine());

            Console.Write("Unesi datum aktivacije stednje");
            _datumAktivacije = DateTime.Parse(Console.ReadLine());
        }
        public double Nagrada()
        {
            if ((DateTime.Now - _datumAktivacije).TotalDays > 365 * 20)
                return _iznosStednje * 0.02;
            else
                return 0;
        }

        public double Iznos
        {
            get { return _iznosStednje; }
        }
        public void Ispis()
        {
            Console.WriteLine("{0} {1}, MaticniBroj: {2}, Štednja: {3}, Nagrada: {4}",
                Ime, Prezime, MaticniBroj, _iznosStednje, Nagrada());
        }
    }
}

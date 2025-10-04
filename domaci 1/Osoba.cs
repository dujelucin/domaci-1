using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Osoba
    {
        string _ime, _prezime;
        DateTime _datumRodenja;
        string _maticniBroj;

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string MaticniBroj { get; set; }
    }
}

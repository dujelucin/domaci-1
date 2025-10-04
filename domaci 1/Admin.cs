using System;
using System.Collections.Generic;

namespace Ponavljanje
{
    public static class Admin
    {
        public static void Unos(List<Banka> lstBanka)
        {
            Console.Write("Unesi broj banaka: ");
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                Banka b = new Banka();
                lstBanka.Add(b);
            }
        }

        public static void Ispis(List<Banka> lstBanka)
        {
            foreach (Banka b in lstBanka)
                b.Ispis();
        }

        public static void NajviseZaNagrade(List<Banka> lstBanka)
        {
            Banka maxBanka = lstBanka[0];
            foreach (Banka b in lstBanka)
            {
                if (b.UkupneNagrade() > maxBanka.UkupneNagrade())
                    maxBanka = b;
            }
            Console.WriteLine("Najviše za nagrade izdvaja banka: {0}", maxBanka.Naziv);
        }
    }
}
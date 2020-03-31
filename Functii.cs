using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Functii
    {
        public void Meniu(ref string optiune)
        {
            Console.Clear();
            Console.WriteLine("A.Adaugare Card");
            Console.WriteLine("L.Afisare info despre toate cardurile");
            Console.WriteLine("C.Afisare nr criptate pt toate cardurile");
            Console.WriteLine("T.Afisare tip pentru utilizator cautat dupa nume");

            Console.WriteLine("X.Exit");
            Console.WriteLine("---------------------");
            Console.WriteLine("Introduceti optiunea");
            optiune = Console.ReadLine();
            Console.WriteLine("---------------------\n");
        }
    }

}

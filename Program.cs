using System;
using System.Collections.Generic;

namespace Card
{
    class Program
    {
        static void Main(string[] args)
        {
            Functii functii = new Functii();
            string optiune=string.Empty;
            List<CardBancar> banca = new List<CardBancar>();

            do
            {
                functii.Meniu(ref optiune);
                switch (optiune.ToUpper())
                {
                   case "A":
                        Console.WriteLine("Introduceti numele ");
                        string nume = Console.ReadLine();
                        Console.WriteLine("Introduceti prenumele ");
                        string prenume = Console.ReadLine();
                        Console.WriteLine("Introduceti numar card (16 cifre) ");
                        string numar = Console.ReadLine();
                        if(numar.Length!=16)
                        {
                            Console.WriteLine("Card gresit ");
                            Console.ReadKey();
                                return;
                              
                        }
                        banca.Add(new CardBancar(nume, prenume, numar));
                        break;
                    case "L":
                        foreach (var card in banca)
                            Console.WriteLine(card.ConversieLaSir);
                        Console.ReadKey();
                        break;
                    case "C":
                        foreach(var card in banca)
                            Console.WriteLine(card.Criptare());
                        Console.ReadKey();
                        break;
                    case "T":
                        string cauta;
                        Console.WriteLine("Introduceti nume");
                        cauta = Console.ReadLine();
                        foreach(var card in banca)
                        {
                            if (string.Equals(cauta, card.Nume))
                                Console.WriteLine(card.TipCard);
                        }


                        Console.ReadKey();
                        break;





                    default:
                        Console.Clear();
                        Console.WriteLine("Optiune invalida");
                        Console.ReadKey();
                        break;
                    case "X":
                        return;

                }
            } while (true);




        }
    }
}

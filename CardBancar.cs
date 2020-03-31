using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class CardBancar
    {
        public enum Tip
        {
            Visa = 1,
            MasterCard = 2,
            Maestro = 3,
        }

        string nume { get; set; }
        string prenume { get; set; }
        string numarCard { get; set; }
        public CardBancar()
        {
            nume = "null";
            prenume = "null";
            numarCard = "null";
        }
        public CardBancar(string nume, string prenume, string numar)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.numarCard = numar;
        }
        public Tip TipCard
            {
            get { return (Tip)Convert.ToInt32(numarCard[0].ToString()); }
            }
        
        public string ConversieLaSir
        {
            get
            {
                return string.Format("Persoana {0} {1} detine cardul cu numarul {2}.", nume, prenume, numarCard);
            }

        }
        public string  Nume
         {

            get { return nume; }
        }
        public string NrCard
        {
            get { return numarCard; }

        }

        public string Criptare()
        {
            int ok = 0;
            string criptat=String.Empty;
            for(int i=0;i<numarCard.Length;i++)
            {
                
              
                if(ok==4)
                {
                    criptat = criptat + '-';
                    ok = 0;
                    
                }
                if(i<12)
                {

                    criptat = criptat + 'X';
                }
                else
                {
                    criptat = criptat + numarCard[i];
                }
                ok++;

            }
            return criptat;
        }
    }
}

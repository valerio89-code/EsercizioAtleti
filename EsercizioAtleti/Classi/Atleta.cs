using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAtleti.Classi
{
    class Atleta
    {
        public string Nominativo { get; set; }
        public int Età { get; set; }
        public string Nazionalità { get; set; }

        public virtual void ChiediDati()
        {
            Console.WriteLine("Inserisci il nominativo");
            Nominativo = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            Età = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la nazionalità");
            Nazionalità = Console.ReadLine();
        }

        public virtual void StampaDati()
        {
            Console.WriteLine($"Nome: {Nominativo}");
            Console.WriteLine($"Età: {Età}");
            Console.WriteLine($"Nazionalità: {Nazionalità}");
        }

        public bool IsJuniores()
        {
            return Età < 18;
        }

        public virtual bool IsOver()
        {
            return Età > 35;
        }
    }
}

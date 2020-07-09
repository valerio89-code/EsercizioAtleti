using EsercizioAtleti.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAtleti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuoi un atleta o un calciatore?");
            string scelta = Console.ReadLine();
            //Atleta, aTLEta
            Atleta atl = GetAtleta(scelta);
            if(atl == null)
            {
                Console.WriteLine("scelta non valida");
                return;
            }
            atl.ChiediDati();
            atl.StampaDati();
            if (atl.IsJuniores()) Console.WriteLine("giocatore juniores");
            if (atl.IsOver()) Console.WriteLine("giocatore over");
        }

        private static Atleta GetAtleta(string scelta)
        {
            Atleta atl = null;
            if (scelta.Equals("atleta", StringComparison.InvariantCultureIgnoreCase))
            {
                atl = new Atleta();
            }
            if (scelta.Equals("calciatore", StringComparison.InvariantCultureIgnoreCase))
            {
                atl = new Calciatore();
            }
            return atl;
        }
    }
}

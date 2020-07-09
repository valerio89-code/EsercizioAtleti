using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAtleti.Classi
{
    class Calciatore : Atleta
    {
        public string Squadra { get; set; }
        public int NumeroMaglia { get; set; }
        public RuoloCalciatore Ruolo { get; set; }

        public override void ChiediDati()
        {
            base.ChiediDati();
            Console.WriteLine("Inserisci la squadra");
            Squadra = Console.ReadLine();
            Console.WriteLine("Inserisci il numero della maglia");
            NumeroMaglia = int.Parse(Console.ReadLine());
            ChiediRuolo();
        }

        private void ChiediRuolo()
        {
            Console.WriteLine("Scegli ruolo");
            string[] ruoliPossibili = Enum.GetNames(typeof(RuoloCalciatore));
            for (int i = 0; i < ruoliPossibili.Length; i++)
            {
                Console.WriteLine($"scrivere {i} per {ruoliPossibili[i]}");
            }
            int indiceRuoloScelto = int.Parse(Console.ReadLine());
            Ruolo = (RuoloCalciatore)Enum.Parse(typeof(RuoloCalciatore), ruoliPossibili[indiceRuoloScelto]);
        }

        public override void StampaDati()
        {
            base.StampaDati();
            Console.WriteLine($"Squadra: {Squadra}");
            Console.WriteLine($"Numero di maglia: {NumeroMaglia}");
            Console.WriteLine($"Ruolo: {Ruolo}");
        }

        public override bool IsOver()
        {
            return Ruolo == RuoloCalciatore.Portiere ? Età > 40 : base.IsOver();
        }
    }
}

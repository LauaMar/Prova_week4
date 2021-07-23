using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
   public class Squadra
    {
        public string Nome { get; set; }
        public string DataFondazione { get; set; }
        public string Campionato { get; set; }
        public string NomePresidente { get; set; }
        public string NomeAllenatore { get; set; }
        public List<Giocatore> Rosa { get; set; }

        public Squadra()
        {


        }

        public Squadra(List<Giocatore> rosa)
        {
            Nome = "Cagliari";
            DataFondazione = "30-5-1920";
            Campionato = "Serie A";
            NomeAllenatore = "Leonardo Semplici";
            NomePresidente = "Tommaso Giulini";
        }

   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    public class Centrocampista : Giocatore
    {
        public int PassaggiTentati { get; set; }
        public int PassaggiRiusciti { get; set; }

        public Centrocampista()
        {

        }

        public Centrocampista (int id, string nome, DateTime dataNascita, int numeroMaglia)
        {
            ID = id;
            NomeGiocatore = nome;
            DataNascita = dataNascita;
            NumeroMaglia = numeroMaglia;
        }

        public override string ToString()
        {
            return base.ToString() + $", [CENTROCAMPISTA] Passaggi Tentati: {PassaggiTentati}, Passaggi Riusciti: {PassaggiRiusciti}";
        }

        public override string ToStringRidotto()
        {
            return base.ToStringRidotto() + $", [CENTROCAMPISTA] Passaggi Tentati: {PassaggiTentati}, Passaggi Riusciti: {PassaggiRiusciti}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    public class Difensore : Giocatore
    {
        public int TackleRiusciti { get; set; }

        public Difensore()
        {

        }
        public Difensore(int id, string nome, DateTime dataNascita, int numeroMaglia)
        {
            ID = id;
            NomeGiocatore = nome;
            DataNascita = dataNascita;
            NumeroMaglia = numeroMaglia;
        }

        public override string ToString()
        {
            return base.ToString() + $", [DIFENSORE] Tackle: {TackleRiusciti}";
        }

        public override string ToStringRidotto()
        {
            return base.ToStringRidotto() + $", [DIFENSORE] Tackle: {TackleRiusciti}";
        }


    }
}

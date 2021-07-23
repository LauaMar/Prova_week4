using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    public class Attaccante : Giocatore
    {
        public int GoalRealizzati { get; set; }

        public Attaccante()
        {

        }

        public Attaccante(int id, string nome, DateTime dataNascita, int numeroMaglia)
        {
            ID = id;
            NomeGiocatore = nome;
            DataNascita = dataNascita;
            NumeroMaglia = numeroMaglia;
        }


        public override string ToString()
        {
            return base.ToString() + $", [ATTACCANTE] Gol Realizzati: {GoalRealizzati}";
        }
        public override string ToStringRidotto()
        {
            return base.ToStringRidotto() + $", [ATTACCANTE] Gol Realizzati: {GoalRealizzati}";
        }
    }  

   
}

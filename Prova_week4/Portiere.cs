using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    public class Portiere : Giocatore
    {
        public int GolSubiti { get; set; }
        public int RigoriParati { get; set; }


        public Portiere()
        {

        }

        public Portiere(int id, string nome, DateTime dataNascita, int numeroMaglia)
        {
            ID = id;
            NomeGiocatore = nome;
            DataNascita = dataNascita;
            NumeroMaglia = numeroMaglia;
        }

        public override string ToString()
        {
            return base.ToString() + $", [PORTIERE] Gol Subiti: {GolSubiti}, Rigori Parati: {RigoriParati}";
        }

        public override string ToStringRidotto()
        {
            return base.ToStringRidotto() + $", [PORTIERE] Gol Subiti: {GolSubiti}, Rigori Parati: {RigoriParati}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    public class Giocatore
    {
        public int ID { get; set; }
        public int NumeroMaglia { get; set; }

        public string NomeGiocatore { get; set; }

        public DateTime DataNascita { get; set; }
        public bool Titolare { get; set; }

        public Giocatore()
        {
                
        }

        public Giocatore(int id, string nome, DateTime dataNascita, int numeroMaglia)
        {
            ID = id;
            NomeGiocatore = nome;
            DataNascita = dataNascita;
            NumeroMaglia = numeroMaglia;
        }

        public virtual string ToString()
        {
            return $"{ID}--> Titolare: {(Titolare ? "Si" : "No")}, Nome: {NomeGiocatore}, DataNascita: {(DataNascita.Date).ToString("d")}, Maglia numero: {NumeroMaglia}";
        }

        public virtual string ToStringRidotto()
        {
            return $"{ID}--> Nome: {NomeGiocatore}, DataNascita:  {(DataNascita.Date).ToString("d")}, Maglia numero: {NumeroMaglia}";
        }
    }

}

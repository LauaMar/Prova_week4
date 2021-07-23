using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    class Manager
    {
        public static List<Giocatore> RosaGiocatori = new List<Giocatore>
        {
        new Portiere() {ID=1, NomeGiocatore = "Giuseppe Ciocci", DataNascita=new DateTime(2002, 01, 24), NumeroMaglia=34, GolSubiti=12,RigoriParati =10,Titolare=false},
        new Portiere(){ID=2, NomeGiocatore= "Alessio Cagno", DataNascita= new DateTime(1994, 06, 08), NumeroMaglia=28, GolSubiti=1,RigoriParati= 0,Titolare=true},
        new Portiere() {ID=3, NomeGiocatore = "Boris Radunovic", DataNascita=new DateTime(1996, 05, 08), NumeroMaglia=31, GolSubiti=14,RigoriParati=0,Titolare=false},
        new Difensore(){ID=4, NomeGiocatore = "Giorgio Altare", DataNascita=new DateTime(1998, 08, 09), NumeroMaglia=89, TackleRiusciti=29,Titolare=true},
        new Difensore(){ID=5, NomeGiocatore = "Salvatore Boccia", DataNascita=new DateTime(2001, 06, 06), NumeroMaglia=36, TackleRiusciti=24,Titolare=false},
        new Difensore(){ID=6, NomeGiocatore = "Andrea Carboni", DataNascita=new DateTime(2001, 02, 04), NumeroMaglia=44, TackleRiusciti=3,Titolare=true},
        new Difensore(){ID=7, NomeGiocatore = "Diego Godin", DataNascita=new DateTime(1986, 02, 21), NumeroMaglia=2, TackleRiusciti=4,Titolare=true},
        new Difensore(){ID=8, NomeGiocatore = "Alessandro Tripaldelli", DataNascita=new DateTime(1999, 02, 09), NumeroMaglia=3, TackleRiusciti=66,Titolare=true},
        new Difensore(){ID=9, NomeGiocatore = "Gabriele Zappa", DataNascita=new DateTime(1999, 12, 22), NumeroMaglia=42, TackleRiusciti=3,Titolare=false},
        new Centrocampista() {ID=10, NomeGiocatore = "Roberto Biancu", DataNascita=new DateTime(2000, 01, 19), NumeroMaglia=90, PassaggiRiusciti=13,PassaggiTentati=19,Titolare=false},
        new Centrocampista() {ID=11, NomeGiocatore = "Alessandro Deiola", DataNascita=new DateTime(1995, 08, 01), NumeroMaglia=14, PassaggiRiusciti=16,PassaggiTentati=20,Titolare=true},
        new Centrocampista() {ID=12, NomeGiocatore = "Joao Pedro", DataNascita=new DateTime(1992, 03, 04), NumeroMaglia=10, PassaggiRiusciti=30,PassaggiTentati=31,Titolare=false},
        new Centrocampista() {ID=13, NomeGiocatore = "Ravdan Marin", DataNascita=new DateTime(1996, 05, 23), NumeroMaglia=8, PassaggiRiusciti=13,PassaggiTentati=30,Titolare=true},
        new Centrocampista() {ID=14, NomeGiocatore = "Gaston Pereiro", DataNascita=new DateTime(1995,11, 06), NumeroMaglia=20, PassaggiRiusciti=5,PassaggiTentati=10,Titolare=true},
        new Centrocampista() {ID=15, NomeGiocatore = "Marco rog", DataNascita=new DateTime(1995,07,19), NumeroMaglia=6, PassaggiRiusciti=13,PassaggiTentati=30,Titolare=true},
        new Attaccante(){ID=16,NomeGiocatore="Alberto Perri", DataNascita=new DateTime(1996,04,16), NumeroMaglia=27, GoalRealizzati=19,Titolare=true},
        new Attaccante(){ID=17,NomeGiocatore="Zito Luvumbo", DataNascita=new DateTime(2002,03,09), NumeroMaglia=26, GoalRealizzati=5,Titolare=false},
        new Attaccante(){ID=18,NomeGiocatore="Leonardo Pavoletti", DataNascita=new DateTime(1988,11,26), NumeroMaglia=30, GoalRealizzati=30,Titolare=true},
        new Attaccante(){ID=19,NomeGiocatore="Giovanni Simeone", DataNascita=new DateTime(1995,07,06), NumeroMaglia=9, GoalRealizzati=0,Titolare=false},
        };

        public static void AggiungiGiocatore(int id)
        {
            int sceltaRuolo = -1;
            DateTime dataNascita =new DateTime();
            int numeroMaglia;
            Console.WriteLine("Inserisci il nome del giocatore:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci la data di nascita: ");
            while(!DateTime.TryParse(Console.ReadLine(), out dataNascita))
            {
                Console.WriteLine("Hai inserito una data di nascita non valida, riprova");
            }

            Console.WriteLine("Inserisci il numero di maglia del giocatore");
            while (!(int.TryParse(Console.ReadLine(), out numeroMaglia) && numeroMaglia > 0 && numeroMaglia < 100))
            {
                Console.WriteLine("Inserimento non corretto, riprova)");
            }
            
            Console.WriteLine("Che tipo di giocatore vuoi aggiungere?");
            Console.WriteLine("Premi 1 per Portiere");
            Console.WriteLine("Premi 2 per Difensore");
            Console.WriteLine("Premi 3 per CentroCampista");
            Console.WriteLine("Premi 4 per Attaccante");
            while (!int.TryParse(Console.ReadLine(), out sceltaRuolo) && sceltaRuolo > 0)
            {
                Console.WriteLine("La tua scelta non è corretta, riprova");
            }

            switch (sceltaRuolo)
            {
                case 1:
                    Portiere p = new Portiere(id, nome, dataNascita, numeroMaglia);
                    int golSubiti = -1;
                    int rigoriParati = -1;

                    Console.WriteLine("Inserisci il numero di goal subiti:");
                    VerificaInserimentoInteri(out golSubiti);
                    p.GolSubiti = golSubiti;

                    Console.WriteLine("Inserisci il numero di rigori parati:");
                    VerificaInserimentoInteri(out rigoriParati);
                    p.RigoriParati = rigoriParati;
                    RosaGiocatori.Add(p);
                    break;
                case 2:
                    Difensore d = new Difensore(id, nome, dataNascita, numeroMaglia);
                    int tackle = -1;

                    Console.WriteLine("Inserisci il numero di tackle riusciti:");
                    VerificaInserimentoInteri(out tackle);
                    d.TackleRiusciti = tackle;
                    RosaGiocatori.Add(d);
                    break;
                case 3:
                    Centrocampista c = new Centrocampista(id, nome, dataNascita, numeroMaglia);
                    int passaggiTentati = -1;
                    int passaggiRiusciti = -1;
                    Console.WriteLine("Inserisci il numero di passaggi tentati:");
                    VerificaInserimentoInteri(out passaggiTentati);
                    c.PassaggiTentati = passaggiTentati;

                    Console.WriteLine("Inserisci il numero di passaggi riusciti:");
                    VerificaInserimentoInteri(out passaggiRiusciti);
                    c.PassaggiRiusciti = passaggiRiusciti;
                    RosaGiocatori.Add(c);
                    break;
                case 4:
                    Attaccante a = new Attaccante(id, nome, dataNascita, numeroMaglia);
                    int golRealizzati = -1;
                    Console.WriteLine("Inserisci il numero di gol realizzati:");
                    VerificaInserimentoInteri(out golRealizzati);
                    a.GoalRealizzati = golRealizzati;
                    RosaGiocatori.Add(a);
                    break;
                default:
                    Console.WriteLine("Hai inserito un valore non associato a ruoli!");
                    //Giocatore g = null;
                    break;
            };



        }

        public static void VendiGiocatore()
        {
            int giocatoreDaVendere = -1;
            Giocatore currG = null;
            if (RosaGiocatori.Count == 0)
                Console.WriteLine("Non ci sono giocatori in rosa");
            else
            {
                Console.WriteLine("I giocatori attualmente in rosa sono:");
                StampaGiocatore();
                Console.WriteLine("Scrivi il numero del giocatore da vendere:");
                while (!(int.TryParse(Console.ReadLine(), out giocatoreDaVendere) && giocatoreDaVendere >= 0))
                {
                    Console.WriteLine("Nessun giocatore con quel numero, riprova");
                }
                foreach (Giocatore g in RosaGiocatori)
                {
                    if (g.ID == giocatoreDaVendere)
                        currG = g;

                }
                if (currG == null)
                    Console.WriteLine("Nessun giocatore con quel numero");
                else
                {
                    RosaGiocatori.Remove(currG);
                    Console.WriteLine("Giocatore rimosso con successo");
                }
            }
        }

        public static void GestisciSquadraTitolare()
        {
            List<Giocatore> rosaTitolari = new List<Giocatore>();
            List<Giocatore> rosaRiserve = new List<Giocatore>();
            foreach (Giocatore g in RosaGiocatori)
            {
                if (g.Titolare)
                    rosaTitolari.Add(g);
                else
                    rosaRiserve.Add(g);
            }

                int idTitolare = -1;
                int idRiserva = -1;
                Giocatore currTit = null;
                Giocatore currRis = null;
                Console.WriteLine("L'attuale rosa dei titolari è: ");
                StampaGiocatore(rosaTitolari);
                Console.WriteLine("Seleziona l'ID del giocatore da rimuovere dai titolari:");
                while (currTit == null)
                {
                    VerificaInserimentoInteri(out idTitolare);
                    foreach (Giocatore tit in rosaTitolari)
                    {
                        if (tit.ID == idTitolare)
                        {
                            currTit = tit;
                            Console.WriteLine($"Giocatore {idTitolare} selezionato con successo!");
                        }
                    }
                    if (currTit == null)
                        Console.WriteLine("Nessun giocatore associato all'ID selezionato, inseriscne un altro");
                }
                Console.WriteLine("L'attuale rosa delle riserve è: ");
                StampaGiocatore(rosaRiserve);
                Console.WriteLine("Seleziona l'ID del giocatore da promuovere titolare:");
                while (currRis == null)
                {
                    VerificaInserimentoInteri(out idRiserva);
                    foreach (Giocatore ris in rosaRiserve)
                    {
                        if (ris.ID == idRiserva)
                        {
                            currRis = ris;
                            Console.WriteLine($"Giocatore {idRiserva} selezionato con successo!");
                        }
                    }
                    if (currRis == null)
                        Console.WriteLine("Nessun giocatore associato all'ID selezionato, inserisci un altro ID");
                }
            if ((currTit is Portiere && currRis is Portiere) || (currTit is Difensore && currRis is Difensore) || (currTit is Centrocampista && currRis is Centrocampista) || (currTit is Attaccante && currRis is Attaccante))
            {
                currTit.Titolare = false;
                currRis.Titolare = true;
                rosaRiserve.Add(currTit);
                rosaTitolari.Add(currRis);
                rosaTitolari.Remove(currTit);
                rosaRiserve.Remove(currRis);
            }
            else
            { Console.WriteLine("Errore! lo schema deve essere 4-4-2"); }

                Console.WriteLine("La nuova rosa dei titolari è: ");
                StampaGiocatore(rosaTitolari);
                Console.WriteLine("La nuova rosa delle riserve è: ");
                StampaGiocatore(rosaRiserve);
        } 

        public static void StampaStatisticheTitolari()
        {
            List<Giocatore> rosaTitolari = new List<Giocatore>();
            foreach (Giocatore g in RosaGiocatori)
            {
                if (g.Titolare)
                    rosaTitolari.Add(g);
            }
            StampaGiocatoreRidotto(rosaTitolari);
        }

        public static void StampaGiocatore()
        {
            StampaGiocatore(RosaGiocatori);
        }

        public static void StampaGiocatore(List<Giocatore> lista)
        {
            foreach(Giocatore g in lista)
            {
                Console.WriteLine(g.ToString());
            }
        }

        public static void StampaGiocatoreRidotto(List<Giocatore> lista)
        {
            foreach (Giocatore g in lista)
            {
                Console.WriteLine(g.ToStringRidotto());
            }
        }

        public static void VerificaInserimentoInteri(out int intero)
        {
            while (!(int.TryParse(Console.ReadLine(), out intero) && intero >= 0))
            {
                Console.WriteLine("La tua scelta non è corretta, riprova");
            }
        }
    }
}

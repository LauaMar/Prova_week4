using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_week4
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("====Benvenuto====");

            int idGiocatore = Manager.RosaGiocatori.Count + 1;
            //int idGiocatore = 20;
            string sceltaMenu = "";
            bool uscita = false;
            Squadra Cagliari = new Squadra(Manager.RosaGiocatori);
            Console.WriteLine($"La nostra squadra è: {Cagliari.Nome} ");
            Console.WriteLine($"=== Fino dal {Cagliari.DataFondazione}===");
            Console.WriteLine($"Allenatore: {Cagliari.NomeAllenatore}");
            Console.WriteLine($"Presidente: {Cagliari.NomePresidente}");
            Console.WriteLine();
            while (!uscita)
            {
                Console.WriteLine("Scegli l'azione da compiere:");
                Console.WriteLine("Premi 1 per aggiungere un giocatore alla squadra,");
                Console.WriteLine("Premi 2 per vendere un giocatore,");
                Console.WriteLine("Premi 3 per modificare la squadra titolare,");
                Console.WriteLine("Premi 4 per stampare le statistiche della squadra titolare,");
                Console.WriteLine("Premi q per uscire.");
                sceltaMenu = Console.ReadLine();

                switch (sceltaMenu)
                {
                    case "1":
                        Manager.AggiungiGiocatore(idGiocatore);
                        idGiocatore++;
                        break;
                    case "2":
                        Manager.VendiGiocatore();
                        break;
                    case "3":
                        Manager.GestisciSquadraTitolare();
                        break;
                    case "4":
                        Manager.StampaStatisticheTitolari();
                        break;
                    case "q":
                        uscita = true;
                        break;
                    default:
                        Console.WriteLine("Hai inserito una scelta non valida, riprova");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Arrivederci!");
        }
    }
}

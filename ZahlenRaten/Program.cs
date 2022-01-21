using System;

namespace ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spielernamen abfragen und Player Objekte anlegen

            // Spieler 1
            Console.WriteLine("Name Spieler 1:");
            string namePlayer1 = Console.ReadLine();
            Player player1 = new Player(namePlayer1);
            Console.WriteLine("Hallo " + player1.Name);
            Console.WriteLine();

            // Spieler 2
            Console.WriteLine("Name Spieler 1:");
            string namePlayer2 = Console.ReadLine();
            Player player2 = new Player(namePlayer2);
            Console.WriteLine("Hallo " + player2.Name);
            Console.WriteLine();

            
            // Zufallszahl erzeugen
            Random random = new Random();
            int gesuchteZahl = random.Next(1000);

            Console.WriteLine("Errate die Zahl!");
            Console.WriteLine();


            // player1 fängt an
            Player anDerReihe = player1;


            // game loop
            while (true)
            {
                // Spieler an der Reihe ausgeben
                Console.WriteLine(anDerReihe.Name + " ist an der Reihe.");

                // Erhöhe die Anzahl der Versuche für den Spieler
                anDerReihe.Versuche = anDerReihe.Versuche + 1;

                
                // Eingabe lesen
                string eingabe = Console.ReadLine();

                try
                {
                    // Versuche, eEingabe in Zahl umzuwandeln
                    int eingabeAlsZahl = int.Parse(eingabe);

                    if (eingabeAlsZahl == gesuchteZahl) // Zahl wurde erraten
                    {
                        Console.WriteLine("Richtig!");
                        break;
                    }
                    else if (eingabeAlsZahl > gesuchteZahl) // Eingabe ist größer als die gesuchte Zahl
                    {
                        Console.WriteLine("weniger...");
                    }
                    else // Eingabe ist kleiner als die gesuchte Zahl
                    {
                        Console.WriteLine("mehr...");
                    }
                }
                catch (Exception)
                {
                    // Spieler hat keine Zahl eingegeben
                    Console.WriteLine("Das ist keine Zahl!");
                }

                // Spieler wechseln
                if (anDerReihe == player1)
                {
                    anDerReihe = player2;
                }
                else
                {
                    anDerReihe = player1;
                }

                Console.WriteLine();
            }

            // Spiel ist beendet
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine(anDerReihe.Name + " hat gewonnen!");
            Console.WriteLine("***");

            Console.WriteLine();
            Console.WriteLine("Versuche " + player1.Name + ": " + player1.Versuche);
            Console.WriteLine("Versuche " + player2.Name + ": " + player2.Versuche);

        }
    }
}

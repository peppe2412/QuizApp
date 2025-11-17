using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Piccolo applicativo quiz, far rispondere le domande all'utente. 
             * Ci sarà un punteggio finale 
             */


            /* --------------------------------------------------------------- */


            /* 
             * Domande  
             */

            // Domanda inerente alla capitale d'Italia
            string questionAboutCapital = "Qual è la capitale d'Italia?";
            string answerAboutCapital = "Roma";

            // Rimuove sia gli spazi che le maiuscole
            string cleanAnswerAboutCapital = answerAboutCapital.Trim().ToLower();

            // Logica matematica
            string questionAboutLogic =
                "Una moto ha percorso i 7/8 di un certo tragitto. " +
                "Sapendo che ha percorso 56 km, quanti km è lungo l'intero tragitto?";
            string answerAboutLogic = "64";

            //Rimuove sia gli spazi che le maiuscole
            string cleanAnswerLogic = answerAboutLogic.Trim().ToLower();


            /* ---------------------------------------------------------- */


            /*
             * Procedimento per le risposte da parte dell'utente
             */

            // Risposta per la capitale
            Console.WriteLine(questionAboutCapital);

            // Risposta dell'utente
            string userAnswerAboutCapital = Console.ReadLine().Trim().ToLower();

            // Punteggio
            int score = 0;
            
            if(userAnswerAboutCapital == cleanAnswerAboutCapital)
            {
                Console.WriteLine("Corretto");
                score = score + 1;
            }
            else
            {
                Console.WriteLine($"Sbagliato! La risposta giusta è {answerAboutCapital}");
            }

            // Risposta di logica matematica
            Console.WriteLine(questionAboutLogic);

            // Risposta dell'utente
            string userAnswerAboutLogic = Console.ReadLine().Trim().ToLower();

            if (userAnswerAboutLogic == cleanAnswerLogic)
            {
                Console.WriteLine("Corretto");
                score = score + 1;
            }
            else
            {
                Console.WriteLine($"Sbagliato! La risposta giusta è {answerAboutLogic}");
            }

            // Punteggio Finale
            Console.WriteLine($"Quiz completato! Il tuo punteggio è di: {score}/2");

            if (score == 2)
            {
                Console.WriteLine("Hai risposto giusto a tutte le domande");
            } else if (score == 1)
            {
                Console.WriteLine("Hai risposto giusto ad una sola domanda");
            }
            else
            {
                Console.WriteLine("Mi dispiace, ritenta!");
            }
            Console.ReadKey();
        }
    }
}

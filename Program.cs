using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblValeur1;
            double dblValeur2;
            double dblReponse = 0;
            bool isOpIncorrect = false;

            Console.WriteLine("Calculatrice");
            Console.WriteLine("------------");

            //Saisie des opérandes, avec vérification de ces dernières
            Console.Write("Saisir la premiere valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblValeur1))
            {
                Console.Write("Saisir à nouveau la 1ère valeur : ");
            }

            Console.Write("Saisir la deuxieme valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblValeur2))
            {
                Console.Write("Saisir à nouveau la 2ème valeur : ");
            }

            //Saisie du choix de l'opérateur
            Console.Write("Opérations à choix [+ - * / ^] : ");
            while (isOpIncorrect)
            {

            
                string StrOp = Console.ReadLine();
                isOpIncorrect = false;
                switch (StrOp)
                {
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.WriteLine("Veuillez saisir à nouveau l'opérateur [+ - * / ^] : ");
                        isOpIncorrect = true;
                        break;
                    case "+":
                        dblReponse = 0;
                        break;
                    case "-":
                        dblReponse = 0;
                        break;
                    case "*":
                        dblReponse = 0;
                        break;
                    case "/":
                        dblReponse = 0;
                        break;
                    case "^":
                        dblReponse = 0;
                        break;

                }
            }
            Console.Write(dblValeur1.ToString());
            Console.ReadKey();
        }
    }
}

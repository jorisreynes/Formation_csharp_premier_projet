using System;

namespace premier_programme // Note: actual namespace depends on the project name.
{
    class Program


    {
        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = 0;

            while (nombreUtilisateur == 0)
            {
                Console.Write("Entrez un nombre entre " + min + " et " + max + " pour tenter de deviner le nombre magique ");
                string reponse = Console.ReadLine();
                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if (nombreUtilisateur < min || nombreUtilisateur > max)
                    {
                        Console.WriteLine("Erreur vous devez rentrer un nombre entre 1 et 10 ");
                        nombreUtilisateur = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur vous devez rentrer un nombre entre 1 et 10 ");
                }
            }
            return nombreUtilisateur;
        }







        static void Main(string[] args)
        {

            // On définit les constantes qui serviront de limite
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;


            // On génere un nombre aléatoire
            Random aleatoire = new Random();
            int nombreMagique = aleatoire.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = 0;


            int vie = 4;

            while (vie > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nombre de vie: " + vie);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (nombre < nombreMagique)
                {
                    Console.WriteLine("Le nombre à deviner est plus grand");
                }
                else if (nombre > nombreMagique)
                {
                    Console.WriteLine("Le nombre à deviner est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo");
                    break;
                }
                vie--;
            }


            if (vie == 0)
            {
                Console.WriteLine("Perdu, le nombre magique était : " + nombreMagique);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Combien de personnes souhaitez-vous ajouter ?");
            if (!int.TryParse(Console.ReadLine(), out int nombreDePersonnes) || nombreDePersonnes <= 0)
            {
                Console.WriteLine("Veuillez entrer un nombre valide de personnes.");
                return;
            }

            List<Personne> personnes = new List<Personne>();

            // Boucle pour saisir les informations des personnes
            for (int i = 0; i < nombreDePersonnes; i++)
            {
                Console.WriteLine($"Personne {i + 1} :");

                Console.Write("Nom : ");
                string nom = Console.ReadLine();

                Console.Write("Prénom : ");
                string prenom = Console.ReadLine();

                Console.Write("Age : ");
                if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
                {
                    Console.WriteLine("Veuillez entrer un âge valide.");
                    return;
                }

                personnes.Add(new Personne(nom, prenom, age));
            }

            // Affichage des informations des personnes
            Console.WriteLine("\nInformations des personnes :");
            foreach (var personne in personnes)
            {
                personne.GetInfo();
            }

            // Recherche de la personne la plus âgée et la moins âgée
            Personne personnePlusAgee = personnes[0];
            Personne personneMoinsAgee = personnes[0];

            foreach (var personne in personnes)
            {
                if (personne.Age > personnePlusAgee.Age)
                    personnePlusAgee = personne;

                if (personne.Age < personneMoinsAgee.Age)
                    personneMoinsAgee = personne;
            }

            Console.WriteLine($"\nPersonne la plus âgée :");
            personnePlusAgee.GetInfo();

            Console.WriteLine($"\nPersonne la moins âgée :");
            personneMoinsAgee.GetInfo();

            // Calcul de l'âge moyen
            int sommeAges = 0;
            foreach (var personne in personnes)
            {
                sommeAges += personne.Age;
            }

            double ageMoyen = (double)sommeAges / nombreDePersonnes;
            Console.WriteLine($"\nÂge moyen : {ageMoyen:F2}");
        }
    }
}

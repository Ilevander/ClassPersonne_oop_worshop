using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonne
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        // Propriétés avec getters et setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructeur d'initialisation
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        // Méthode getInfo
        public void GetInfo()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}, Age: {Age}");
        }
    }
}

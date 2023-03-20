using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Veterinaire
{
    public class Cabinet
    {
        public Cabinet(string nom)
        {
            Nom = nom;
        }

        public string Nom { get; }

        private List<Animal> animals { get; } = new List<Animal>();

        public void Ajouter(Animal animal)
        {
            bool estContenu = animals.Contains(animal);

            if (estContenu)
            {
                Console.WriteLine("Animal deja chez nous.");
            }
            else
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Nom} est bien enregistré.");
            }

        }
        public void Supprimer(Animal animal)
        {
            bool estContenu = animals.Contains(animal);
            if (estContenu)
            {
                animals.Remove(animal);
                Console.WriteLine($"{animal.Nom} a bien été retiré.");
            }
            else
            {
                Console.WriteLine("L'animal n'est pas chez nous.");
            }
        }
        public void Lister()
        {
            foreach (Animal animal in animals)
            {
                animal.Presenter();
            }
        }
    }
}

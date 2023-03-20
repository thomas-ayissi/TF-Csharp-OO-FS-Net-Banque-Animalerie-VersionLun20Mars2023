using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Veterinaire
{
    public class Animal
    {
        public Animal(string nom, string race, string couleur)
        {
            Nom = nom;
            Race = race;
            Couleur = couleur;
        }
        public string Nom { get; set; }
        public string Race { get; set; }
        public string Couleur { get; set; }
        public void Presenter()
        {
            Console.WriteLine($"Cet animal s'appelle {Nom} et est un {Race} de couleur {Couleur}.");
        }
    }
}

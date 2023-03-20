using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class Stat
    {
        public Stat() 
        {
            Console.WriteLine("Stat instanciée");
        }
        public int PV { get; set; }
        public int Force { get; set; }
    }
    public class Equipement
    {
        public Equipement() 
        { 
            Stat = new Stat();
            Console.WriteLine("Stat d'equipement instancié");
        }
        public Stat Stat { get; set; }
    }
    public class Personnage
    {
        public Personnage()
        {
            Stats = new List<Stat>();
            Console.WriteLine("Liste de mes stats perso instanciée");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stat> Stats { get; set; }

    }
    public class Hero : Personnage
    {
        public Hero() : base()
        {
            Equipements = new List<Equipement>()
            {
                new Equipement()
                {
                    Stat = new Stat()
                    {
                        PV = 10,
                        Force = 10,
                    }
                }
            };
            Console.WriteLine("Equipement du hero instancié");
        }
        public Hero(string name) : this()
        {
            Name = name;
            Console.WriteLine(Name + " créé");
        }
        public Hero(string name,string pseudo) : this(name)
        {
            Pseudo = pseudo;
            Console.WriteLine("Perso a le pseudo " + Pseudo);
        }

        public string Pseudo { get;set; }
        public List<Equipement> Equipements { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class Animal
    {
        public string Name { get; set; }
        public void SeDeplacer()
        {
            Console.WriteLine($"{Name} se deplace...");
        }
    }
    public class Chien : Animal
    {
        public new void SeDeplacer()
        {
            Console.WriteLine($"{Name} le chien marche...");
        }
    }
    public class Oiseau : Animal
    {
        public new void SeDeplacer()
        {
            Console.WriteLine($"{Name} l'oiseau vole");
        }
    }
    public class Poisson : Animal
    {
        public new void SeDeplacer()
        {
            Console.WriteLine($"{Name} le poisson nage...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public abstract class Vehicule
    {
        public string marque;
        public abstract void SeDeplacer();
    }
    public class Voiture : Vehicule
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Et je roule roule roule.");
        }
    }
    public class Bateau : Vehicule
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je flotte");
        }
    }
    public class Avion : Vehicule
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole");
        }
    }
}

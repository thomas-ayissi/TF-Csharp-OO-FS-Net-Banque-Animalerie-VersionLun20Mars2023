using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class Panier
    {
        public List<Fruit> Fruits { get; set; } = new List<Fruit>();

        public static Panier operator +(Panier panier, Fruit fruit)
        {
            panier.Fruits.Add(fruit);
            return panier;
        }

        public static Panier operator +(Panier panier, Panier panier2)
        {
            panier.Fruits.AddRange(panier2.Fruits);
            return panier;
        }
        public static Panier operator ++(Panier panier)
        {
            Fruit monKiwi = new Fruit();
            monKiwi.Nom = "Kiwi";
            panier.Fruits.Add(monKiwi);
            return panier;
        }

        public static bool operator true(Panier panier)
        {
            if (panier == null)
            {
                return false;
            }
            return true;
        }

        public static bool operator false(Panier panier)
        {
            if (panier != null)
            {
                return false;
            }
            return true;
        }
    }

    public class Fruit
    {
        public string Nom { get; set; }
    }
}


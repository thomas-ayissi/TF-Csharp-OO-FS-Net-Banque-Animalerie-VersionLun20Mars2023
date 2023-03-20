using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    internal class Indexeur
    {

        Dictionary<string, string> CartesID = new Dictionary<string, string>
        {
            {"be", "BE253445"},
            {"fr", "FR56874353245625464387546"},
            {"us", "US54362342534453274456"},
            {"mo", "MO568743532456243255464387546"},
        };

        public string this[string key]
        {
            get
            {
                string valeur;

                if (CartesID.TryGetValue(key, out valeur))
                {
                    return valeur;
                }

                return "Not Found";

            }
            set
            {
                CartesID[key] = value;
            }
        }

        public string this[int index]
        {
            get
            {
                return CartesID.ElementAt(index).Value;
            }
            set
            {
                CartesID[CartesID.ElementAt(index).Key] = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public interface IBanker : ICustomer
    {
        Personne Titulaire { get; }
        string Numero { get; }
        void AppliquerInteret();
    }
}

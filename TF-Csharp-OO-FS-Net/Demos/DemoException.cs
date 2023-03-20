using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class PrenomDeMerdeException: Exception
    {
        public PrenomDeMerdeException() :base("Mauvais prenom") { }
        public PrenomDeMerdeException(string message) : base(message) { }
    }
    public class Client
    {
        public string Name { get; set; }
        public Client(string name)
        {
            if (name == "Seb")
                throw new PrenomDeMerdeException("Mais qu'est ce que c'est que ce prenom?");
            if (name == "Baptiste")
                throw new NotSupportedException("Mais t'es pas net Baptiste?!");
            Name = name;
        }
    }
}
